using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();

            Random r = new Random();
            int r_min = 0;
            int r_max = 10;

            int num;
            while (true){
                num = r.Next(r_min, r_max + 1);
                Console.Write("0〜10の値を出力:" + num);
                Console.WriteLine();

                if (num == 0) { break; }

                data.Add(num);
            }
            Console.WriteLine();

            // 2の入った要素を削除
            for (int i = 0; i < data.Count; i++){
                if(data[i] == 2){
                    data.Remove(2);
                    i--;
                }
            }

            foreach (int d in data){
                Console.Write(d + " ");
            }
            Console.WriteLine();
        }
    }
}
