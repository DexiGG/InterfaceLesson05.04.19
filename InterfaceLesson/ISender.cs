using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLesson
{
    public interface ISender
    {
        string Message { get; set; }
        //Свойства и методы
        void SendMessage(string to, string text);

    }
}
