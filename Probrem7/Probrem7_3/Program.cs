using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 1, 2 };
            try{
                for (int i = 0; i < 4; i++){
                    Console.WriteLine("a[" + i + "]=" + a[i]);
                }
            }catch(IndexOutOfRangeException e){
                Console.WriteLine("配列の範囲を越えています。");
            }
        }
    }
}
