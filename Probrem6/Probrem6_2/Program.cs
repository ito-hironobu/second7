using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();

            Random r = new Random();
            int r_min = 0;
            int r_max = 10;

            int k;
            while (true)
            {
                k = r.Next(r_min, r_max + 1);
                Console.Write("0〜10の値を出力:" + k);
                Console.WriteLine();

                if (k == 0) { break; }

                data.Add(k);
            }
            Console.WriteLine();

            data.Reverse();
            foreach(int d in data){
                Console.Write(d + " ");
            }
            Console.WriteLine();
        }
    }
}
