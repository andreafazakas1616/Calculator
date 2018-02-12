using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorRepository : IFeature
    {
        Calculator c = new Calculator();
       
        public void Decrease(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                
            }
            Console.WriteLine($"Return : {a-b}");
        }

        public int Sum(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
