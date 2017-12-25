using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem7_1
{
    class Program
    {
        delegate void DelFunc();

        static void Func1()
        {
            Console.WriteLine("Func1");
        }

        static void Func2()
        {
            Console.WriteLine("Func2");
        }

        static void Main(string[] args)
        {
            DelFunc df = new DelFunc(Func2);
            df();
        }
    }
}
