using System;

namespace lab5
{
	public class Armor
	{
		
		private string material;  /*Материал брони*/
		private int weight;     /*Вес брони*/
		private string w_class;    /*Класс брони*/
		private int defense;   /*Защита брони*/


		public void Init(string armorMaterial, int armorWeight, string armorClass, int armorDefence) /*Функция создания брони*/
		{
			material = armorMaterial;
			weight = armorWeight;
			w_class = armorClass;
			defense = armorDefence;
		}

		public void Input() /*Функция создания брони вручную с консоли*/
		{
			Console.WriteLine("Введите материал брони\n");
			material = Console.ReadLine();
			Console.WriteLine("Введите вес брони\n");
			weight = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите класс брони\n");
			w_class = Console.ReadLine();
			Console.WriteLine("Введите показатель защиты брони\n");
			defense = Convert.ToInt32(Console.ReadLine());
		}

		public void Print() /*Функция вывода информации о броне*/
		{
			Console.WriteLine("\nБроня: ");
			Console.WriteLine("Материал брони - " + material);
			Console.WriteLine("Вес брони - " + weight);
			Console.WriteLine("Класс брони - " + w_class);
			Console.WriteLine("Показатель защиты брони - " + defense);
		}
	}
}

