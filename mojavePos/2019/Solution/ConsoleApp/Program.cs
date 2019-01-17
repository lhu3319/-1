using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Test.Test test = new Test.Test();
            int result = test.Add(4, 5);
            Console.WriteLine("4 * 5 = {0}", result);
        }
    }
}
