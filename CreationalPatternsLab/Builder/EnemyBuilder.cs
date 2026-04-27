using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsLab.Builder
{
	public class EnemyBuilder : ICharacterBuilder
	{
		private Character enemy = new Character();

		public EnemyBuilder SetHeight(int height)
		{
			enemy.Height = height;
			return this;
		}

		public EnemyBuilder SetBody(string body)
		{
			enemy.Body = body;
			return this;
		}

		public EnemyBuilder SetHair(string hair)
		{
			enemy.HairColor = hair;
			return this;
		}

		public EnemyBuilder SetEyes(string eyes)
		{
			enemy.EyeColor = eyes;
			return this;
		}

		public EnemyBuilder SetClothes(string clothes)
		{
			enemy.Clothes = clothes;
			return this;
		}

		public EnemyBuilder SetAbility(string ability)
		{
			enemy.Ability = ability;
			return this;
		}

		public EnemyBuilder AddItem(string item)
		{
			enemy.Inventory.Add(item);
			return this;
		}

		public EnemyBuilder AddEvilDeed(string deed)
		{
			enemy.EvilDeeds.Add(deed);
			return this;
		}

		public Character Build()
		{
			return enemy;
		}
	}
}