using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.Curso.DesingPatterns.ChainOfResponsability.Discounts
{
	public class DiscountDefault : IDiscount
    {
	    public IDiscount Next { get; private set; }
	    public double Discount(Budget budget)
	    {
		    return default(double);
	    }

	    public void SetNextDiscount(IDiscount discount)
	    {
		    this.Next = discount;
	    }
    }
}
