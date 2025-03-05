using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_React_Odev
{
    public class Employee<TId>
    {
        public TId Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public virtual double CalculateBonus()
        {
            return Salary += (Salary * 0.05);
        }

    }
}
