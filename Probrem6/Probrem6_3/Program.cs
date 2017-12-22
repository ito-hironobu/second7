using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList[] data = new ArrayList[10];
            for (int i = 0; i < 10; i++){
                data[i] = new ArrayList();
            }

            /* Listパターン
            List<int>[] data = new List<int>[10];
            for (int i = 0; i < 10; i++){
                data[i] = new List<int>();
            }
            */

            Random r = new Random();
            int r_min = 0;
            int r_max = 100;

            int num;
            int t;
            while (true){
                num = r.Next(r_min, r_max + 1);
                Console.Write("0〜10の値を出力:" + num);
                Console.WriteLine();

                if (num == 0) { break; }

                t = num % 10;
                data[t].Add(num);
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++){
                Console.Write("一の位が{0}：", i);

                if(data[i].Count == 0){
                    Console.WriteLine("なし");
                    continue;
                }

                foreach (int d in data[i]){
                    Console.Write(d + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
