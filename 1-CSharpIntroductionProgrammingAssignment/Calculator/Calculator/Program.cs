using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;

            Console.WriteLine("Type your first number and then press enter:");
            num1=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type your second number and then press enter:");
            num2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("\nPlease choose the options available from the following list: ");
            Console.WriteLine("\na------Addition");
            Console.WriteLine("s------subtraction");
            Console.WriteLine("a------Multiplication");
            Console.WriteLine("d------Division");
            Console.WriteLine("\nEnter your option and then press enter:");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result:{num1}+{num2}=" +(num1+num2));
                    break;

                case "s":
                    Console.WriteLine($"Your result:{num1}-{num2}=" + (num1 - num2));
                    break;

                case "m":
                    Console.WriteLine($"Your result:{num1}*{num2}=" + (num1 * num2));
                    break;

                case "d":
                    while (num2 == 0)
                    {
                        Console.WriteLine("\nEnter non-zero number");
                        num2=Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine($"\nYour result:{num1}/{num2}=" + (num1 / num2));
                    break;
            }
            Console.ReadLine();
        }
        
    }
}
