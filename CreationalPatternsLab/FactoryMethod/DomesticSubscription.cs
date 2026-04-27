using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsLab.FactoryMethod
{
	public class DomesticSubscription : Subscription
	{
		public DomesticSubscription()
		{
			MonthlyFee = 10;
			MinPeriod = 3;
			Channels = new string[] { "Новини", "Фільми", "Дитячі" };
		}
	}
}
