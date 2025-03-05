using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_React_Odev.Interface_Examples.Example_2
{
    public class CreditCardPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Credit Card payment processed for {amount} Turkish Lira.");
        }
    }
}
