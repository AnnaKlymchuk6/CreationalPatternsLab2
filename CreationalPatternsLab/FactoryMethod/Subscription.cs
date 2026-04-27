using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsLab.FactoryMethod
{
	public abstract class Subscription
	{
		public double MonthlyFee { get; set; }
		public int MinPeriod { get; set; }
		public string[] Channels { get; set; }

		public virtual void ShowInfo()
		{
			Console.WriteLine("Щомісячна плата: " + MonthlyFee);
			Console.WriteLine("Мінімальний період підписки: " + MinPeriod + " місяців");
			Console.WriteLine("Канали: " + string.Join(", ", Channels));
		}
	}
}
