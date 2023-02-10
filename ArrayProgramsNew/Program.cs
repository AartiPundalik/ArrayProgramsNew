using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramsNew
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1 ArrayLength");
            Console.WriteLine("choose the option");
            int opiton = Convert.ToInt32(Console.ReadLine());

            switch (opiton)
            {
                case 1:
                    LengthOfArray arrayLength = new LengthOfArray();
                    arrayLength.CheckLength();
                    break;

            }
            Console.ReadLine();
        }
    }
}