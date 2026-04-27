using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalPatternsLab.AbstractFactory.Interfaces;

namespace CreationalPatternsLab.AbstractFactory.Devices
{
	public class IProneLaptop : ILaptop
	{
		public void ShowInfo()
		{
			Console.WriteLine("Laptop бренду IProne");
		}
	}
}
