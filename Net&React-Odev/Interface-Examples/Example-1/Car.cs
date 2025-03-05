using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_React_Odev.Interface_Examples.Example_1
{
    internal class Car: IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car is starting.");
        }
        public void Stop()
        {
            Console.WriteLine("Car is stopping.");
        }
        public void Accelerate()
        {
            Console.WriteLine("Car is accelerating.");
        }
        public void Brake()
        {
            Console.WriteLine("Car is braking.");
        }
    }
}
