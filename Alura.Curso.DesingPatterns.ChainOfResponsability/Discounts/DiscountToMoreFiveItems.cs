using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.Curso.DesingPatterns.ChainOfResponsability.Discounts
{
    public class DiscountToMoreFiveItems : IDiscount
    {
	    public IDiscount Next { get; private set; }

	    public double Discount(Budget budget)
	    {
		    if (budget.Items.Count > 5)
		    {
			    return budget.Value * 0.7;
		    }

		    return this.Next.Discount(budget);
	    }

	    public void SetNextDiscount(IDiscount discount)
	    {
		    this.Next = discount;
	    }
	}
}
