using System;


namespace S01
{
    public class EMail
    {
        public string Sender;
        public string Receiver;
        public string Caption;

        public void Send()
        {
            //отправляем сообщение
        }

        public bool Validate(bool strict)
        {
            return 
                Sender != null && 
                Receiver != null && 
                (Caption != null || !strict);
        }

        //Общий префикс для ответов - не зависит от конкретного сообщения
        public static string ForwardPrefix = "FW: ";
        public static string ReplyPrefix = "RE: ";

        public EMail Forward(string whom)
        {
            var message = new EMail();
            message.Caption = ForwardPrefix + Caption;
            message.Sender = Sender;
            message.Receiver = whom;
            return message;
        }

        public EMail Reply()
        {
            return new EMail
            {
                Sender = Receiver,
                Receiver = Sender,
                Caption = ReplyPrefix + Caption
            };
        }
                
        //Правильность адреса не зависит от конкретного письма
        public static bool IsValidEMailAddress(string address)
        {
            return address.Contains("@");
        }

        public static EMail ReadFromFile(string fileName)
        {
            var mail = new EMail();
            //открываем файл и читаем оттуда содержимое письма
            return mail;
        }
    }

    public class Program
    {


        public static void MainЧ()
        {


            var email = new EMail() { Sender = "Smith@gmail.com", Receiver = "Jones@gmail.com" };
            email.Caption = "Happy Birthday!";
            Console.WriteLine(email.Caption);

            EMail.ReplyPrefix = "[RE]";
            Console.WriteLine(EMail.ReplyPrefix);

            var newEmail = email.Reply();
            Console.WriteLine(newEmail.Caption);

        }

    }
}