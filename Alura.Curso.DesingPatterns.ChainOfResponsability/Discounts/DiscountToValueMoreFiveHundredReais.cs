using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.Curso.DesingPatterns.ChainOfResponsability.Discounts
{
	public class DiscountToValueMoreFiveHundredReais : IDiscount
    {
		
		public IDiscount Next { get; private set; }

	    public double Discount(Budget budget)
	    {
		    if (budget.Value >= 500)
		    {
			    return budget.Value * 0.50;
		    }

		    return this.Next.Discount(budget);
	    }

	    public void SetNextDiscount(IDiscount discount)
	    {
		    this.Next = discount;
	    }
    }
}
