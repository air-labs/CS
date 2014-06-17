using System;


namespace S03_S04
{
    partial class EMail
    {
        public string Caption;
    }

    public class Program
    {
        public static void MainX()
        {
            var mail = new EMail();
            mail.Caption = "Test";
            mail.Sender = "Smith@gmail.com";
        }
    }
}