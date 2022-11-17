using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_int_array
{
    public class Program
    {
        static void Main(string[] args)
        {
            Class1 a=new Class1();
            Class1 b=new Class1();
            Class1 c = new Class1();
            Class1 d = new Class1();

            a.intArray();
            b.sort();
            c.copy();
            d.clear();
            Console.ReadLine();
        }
    }
}
