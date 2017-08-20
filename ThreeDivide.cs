using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeDivide
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the numbers to divide: \n");
                int FirstNum = int.Parse(Console.ReadLine());
                int SecondNum = int.Parse(Console.ReadLine());
                Console.WriteLine("\nThe ans is {0}", FirstNum / SecondNum);
            }
            catch(Exception e)
            {
                Console.WriteLine("\nSorry number cannot be divide by zero!");
            }
            Console.ReadLine();
        }
    }
}
