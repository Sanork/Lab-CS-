using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    public class Weapon
    {
		
	    private string type;   /*Тип оружия*/
		private int weight;    /*Вес оружия*/
		private int damage;    /*Урон оружия*/

		public void Init(string weaponType, int weaponWeight, int weaponDamage) /*Функция создания оружия*/
		{
			type = weaponType;
			weight = weaponWeight;
			damage = weaponDamage;
		}

		public void Input()   /*Функция создания оружия вручную с консоли*/
		{
			Console.WriteLine("Введите тип оружия\n");
			type = Console.ReadLine(); 
			Console.WriteLine ("Введите вес оружия\n");
			weight = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine ("Введите урон оружия\n");
			damage = Convert.ToInt32(Console.ReadLine());
		}

		public void Print()  /*Функция вывода информации об оружии*/
		{
			Console.WriteLine("\nОружие: ");
			Console.WriteLine("Тип оружия - " + type);
			Console.WriteLine("Вес оружия - " + weight);
			Console.WriteLine("Урон оружия - " + damage);
		}
	}
}
