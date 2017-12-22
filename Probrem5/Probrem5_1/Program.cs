using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CellPhone cp = new CellPhone();
            FuncPhone(cp);
            FuncMailer(cp);
            FuncComputer(cp);
        }

        public static void FuncPhone(IPhone phone)
        {
            phone.CallPhone();
            phone.ReceivePhone();
        }

        public static void FuncMailer(IMailer mailer)
        {
            mailer.SendMail();
            mailer.ReceiveMail();
        }

        public static void FuncComputer(IComputer computer)
        {
            computer.PlayGame();
            computer.BrowseWeb();
        }
    }
}
