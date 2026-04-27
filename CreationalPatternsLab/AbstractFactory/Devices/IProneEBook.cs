using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalPatternsLab.AbstractFactory.Interfaces;

namespace CreationalPatternsLab.AbstractFactory.Devices
{
	public class IProneEBook : IEBook
	{
		public void ShowInfo()
		{
			Console.WriteLine("EBook бренду IProne");
		}
	}
}
