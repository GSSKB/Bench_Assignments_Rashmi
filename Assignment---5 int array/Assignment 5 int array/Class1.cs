using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_int_array
{
    public class Class1
    {
        int[] list = { 26, 9, 19, 99, 7 };


        public void intArray()
        {


            int[] temp = list;

            Console.WriteLine("Original Array: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }


            Array.Reverse(temp);

            Console.Write("\n\nReversed Array: ");
            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }

        }
        public void sort()
        {
            int[] arr1 = new int[5];
            int n, i, j, temp;



            Console.Write("\n\nInput the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInput {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("\nelement - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;
                    }
                }
            }
            Console.Write("\nElements of array in sorted ascending order:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
        }
        public void copy()
        {
            int[] n = new int[10];
            int[] m = new int[5];

            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 50;
            }
            Console.WriteLine("\n\n\nOriginal Array...");
            foreach (int j in n)
            {
                int i = j - 50;
                Console.WriteLine("\nElement[{0}] = {1}", i, j);
            }
            Array.Copy(n, 0, m, 0, 5);
            Console.WriteLine("\nNew Array...");
            foreach (int res in m)
            {
                Console.WriteLine(res);
            }
        }
        public void clear()
        {
            int[] arr = new int[] { 8, 4, 6 };

            Console.WriteLine("\n\n\nArray before clear: ");
            foreach (int val in arr)
            {
                Console.WriteLine(val);
            }

            Array.Clear(arr, 0, arr.Length);

            Console.WriteLine("\nArray after using Clear: ");

            foreach (int val in arr)
            {
                Console.WriteLine(val);
            }
        }
    }
}
