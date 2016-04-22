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
            mainMenu main = new mainMenu();
            main.menu();
            main.otherMainMenu();
            Console.ReadLine();
        }
    }
}
