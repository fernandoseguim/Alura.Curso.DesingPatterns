using System;
using System.Collections.Generic;
using System.Text;
using Alura.Curso.DesingPatterns.Strategy.Taxes;

namespace Alura.Curso.DesingPatterns.Strategy
{
	public static class TaxCalculator
    {

	    public static void Calculate(Budget budget, Tax tax)
	    {
		    var value = tax.Calculate(budget);
			Console.WriteLine(value);
	    }
    }
}
