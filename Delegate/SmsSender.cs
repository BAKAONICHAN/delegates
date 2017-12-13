using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Delegates
{
    public class SmsSender
    {
        public static void SendMessage(string message)
        {
         WriteLine(message);
            ReadLine();
        }
    }
}
