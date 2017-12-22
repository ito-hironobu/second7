using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> animals = new Dictionary<string, string>();
            animals["cat"] = "猫";
            animals["dog"] = "犬";
            animals["bird"] = "鳥";
            animals["tiger"] = "トラ";

            Console.Write("英語で動物の名前を入力してください：");
            string a = Console.ReadLine();
            Console.WriteLine();

            bool flag = false;
            foreach(string key in animals.Keys){
                if(key == a){
                    flag = true;
                    break;
                }
            }

            if(flag){
                Console.WriteLine("「{0}」です", animals[a]);
            }else{
                Console.WriteLine("対応するデータは登録されていません。");
            }
        }
    }
}
