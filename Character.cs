using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
     public class Character
    {
        private string name; /*Имя*/
        private int lvl; /*Уровень*/
        private string race; /*Раса*/
		public Guild guild { get; set; }   /*Информация о гильдии*/
        public Armor arm ; /*Класс брони*/
		public Weapon weap; /*Класс оружия*/
		public Stats stat; /*Класс характеристик*/

		public Character()
        {
			//guild = new Guild();
			arm = new Armor();
			weap = new Weapon();
			stat = new Stats();
        }
		public void Init(string characterName, int characterLVL, string characterRace, Armor arm, Weapon weap, Stats st, Resistance res, Guild gld) /*Создание персонажа*/
		{
			this.name = characterName;
			this.lvl = characterLVL;
			this.race = characterRace;
			this.arm = arm;
			this.weap = weap;
			this.stat = st;
			this.guild = gld;
		}

		public void Input()  /*Создание персонажа вручную с консоли*/
		{
			Console.WriteLine("Введите имя персонажа\n");
			this.name = Console.ReadLine();
			Console.WriteLine("Введите уровень персонажа\n");
			this.lvl = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите расу персонажа\n");
			this.race = Console.ReadLine();

		    this.arm.Input();
			this.weap.Input();
			this.stat.Input();
			this.guild.Input();
		}

		public void Print() /*Вывод информации о персонаже*/
		{
			Console.WriteLine("Персонаж: ");
			Console.WriteLine("Имя - " + this.name);
			Console.WriteLine("Уровень - " + this.lvl);
			Console.WriteLine("Раса - " + this.race);
			this.arm.Print();
			this.weap.Print();
			this.stat.Print();
			this.guild.Print();
		}

	}
}
