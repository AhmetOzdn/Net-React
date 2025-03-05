using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_React_Odev.Interface_Examples.Example_1
{
    public class MotorCycle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("MotorCycle is starting.");
        }

        public void Stop()
        {
            Console.WriteLine("MotorCycle is stopping.");
        }

        public void Update()
        {
            Console.WriteLine("MotorCycle is updating.");
        }

        void IVehicle.Accelerate()
        {
            Console.WriteLine("MotorCycle is accelerating.");
        }

        void IVehicle.Brake()
        {
            Console.WriteLine("MotorCycle is braking.");
        }
    }
}
