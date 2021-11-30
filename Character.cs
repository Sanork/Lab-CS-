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
		private static int count = 0;
		private int id;
		public Guild guild { get; set; }   /*Информация о гильдии*/
		public Armor arm; /*Класс брони*/
		public Weapon weap; /*Класс оружия*/
		public Stats stat; /*Класс характеристик*/

		public Character()
		{
			//guild = new Guild();
			arm = new Armor();
			weap = new Weapon();
			stat = new Stats();
		}
		public void Init(string characterName, int characterLVL, string characterRace, Armor armor, Weapon weapon, Stats stats, Resistance resist, Guild gld) /*Создание персонажа*/
		{
			name = characterName;
			lvl = characterLVL;
			race = characterRace;
			arm = armor;
			weap = weapon;
			stat = stats;
			guild = gld;
			count++;
			id = count;
		}

		public void Input()  /*Создание персонажа вручную с консоли*/
		{
			Console.WriteLine("Введите имя персонажа\n");
			name = Console.ReadLine();
			Console.WriteLine("Введите уровень персонажа\n");
			lvl = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите расу персонажа\n");
			race = Console.ReadLine();

			arm.Input();
			weap.Input();
			stat.Input();
			guild.Input();
			count++;
			id = count;
		}

		public void Print() /*Вывод информации о персонаже*/
		{
			Console.WriteLine("Персонаж: ");
			Console.WriteLine("Имя - " + name);
			Console.WriteLine("ID - " + id);
			Console.WriteLine("Уровень - " + lvl);
			Console.WriteLine("Раса - " + race);
			arm.Print();
			weap.Print();
			stat.Print();
			guild.Print();
		}

		static public int GetCount()
			{
			return count;
			}

	}
}
