using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            

            string opt="";
            while (true)
            {
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Check battery");
                Console.WriteLine("3.Decrease");
                Console.WriteLine("4.Play music");
                Console.WriteLine("5.Press 5 to exit");


                opt = Console.ReadLine();

                if(opt=="1")
                {
                    Console.WriteLine("Enter the first number: ");
                    c.A = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second number: ");
                    c.B = Int32.Parse(Console.ReadLine());
                    c.Sum(c.A,c.B);
                    continue;
                }
                if(opt=="2")
                {
                    c.CheckBattery();
                    continue;
                }

                if (opt == "3")
                {
                    Console.WriteLine("Enter first number");
                    c.A = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("secons number");
                    c.B = Int32.Parse(Console.ReadLine());
                    c.Decrease(c.A, c.B);
                    //c.Decrease(3, 4);
                    continue;
                }
                if (opt == "4")
                {
                    c.PlayMusic();
                    continue;
                }
                if (opt == "5")
                {
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
