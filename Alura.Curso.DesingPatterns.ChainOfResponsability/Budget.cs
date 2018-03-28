using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.Curso.DesingPatterns.ChainOfResponsability
{
	public class Budget
    {
		public Budget(double value)
		{
			this.Value = value;
			this.Items = new List<Item>();
		}

		public double Value { get; }
	    public IList<Item> Items { get; }

	    public void AddItem(Item item)
	    {
		    this.Items.Add(item);
	    }
    }
}
