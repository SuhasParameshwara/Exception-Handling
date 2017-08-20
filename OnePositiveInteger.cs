using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnePositiveInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number: \n");
                byte num = byte.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("\nInvalid Number!");
            }
            finally{
                Console.WriteLine("\nGood Bye!");
            }
            Console.ReadLine();
        }
    }
}
