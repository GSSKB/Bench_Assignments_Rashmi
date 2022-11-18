using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestDll
{
    class Program
    {
        static void Main(string[] args)
        {
            string DllFile = @"D:\.NET\Bench Practice\Assignment 8 (1)\Assignment 8 (1)\EmployeeFullName\EmployeeFullName\bin\Debug.dll";
            var assembly = Assembly.LoadFile(DllFile);

            var Type = assembly.GetType("EmployeeFullNameLibrary.FullName");

            var obj = Activator.CreateInstance(Type);

            var method = Type.GetMethod("TheFullName");
            var result = method.Invoke(obj, new object[] { "sandeep" , "kumar"});
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
