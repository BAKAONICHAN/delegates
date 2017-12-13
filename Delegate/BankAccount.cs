using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Delegates
{
    public  delegate void AccountHandler (string message);
    public class BankAccount
    {
        private AccountHandler handler;
        public double Sum { get; private set; }
        public void RegisterHandler(AccountHandler handler)
        {
            Delegate newHandler = Delegate.Combine(handler, this.handler);
            this.handler = newHandler as AccountHandler;
           // this.handler += handler;
        }
        public void UnregisterHandker(AccountHandler handler)
        {
            this.handler = null;
        }
        public void Add(double sum)
        {
           
            if(handler!=null)
            {
                Sum += Sum;
                handler.Invoke("вы внесли " + sum);
            }
                
        }
        public void Withdrow(double sum)
        {
            if(sum<=Sum)
            {
                Sum -= sum;
                if (handler != null)
                {
                    
                    handler.Invoke("вы сняли со счета " + sum);
                }
                else
                {
                    if(handler != null)
                    {
                        handler.Invoke("Недостаточно средств ");
                    }
                }
            }
        }
        
    }
}
