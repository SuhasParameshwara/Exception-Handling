using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNull
{
    class Demo
    {
        public string name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Demo obj = null;
                Console.WriteLine(obj.name);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
