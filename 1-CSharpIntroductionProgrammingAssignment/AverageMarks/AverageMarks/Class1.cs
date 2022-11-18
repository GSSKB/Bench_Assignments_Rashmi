using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageMarks
{
    public class Class1
    {
        float m1, m2, m3, m4, m5;
        public void avg()
        {
            Console.WriteLine("Enter average marks of 5 students:");

            m1 = Single.Parse(Console.ReadLine());
            m2 = Single.Parse(Console.ReadLine());
            m3 = Single.Parse(Console.ReadLine());
            m4 = Single.Parse(Console.ReadLine());
            m5 = Single.Parse(Console.ReadLine());

            if (m1 > m2 && m1 > m3 && m1 > m4 && m1 > m5)
            {

                Console.WriteLine("\nThe highest marks is: " + m1);
            }
            else if (m2 > m1 && m2 > m3 && m2 > m4 && m2 > m5)
            {
                Console.WriteLine("\nThe highest marks is: " + m2);
            }
            else if (m3 > m1 && m3 > m2 && m3 > m4 && m3 > m5)
            {
                Console.WriteLine("\nThe highest marks is: " + m3);
            }
            else if (m4 > m1 && m4 > m2 && m4 > m3 && m4 > m5)
            {
                Console.WriteLine("\nThe highest marks is:" + m4);
            }
            else
            {
                Console.WriteLine("The highest marks is:" + m5);
            }
        }
    }
}
