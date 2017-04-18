using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;
using MyProject;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 11
            var str = "num > 9 ? num.ToString() : '0'.ToString() + num";
            var z = StrToCode(str.Replace("num","7"));
            var z1 = StrToCode(str.Replace("num", "7"));
            #endregion



            var connectionString = "server=10.58.8.33;database=JMS_SH;uid=sa;pwd=1q2w3e`;";
            var conn = new SqlConnection(connectionString);
            conn.Open();
            var selectQuery = "SET FMTONLY ON; select * from @tableName; SET FMTONLY OFF;";
            var command = new SqlCommand(selectQuery, conn);
            var ad = new SqlDataAdapter(command);
            var ds = new DataSet();
            var schema = conn.GetSchema("Tables");
            StringBuilder p = new StringBuilder();
            int num = 1;

            var v = GetDbTables(@"Data Source=10.58.8.33;Initial Catalog=JMS_SH_Wash;User ID=sa;Password=1q2w3e`;",
                "JMS_SH_Wash");

            foreach (DataRow row in schema.Rows)
            {
                ds.Tables.Clear();
                var tb_name = "[" + row["TABLE_NAME"].ToString() + "]";
                command.CommandText = selectQuery.Replace("@tableName", tb_name);
                try
                {
                    ad.FillSchema(ds, SchemaType.Mapped, tb_name);
                    foreach (DataColumn dc in ds.Tables[0].Columns)
                    {
                        var a = "public " + dc.DataType.Name +
                                (dc.AllowDBNull && dc.DataType.Name.ToLower() != "string" ? "? " : " ") +
                                dc.ColumnName +
                                " { get; set; };";
                    }
                    p.AppendLine(tb_name);
                    num++;
                }
                catch (Exception e)
                {
                    var error = e;
                    throw;
                }
            }

            conn.Close();
            p.AppendLine("cout:" + num);
            Console.WriteLine(p);
            //new CodeGeneratorTest().TestMethod();
            Console.ReadKey();
        }

        public static List<DataTable> GetDbTables(string connectionString, string database, string tables = null)
        {

            if (!string.IsNullOrEmpty(tables))
            {
                tables = string.Format(" and obj.name in ('{0}')", tables.Replace(",", "','"));
            }

            #region SQL

            string sql = string.Format(@"SELECT
									obj.name tablename,
									schem.name schemname,
									idx.rows,
									CAST
									(
										CASE 
											WHEN (SELECT COUNT(1) FROM sys.indexes WHERE object_id= obj.OBJECT_ID AND is_primary_key=1) >=1 THEN 1
											ELSE 0
										END 
									AS BIT) HasPrimaryKey                                         
									from {0}.sys.objects obj 
									inner join {0}.dbo.sysindexes idx on obj.object_id=idx.id and idx.indid<=1
									INNER JOIN {0}.sys.schemas schem ON obj.schema_id=schem.schema_id
									where type='U' {1}
									order by obj.name", database, tables);

            #endregion

            DataTable dt = GetDataTable(connectionString, sql);
            return null;
        }

        public static DataTable GetDataTable(string connectionString, string commandText, params SqlParameter[] parms)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = commandText;
                command.Parameters.AddRange(parms);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }

        public static string StrToCode(string str)
        {
            // 1.CSharpCodePrivoder              
            CSharpCodeProvider objCSharpCodePrivoder = new CSharpCodeProvider();
            // 2.ICodeComplier              
            ICodeCompiler objICodeCompiler = objCSharpCodePrivoder.CreateCompiler();
            // 3.CompilerParameters              
            CompilerParameters objCompilerParameters = new CompilerParameters();
            objCompilerParameters.ReferencedAssemblies.Add("System.dll");
            objCompilerParameters.GenerateExecutable = false;
            objCompilerParameters.GenerateInMemory = true;
            // 4.CompilerResults  
            #region 类字符串
            StringBuilder code = new StringBuilder();
            code.Append("using System;");
            code.Append(Environment.NewLine);
            code.Append("namespace DynamicCodeGenerate");
            code.Append(Environment.NewLine);
            code.Append("{");
            code.Append(Environment.NewLine);
            code.Append("      public class Dynamic");
            code.Append(Environment.NewLine);
            code.Append("      {");
            code.Append(Environment.NewLine);
            code.Append("          public string OutPut()");
            code.Append(Environment.NewLine);
            code.Append("          {");
            code.Append(Environment.NewLine);
            code.Append("          return \"FunctionBody\";");
            code.Append(Environment.NewLine); code.Append("          }");
            code.Append(Environment.NewLine); code.Append("      }");
            code.Append(Environment.NewLine); code.Append("}");
            #endregion
            CompilerResults cr = objICodeCompiler.CompileAssemblyFromSource(objCompilerParameters, code.ToString().Replace("\"FunctionBody\"", str));
            string result;
            if (cr.Errors.HasErrors)
            {
                result = "编译错误：";
                foreach (CompilerError err in cr.Errors)
                {
                    result += err.ErrorText;
                }
            }
            else
            {
                // 通过反射，调用HelloWorld的实例                  
                Assembly objAssembly = cr.CompiledAssembly;
                object objHelloWorld = objAssembly.CreateInstance("DynamicCodeGenerate.Dynamic");
                MethodInfo objMI = objHelloWorld.GetType().GetMethod("OutPut");
                result = objMI.Invoke(objHelloWorld, null).ToString();
            }
            return result;
        }
    }

}

