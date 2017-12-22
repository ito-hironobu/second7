using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> l_str = new List<string>();

            string str = "";
            while(true){
                Console.Write("文字列を入力:");
                str = Console.ReadLine();

                if(str == "") { break; }
                l_str.Add(str);
            }
            Console.WriteLine();

            foreach(string s in l_str){
                Console.Write(s + " ");
            }
        }
    }
}
