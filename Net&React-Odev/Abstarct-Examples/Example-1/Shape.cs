using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Net_React_Odev.Abstarct_Examples.Example_1
{
    public abstract class Shape
    {
        public string Color { get; set; }

        public abstract void Draw();

        public void DisplayInfo()
        {
            Console.WriteLine($"This is a {Color} shape.");
        }
    }
}
