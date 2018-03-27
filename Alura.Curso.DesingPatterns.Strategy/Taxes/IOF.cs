using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.Curso.DesingPatterns.Strategy.Taxes
{
	public class IOF : Tax
    {
	    public override double Calculate(Budget budget)
	    {
		    return budget.Value * 0.18;
	    }
    }
}
