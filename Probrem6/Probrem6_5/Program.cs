using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> l_str = new List<string>();

            string str = "";
            while (true){
                Console.Write("文字列を入力:");
                str = Console.ReadLine();

                if (str == "") { break; }
                l_str.Add(str);
            }
            Console.WriteLine();

            // 5文字以上の文字列削除
            for (int i = 0; i < l_str.Count; i++){
                if(l_str[i].Length > 4){
                    l_str.Remove(l_str[i]);
                    i--; // インデックスが詰められるので、次も同じインデックスを通るように
                }
            }

            foreach (string s in l_str){
                Console.Write(s + " ");
            }
        }
    }
}
