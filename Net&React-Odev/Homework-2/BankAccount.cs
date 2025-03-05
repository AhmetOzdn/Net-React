using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_React_Odev
{
    public abstract class BankAccount<T>
    {
        public string AccountHolder { get; set; }
        public float Balance { get; set; }

        public abstract T CalculateInterest();
    }
}
