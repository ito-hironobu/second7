using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            Random r = new Random();
            int r_min = 0;
            int r_max = 10;

            int k;
            while(true){
                k = r.Next(r_min, r_max + 1);
                Console.Write("0〜10の値を出力:" + k);
                Console.WriteLine();
                if (k == 0) { break; }

                if(k % 2 == 0){
                    even.Add(k);
                }else{
                    odd.Add(k);
                }
            }
            Console.WriteLine();

            Console.Write("偶数：");
            foreach(int i in even){
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.Write("奇数：");
            for (int i = 0; i < odd.Count; i++){
                Console.Write(odd[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
