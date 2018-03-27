using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.Curso.DesingPatterns.Strategy.Taxes
{
    public abstract class Tax
    {
	    public abstract double Calculate(Budget budget);
    }
}
