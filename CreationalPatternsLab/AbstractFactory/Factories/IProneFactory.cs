using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalPatternsLab.AbstractFactory.Devices;
using CreationalPatternsLab.AbstractFactory.Interfaces;

namespace CreationalPatternsLab.AbstractFactory.Factories
{
	public class IProneFactory : IDeviceFactory
	{
		public ILaptop CreateLaptop()
		{
			return new IProneLaptop();
		}

		public INetbook CreateNetbook()
		{
			return new IProneNetbook();
		}

		public IEBook CreateEBook()
		{
			return new IProneEBook();
		}

		public ISmartphone CreateSmartphone()
		{
			return new IProneSmartphone();
		}
	}
}
