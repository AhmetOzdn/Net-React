using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_React_Odev
{
    public class CheckingAccount : BankAccount<string>
    {
        public override string CalculateInterest()
        {
            return "Checking accounts do not earn interest.";
        }
    }
}
