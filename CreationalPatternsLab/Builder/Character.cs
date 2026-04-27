using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsLab.Builder
{
	public class Character
	{
		public int Height;
		public string Body;
		public string HairColor;
		public string EyeColor;
		public string Clothes;
		public string Ability;

		public List<string> Inventory = new List<string>();
		public List<string> GoodDeeds = new List<string>();
		public List<string> EvilDeeds = new List<string>();

		public void Show()
		{
			Console.WriteLine("Зріст: " + Height);
			Console.WriteLine("Статура: " + Body);
			Console.WriteLine("Колір волосся: " + HairColor);
			Console.WriteLine("Колір очей: " + EyeColor);
			Console.WriteLine("Одяг: " + Clothes);
			Console.WriteLine("Здібність: " + Ability);

			Console.WriteLine("Інвентар: " + string.Join(", ", Inventory));

			if (GoodDeeds.Count > 0)
				Console.WriteLine("Добрі справи: " + string.Join(", ", GoodDeeds));

			if (EvilDeeds.Count > 0)
				Console.WriteLine("Злі справи: " + string.Join(", ", EvilDeeds));
		}
	}
}