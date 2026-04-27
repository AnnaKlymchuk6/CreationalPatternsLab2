using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalPatternsLab.AbstractFactory.Devices;
using CreationalPatternsLab.AbstractFactory.Interfaces;

namespace CreationalPatternsLab.AbstractFactory.Factories
{
	public class BalaxyFactory : IDeviceFactory
	{
		public ILaptop CreateLaptop()
		{
			return new BalaxyLaptop();
		}

		public INetbook CreateNetbook()
		{
			return new BalaxyNetbook();
		}

		public IEBook CreateEBook()
		{
			return new BalaxyEBook();
		}

		public ISmartphone CreateSmartphone()
		{
			return new BalaxySmartphone();
		}
	}
}
