﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new ServiceReference1.InterfaceForPTMServiceClient().GetSingleRoom("11-4168388");
        }
    }
}