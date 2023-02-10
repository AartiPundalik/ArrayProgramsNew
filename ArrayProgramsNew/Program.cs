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

            Console.WriteLine("1 ArrayLength \n  2 MaxAndMin \n 3 NegativeNumber  \n 4 SumOfElement  \n 5 CountElement");
            Console.WriteLine("choose the option");
            int opiton = Convert.ToInt32(Console.ReadLine());

            switch (opiton)
            {
                case 1:
                    LengthOfArray arrayLength = new LengthOfArray();
                    arrayLength.CheckLength();
                    break;

                    case 2:
                    MaxAndMin MaxAndMin = new MaxAndMin();
                    MaxAndMin.MaxAndMinArray();
                    break;

                    case 3:
                    NegativeNumber PrintNegative = new NegativeNumber();
                    PrintNegative.CheckNegative();
                    break;

                    case 4:
                    SumOfElement CheckSum = new SumOfElement();
                    CheckSum.PrintSum();
                    break;

                    case 5:
                    CountElement EachElement = new CountElement();
                    EachElement.Count();
                    break;


            }
            Console.ReadLine();
        }
    }
}