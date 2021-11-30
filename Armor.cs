using System;

namespace lab5
{
	public class Armor
	{
		//public Armor()



		private string material;  /*Материал брони*/
		private int weight;     /*Вес брони*/
		private string w_class;    /*Класс брони*/
		private int defense;   /*Защита брони*/


		public void Init(string armorMaterial, int armorWeight, string armorClass, int armorDefence) /*Функция создания брони*/
		{
			this.material = armorMaterial;
			this.weight = armorWeight;
			this.w_class = armorClass;
			this.defense = armorDefence;
		}

		public void Input() /*Функция создания брони вручную с консоли*/
		{
			Console.WriteLine("Введите материал брони\n");
			this.material = Console.ReadLine();
			Console.WriteLine("Введите вес брони\n");
			this.weight = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите класс брони\n");
			this.w_class = Console.ReadLine();
			Console.WriteLine("Введите показатель защиты брони\n");
			this.defense = Convert.ToInt32(Console.ReadLine());
		}

		public void Print() /*Функция вывода информации о броне*/
		{
			Console.WriteLine("\nБроня: ");
			Console.WriteLine("Материал брони - " + this.material);
			Console.WriteLine("Вес брони - " + this.weight);
			Console.WriteLine("Класс брони - " + this.w_class);
			Console.WriteLine("Показатель защиты брони - " + this.defense);
		}
	}
}

