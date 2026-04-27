using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsLab.FactoryMethod
{
	public class WebSite : SubscriptionCreator
	{
		public override Subscription CreateSubscription()
		{
			Console.WriteLine("Підписка придбана через вебсайт.");
			return new DomesticSubscription();
		}
	}
}
