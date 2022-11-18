using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_and_Circumference_of_a_Circle
{
    public class Class1
    {
        double r, Area, Circum;
        const double PI = 3.14;

        public void AreaandCircumference()
        {
            Console.WriteLine("\nEnter your Radius:");
            r = Convert.ToDouble(Console.ReadLine());

            Area = PI * r * r;

            Console.WriteLine("\nArea of a circle=" + Area);

            Circum = 2 * PI * r;

            Console.WriteLine("\nCircumference of a Circle=" + Circum);
        }
    }
}
