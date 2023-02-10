using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramsNew
{
    public class MaxAndMin
    {
        public void MaxAndMinArray()
        {
            int[] arr = { 8, 6, 4, 2, 1, 3, 5, 7 };
            int max = arr[0];
            int min = arr[0];
            for (int i = 1; i <= arr.Length; i++)
            {
                if (i > max)
                {
                    max = i;
                }

                else if (i < min)
                {
                    min = i;
                }
            }

            Console.WriteLine("The maximum element in the array is: " + max);
            Console.WriteLine("The minimum element in the array is: " + min);
            Console.ReadLine();
        }
    }
}

