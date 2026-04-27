using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsLab.Builder
{
	public class CharacterDirector
	{
		public Character CreateHero()
		{
			return new HeroBuilder()
				.SetHeight(180)
				.SetBody("Атлетична")
				.SetHair("Світле")
				.SetEyes("Сині")
				.SetClothes("Лицарська броня")
				.SetAbility("Лікування")
				.AddItem("Меч")
				.AddItem("Щит")
				.AddGoodDeed("Врятував місто")
				.Build();
		}

		public Character CreateEnemy()
		{
			return new EnemyBuilder()
				.SetHeight(195)
				.SetBody("Масивна")
				.SetHair("Чорне")
				.SetEyes("Червоні")
				.SetClothes("Темна мантія")
				.SetAbility("Темна магія")
				.AddItem("Темний посох")
				.AddEvilDeed("Знищив село")
				.Build();
		}
	}
}