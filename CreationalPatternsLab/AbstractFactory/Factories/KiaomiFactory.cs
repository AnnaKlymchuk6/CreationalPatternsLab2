using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalPatternsLab.AbstractFactory.Devices;
using CreationalPatternsLab.AbstractFactory.Interfaces;

namespace CreationalPatternsLab.AbstractFactory.Factories
{
	public class KiaomiFactory : IDeviceFactory
	{
		public ILaptop CreateLaptop()
		{
			return new KiaomiLaptop();
		}

		public INetbook CreateNetbook()
		{
			return new KiaomiNetbook();
		}

		public IEBook CreateEBook()
		{
			return new KiaomiEBook();
		}

		public ISmartphone CreateSmartphone()
		{
			return new KiaomiSmartphone();
		}
	}
}