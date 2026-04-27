using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsLab.Builder
{
	public class HeroBuilder : ICharacterBuilder
	{
		private Character hero = new Character();

		public HeroBuilder SetHeight(int height)
		{
			hero.Height = height;
			return this;
		}

		public HeroBuilder SetBody(string body)
		{
			hero.Body = body;
			return this;
		}

		public HeroBuilder SetHair(string hair)
		{
			hero.HairColor = hair;
			return this;
		}

		public HeroBuilder SetEyes(string eyes)
		{
			hero.EyeColor = eyes;
			return this;
		}

		public HeroBuilder SetClothes(string clothes)
		{
			hero.Clothes = clothes;
			return this;
		}

		public HeroBuilder SetAbility(string ability)
		{
			hero.Ability = ability;
			return this;
		}

		public HeroBuilder AddItem(string item)
		{
			hero.Inventory.Add(item);
			return this;
		}

		public HeroBuilder AddGoodDeed(string deed)
		{
			hero.GoodDeeds.Add(deed);
			return this;
		}

		public Character Build()
		{
			return hero;
		}
	}
}