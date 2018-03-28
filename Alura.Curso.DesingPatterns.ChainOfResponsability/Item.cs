namespace Alura.Curso.DesingPatterns.ChainOfResponsability
{
	public class Item
	{
		public Item(string name, double value)
		{
			this.Name = name;
			this.Value = value;
		}

		public string Name { get; }
		public double Value { get; }
	}
}