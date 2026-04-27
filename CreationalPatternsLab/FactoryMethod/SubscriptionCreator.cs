using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsLab.FactoryMethod
{
	public abstract class SubscriptionCreator
	{
		public abstract Subscription CreateSubscription();
	}
}
