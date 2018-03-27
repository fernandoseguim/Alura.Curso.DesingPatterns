using System;
using Alura.Curso.DesingPatterns.Strategy.Taxes;

namespace Alura.Curso.DesingPatterns.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator.Calculate(new Budget(100), new ICMS());
	        TaxCalculator.Calculate(new Budget(100), new ISS());
	        TaxCalculator.Calculate(new Budget(100), new IOF());
			Console.ReadKey();
        }
    }
}
