using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_React_Odev.Interface_Examples.Example_2
{
    public class BitcoinPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Bitcoin payment processed for {amount} Turkish Lira.");
        }
    }
}
