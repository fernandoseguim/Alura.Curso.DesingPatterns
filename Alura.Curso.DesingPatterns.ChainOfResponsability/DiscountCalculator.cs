using System;
using System.Collections.Generic;
using System.Text;
using Alura.Curso.DesingPatterns.ChainOfResponsability.Discounts;

namespace Alura.Curso.DesingPatterns.ChainOfResponsability
{
	public static class DiscountCalculator
    {
	    public static double Calculate(Budget budget)
	    {

			IDiscount discountToMoreFiveItems = new DiscountToMoreFiveItems();
		    IDiscount discountToValueMoreFiveHundredReais = new DiscountToValueMoreFiveHundredReais();
		    IDiscount discountDefault = new DiscountDefault();

			discountToMoreFiveItems.SetNextDiscount(discountToValueMoreFiveHundredReais);
			discountToValueMoreFiveHundredReais.SetNextDiscount(discountDefault);

			return discountToMoreFiveItems.Discount(budget);
	    }
    }
}
