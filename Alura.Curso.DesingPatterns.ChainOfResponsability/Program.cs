using System;
using System.Collections.Generic;

namespace Alura.Curso.DesingPatterns.ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {

	        var budgetA = new Budget(100);
			budgetA.AddItem(new Item("Mouse", 50.00));
	        budgetA.AddItem(new Item("Mouse", 50.00));
			budgetA.AddItem(new Item("Teclado", 150.00));
	        budgetA.AddItem(new Item("Teclado", 150.00));
	        budgetA.AddItem(new Item("Teclado", 150.00));
	        budgetA.AddItem(new Item("Teclado", 150.00));

	        var budgetB = new Budget(500);
	        budgetB.AddItem(new Item("Mouse", 50.00));

			var discountA = DiscountCalculator.Calculate(budgetA);
	        var discountB = DiscountCalculator.Calculate(budgetB);

			Console.WriteLine($"Disconto A: {discountA}");
	        Console.WriteLine($"Disconto B: {discountB}");
			Console.ReadKey();
        }
    }
}
