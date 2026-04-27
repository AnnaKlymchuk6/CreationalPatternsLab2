using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsLab.Prototype
{
	public class Virus
	{
		public double Weight;
		public int Age;
		public string Name;
		public string Type;
		public Virus[] Children;

		public Virus(string name, string type, double weight, int age)
		{
			Name = name;
			Type = type;
			Weight = weight;
			Age = age;
			Children = new Virus[0];
		}

		public Virus Clone()
		{
			Virus copy = new Virus(Name, Type, Weight, Age);

			if (Children.Length > 0)
			{
				copy.Children = new Virus[Children.Length];

				for (int i = 0; i < Children.Length; i++)
				{
					copy.Children[i] = Children[i].Clone();
				}
			}

			return copy;
		}

		public void Show(string indent = "")
		{
			Console.WriteLine(indent + Name + " (" + Type + ")");

			foreach (var child in Children)
			{
				child.Show(indent + "   ");
			}
		}
	}
}
