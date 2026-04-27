using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsLab.Singleton
{
	public class Authenticator
	{
		private static Authenticator instance;

		private Authenticator()
		{
		}

		public static Authenticator GetInstance()
		{
			if (instance == null)
			{
				instance = new Authenticator();
			}

			return instance;
		}

		public void Login(string user)
		{
			Console.WriteLine("Користувач " + user + " увійшов в систему.");
		}
	}
}
