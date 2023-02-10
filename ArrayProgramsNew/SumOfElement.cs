using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramsNew
{
    public class SumOfElement
    {
        public void PrintSum()
        {
            int[] array = { 8, 6, 4, 2, 1, 3, 5, 7 };
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Sum of all Elements of Array is " + sum);
        }
    }
}
        
    

