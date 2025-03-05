using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_React_Odev
{
    public class Developer:Employee<int>
    {
        public string About { get; set; }

        public override double CalculateBonus()
        {
            return Salary += (Salary * 0.1);
        }
    }
}
