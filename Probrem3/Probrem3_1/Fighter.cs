using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem3_1
{
    public class Fighter : Airplane
    {
        // Fighterクラスのメソッドfoo()メソッドflyによる処理ならば
        /*
        public override void Fly()
        {
            Console.WriteLine("飛行する");
        }
        */

        public void Fight()
        {
            Console.WriteLine("戦闘する");
        }
    }
}
