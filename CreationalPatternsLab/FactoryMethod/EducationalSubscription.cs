using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsLab.FactoryMethod
{
	public class EducationalSubscription : Subscription
	{
		public EducationalSubscription()
		{
			MonthlyFee = 5;
			MinPeriod = 6;
			Channels = new string[] { "Discovery", "History", "National Geographic" };
		}
	}
}
