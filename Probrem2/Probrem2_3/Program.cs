using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem2_3
{
    class Program
    {
        static void Square(int h, int w)
        {
            // どちらかが0以下の時は何も表示しない
            if(h <= 0 || w <= 0) { return; }

            for (int i = 0; i < h; i++){
                for (int j = 0; j < w; j++){
                    Console.Write("■ ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Random r = new Random();
            int h = r.Next(1, 11);
            int w = r.Next(1, 11);
            Console.WriteLine("たて：" + h);
            Console.WriteLine("よこ：" + w);
            Console.WriteLine();

            Square(h, w);
        }
    }
}
