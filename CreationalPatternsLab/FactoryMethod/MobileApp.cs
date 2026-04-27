using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsLab.FactoryMethod
{
	public class MobileApp : SubscriptionCreator
	{
		public override Subscription CreateSubscription()
		{
			Console.WriteLine("Підписка придбана через мобільний застосунок.");
			return new EducationalSubscription();
		}
	}
}
