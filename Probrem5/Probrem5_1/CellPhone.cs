using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem5_1
{
    public class CellPhone : IPhone, IMailer, IComputer
    {
        public void CallPhone()
        {
            Console.WriteLine("電話を掛ける");
        }

        public void ReceivePhone()
        {
            Console.WriteLine("電話を受ける");
        }

        public void SendMail()
        {
            Console.WriteLine("メールを送る");
        }

        public void ReceiveMail()
        {
            Console.WriteLine("メールを受診する");
        }

        public void PlayGame()
        {
            Console.WriteLine("ゲームをする");
        }

        public void BrowseWeb()
        {
            Console.WriteLine("ウェブを閲覧する");
        }
    }
}
