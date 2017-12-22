using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // hashmapってJAVAの話？ //

            Dictionary<char, string> integer = new Dictionary<char, string>();
            integer['0'] = "〇";
            integer['1'] = "一";
            integer['2'] = "二";
            integer['3'] = "三";
            integer['4'] = "四";
            integer['5'] = "五";
            integer['6'] = "六";
            integer['7'] = "七";
            integer['8'] = "八";
            integer['9'] = "九";

            Console.Write("整数の値を入力してください:");
            string num_str = Console.ReadLine();
            Console.WriteLine();

            List<string> n_str = new List<string>();
            int num;
            bool flag = int.TryParse(num_str, out num);
            num_str = num.ToString(); // 0が先頭に入力された時のために、文字列→数値→文字列とした

            if(flag){
                // 数値を漢数字に変換
                foreach(char n in num_str){
                    n_str.Add(integer[n]);
                }

                // カンマ挿入
                for (int i = n_str.Count - 3; i > 0; i -= 3){
                    n_str.Insert(i, ",");
                }

                Console.Write("変換結果:");
                foreach(string s in n_str){
                    Console.Write(s);
                }
                Console.WriteLine();
            }else{
                Console.WriteLine("整数の値を入力してください。");
            }
        }
    }
}
