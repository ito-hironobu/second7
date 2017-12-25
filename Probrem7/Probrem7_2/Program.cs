using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem7_2
{
    delegate void DelegateFunc(int num);

    class ShowCharas
    {
        public void ShowStars(int num)
        {
            for (int i = 0; i < num; i++){
                Console.Write("☆ ");
            }
            Console.WriteLine();
        }

        public void ShowBoxes(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write("■ ");
            }
            Console.WriteLine();
        }

        public void ShowPlus(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write("+ ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ShowCharas s = new ShowCharas();
            DelegateFunc f = new DelegateFunc(s.ShowStars);
            f += new DelegateFunc(s.ShowBoxes);
            f += new DelegateFunc(s.ShowPlus);
            f(4);
        }
    }
}
