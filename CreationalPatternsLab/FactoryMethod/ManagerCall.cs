using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsLab.FactoryMethod
{
	public class ManagerCall : SubscriptionCreator
	{
		public override Subscription CreateSubscription()
		{
			Console.WriteLine("Підписка оформлена через дзвінок менеджеру.");
			return new PremiumSubscription();
		}
	}
}
