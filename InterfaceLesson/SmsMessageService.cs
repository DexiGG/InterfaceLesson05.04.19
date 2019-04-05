using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLesson
{
    public class SmsMessageService : ISender
    {
        public string Message { get; set; }

        public void SendMessage(string number, string message)
        {
            Console.WriteLine("Отправка сообщения завершена");
        }
    }
}
