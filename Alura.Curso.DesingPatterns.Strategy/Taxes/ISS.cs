using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.Curso.DesingPatterns.Strategy.Taxes
{
    class ISS : Tax
    {
	    public override double Calculate(Budget budget)
	    {
		    return budget.Value * 0.06;
	    }
    }
}
