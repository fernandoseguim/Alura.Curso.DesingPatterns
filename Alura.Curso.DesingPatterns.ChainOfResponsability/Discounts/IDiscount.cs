using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.Curso.DesingPatterns.ChainOfResponsability.Discounts
{
    public interface IDiscount
    {
		IDiscount Next { get; }
	    double Discount(Budget budget);
	    void SetNextDiscount(IDiscount discount);
    }
}
