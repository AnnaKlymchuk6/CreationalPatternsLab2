using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsLab.FactoryMethod
{
	public class PremiumSubscription : Subscription
	{
		public PremiumSubscription()
		{
			MonthlyFee = 20;
			MinPeriod = 1;
			Channels = new string[] { "HBO", "Netflix", "Спорт", "Фільми" };
		}
	}
}
