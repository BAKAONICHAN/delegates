using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            int primarySum = 200;
            BankAccount account = new BankAccount();
            account.RegisterHandler(new AccountHandler(SmsSender.SendMessage));
            account.RegisterHandler(new AccountHandler(SendConsoleMessage));
            account.Add(primarySum);
            account.Withdrow(500);
            account.RegisterHandler
                (
                delegate (String mes)
                {                   
                    WriteLine(mes);
                }
                );
            account.RegisterHandler(message => WriteLine(message));
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.OrderBy(account1=>account1.Sum);
            accounts.ForEach(account1=>WriteLine(account1.Sum));
            accounts.FirstOrDefault(account1=>account1.Sum>0);
            accounts.Where(account1 => account1.Sum > 0);
            //ReadLine();

        }
        private static void SendConsoleMessage(string text)
        {
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine(text);
            ReadLine();
            ResetColor();
        }
    }
}




