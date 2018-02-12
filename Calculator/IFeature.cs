using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface IFeature
    {
       void Decrease(int a, int b, int c);
       int Sum(int a, int b);
    }
}
