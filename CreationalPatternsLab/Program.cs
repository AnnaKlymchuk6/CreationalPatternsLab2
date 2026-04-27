using CreationalPatternsLab.AbstractFactory.Factories;
using CreationalPatternsLab.AbstractFactory.Interfaces;
using CreationalPatternsLab.Builder;
using CreationalPatternsLab.FactoryMethod;
using CreationalPatternsLab.Prototype;
using CreationalPatternsLab.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsLab
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("=== Фабричний метод ===");
			SubscriptionCreator creator;

			creator = new WebSite();
			Subscription sub1 = creator.CreateSubscription();
			sub1.ShowInfo();

			Console.WriteLine();

			creator = new MobileApp();
			Subscription sub2 = creator.CreateSubscription();
			sub2.ShowInfo();

			Console.WriteLine();

			creator = new ManagerCall();
			Subscription sub3 = creator.CreateSubscription();
			sub3.ShowInfo();


			Console.WriteLine("=== Абстрактна фабрика ===");

			IDeviceFactory factory = new IProneFactory();

			ILaptop laptop = factory.CreateLaptop();
			INetbook netbook = factory.CreateNetbook();
			IEBook ebook = factory.CreateEBook();
			ISmartphone phone = factory.CreateSmartphone();

			laptop.ShowInfo();
			netbook.ShowInfo();
			ebook.ShowInfo();
			phone.ShowInfo();


			Console.WriteLine("=== Одинак ===");

			Authenticator auth1 = Authenticator.GetInstance();
			Authenticator auth2 = Authenticator.GetInstance();

			auth1.Login("Anna");

			if (auth1 == auth2)
			{
				Console.WriteLine("Це один і той самий екземпляр.");
			}


			Console.WriteLine("===  Прототип ===");

			Virus parent = new Virus("Alpha", "Root", 1.2, 1);

			Virus child1 = new Virus("Beta", "Mutation", 0.8, 1);
			Virus child2 = new Virus("Gamma", "Mutation", 0.7, 1);

			Virus grandChild = new Virus("Delta", "Mutation", 0.4, 1);

			child1.Children = new Virus[] { grandChild };

			parent.Children = new Virus[] { child1, child2 };

			Console.WriteLine("Оригінальне сімейство:");
			parent.Show();

			Virus clone = parent.Clone();

			Console.WriteLine("\nКлоноване сімейство:");
			clone.Show();


			Console.WriteLine("=== Будівельник ===");
			CharacterDirector director = new CharacterDirector();

			Character hero = director.CreateHero();
			Console.WriteLine("Герой:");
			hero.Show();

			Console.WriteLine();

			Character enemy = director.CreateEnemy();
			Console.WriteLine("Ворог:");
			enemy.Show();
		}
	}
}
