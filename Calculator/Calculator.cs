using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public Calculator()
        {
            this.battery = 7;
            //Console.WriteLine("Hi from calc");
        }

        private int battery;
        public int Battery
        {
            get
            {
                return battery;
            }
            set
            {
                battery = value;
            }
        }

       
        public int A { get; set; }
        public int B { get; set; }

       
    }
}
