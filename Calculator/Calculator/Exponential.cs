using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Exponential : Mathmatics
    {
        public void doExponential(double number1, double number2)
        {
            this.number1 = number1;
            this.number1 = number2;
            solution = Math.Pow(number1, number2);
            Console.WriteLine(solution);
        }
    }
}
