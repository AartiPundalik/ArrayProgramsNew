using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramsNew
{
    public class NegativeNumber
    {
        public void CheckNegative()
        {
            int[] array = { -12, -14, -16, -18, 17, 15, 13, 11 };

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    Console.WriteLine(array[i]);
                }
                    Console.ReadLine();
                
                
            }
        }
    }
}
    

