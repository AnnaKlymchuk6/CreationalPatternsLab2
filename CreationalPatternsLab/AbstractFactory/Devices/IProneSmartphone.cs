using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalPatternsLab.AbstractFactory.Interfaces;

namespace CreationalPatternsLab.AbstractFactory.Devices
{
	public class IProneSmartphone : ISmartphone
	{
		public void ShowInfo()
		{
			Console.WriteLine("Smartphone бренду IProne");
		}
	}
}
