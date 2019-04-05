using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            ISender service = GetSender();
            service.SendMessage("+77777777777", "Смени номер, придурок");
        }
        static ISender GetSender()
        {
            return new SmsMessageService();
        }
    }
}

