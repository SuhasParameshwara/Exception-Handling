using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourStack
{
    class Program
    {
        static void excep(int value)
        {
            Console.WriteLine(value);
            excep(++value);
        }
        static void Main(string[] args)
        {
            try
            {
                excep(0);
            }
            catch(StackOverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
