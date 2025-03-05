using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_React_Odev.Interface_Examples.Example_2
{
    public interface IPayment
    {
        void ProcessPayment(decimal amount);
    }
}
