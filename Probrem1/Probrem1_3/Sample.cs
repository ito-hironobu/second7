using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem1_3
{
    public class Sample
    {
        public Sample()
        {
            Console.WriteLine("スタート");
        }

        public void func()
        {
            Console.WriteLine("func");
        }

        ~Sample()
        {
            Console.WriteLine("エンド");
        }
    }
}
