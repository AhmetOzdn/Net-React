using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_React_Odev
{
    public class SavingsAccount:BankAccount<float>
    {
        public override float CalculateInterest()
        {
            return Balance * 0.05f;
        }
    }
}
