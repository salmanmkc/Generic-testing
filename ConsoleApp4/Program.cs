using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate an instance of the Generic class
            Generic gen = new Generic();

            //test with int, string, bool
            gen.output<int>(12);
            gen.output<string>("HELLO");
            gen.output<bool>(false);

            // prevent auto-close
            Console.Read();
        }

        
    }

    class Generic
    {
        public void output<T>(T value)
        {
            Console.WriteLine($"{value} is type {typeof(T).Name}");
        }
    }
}
