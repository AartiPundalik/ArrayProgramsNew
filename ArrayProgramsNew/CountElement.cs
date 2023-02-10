using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramsNew
{
    public class CountElement
    {
        public void Count()
        { 
            var total = 0;

            int[] arr = { 2,3,5,4,7,6,8,7,9 };

            total = arr.Count();

            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
    

