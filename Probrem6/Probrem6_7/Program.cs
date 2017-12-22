using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem6_7
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
            int index;
            while (true)
            {
                num = r.Next(r_min, r_max + 1);
                Console.Write("0〜10の値を出力:" + num);
                Console.WriteLine();
                Console.WriteLine();

                if (num == 0) { break; }

                Console.Write("出力された数：");

                index = 0;
                for (int i = 0; i < data.Count; i++){
                    // 出力された数を何番目に挿入するか算出
                    if(data[i] >= num){
                        index = i;
                        break;
                    }
                    if(i == data.Count - 1){
                        index = i + 1;
                    }
                }

                data.Insert(index, num);

                foreach(int i in data){
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
