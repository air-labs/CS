using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S02
{
    public class EMail
    {
        public string Sender;
        public string Receiver;
        public string Caption;

        public EMail() { }

        public EMail(string sender, string receiver, string caption)
        {
            this.Sender = sender;
            this.Receiver = receiver;
            this.Caption = caption;
        }

    }

    public class Program
    {
        public static void MainX()
        {
            var mail1 = new EMail();
            var mail2 = new EMail("smith@gmail.com", "jones@gmail.com", "Test");
        }
    }


}
