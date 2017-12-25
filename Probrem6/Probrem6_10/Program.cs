using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem6_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // SortedSet使えば一発では？
            HashSet<int> hs = new HashSet<int>();

            Random r = new Random();
            int r_min = 1;
            int r_max = 10;

            int num;
            Console.Write("乱数:");
            for (int i = 0; i < 10; i++){
                num = r.Next(r_min, r_max + 1);
                Console.Write(num + " ");
                hs.Add(num);
            }
            Console.WriteLine();

            Console.Write("出現した数:");
            for (int n = 1; n <= 10; n++){
                foreach(int i in hs){
                    if(i == n){
                        Console.Write(i + " ");
                        break;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
