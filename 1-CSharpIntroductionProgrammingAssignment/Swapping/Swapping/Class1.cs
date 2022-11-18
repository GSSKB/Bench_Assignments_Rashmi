using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    public class Class1
    {
        int num1, num2, temp;
        public void Swapping()
        {
            Console.WriteLine("Enter first number and then press enter:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter second number and then press enter:");
            num2 = int.Parse(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("\nAfter swapping---");

            Console.WriteLine("\nFirst number:" + num1);
            Console.WriteLine("\nSecond number:" + num2);
        }
    }
}
