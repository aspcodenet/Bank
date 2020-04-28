using System;
using System.Linq;
using BankServices;

namespace MoneyLaundringChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new SuperCalculator();
            int r = calc.Add(12, 13);
            Console.WriteLine("Hello World!");
        }
    }
}
