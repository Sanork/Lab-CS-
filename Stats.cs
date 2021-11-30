using System;

namespace lab5
{ 
public class Stats
{
		private int atack; /*Атака*/
		private int agility; /*Ловкость*/
		private int durability; /*Стойкость*/
		private int hp; /*Очки здоровья*/
		private int energy; /*Очки энергии*/

		public Resistance res;

		public Stats()
        {
			res = new Resistance();
        }

	public void Init(int statAtack, int statAgility, int statDurability, int statHP, int statEnergy, Resistance res) /*Содание*/
	{
		res = res;
		atack = statAtack;
		agility = statAgility;
		durability = statDurability;
		hp = statHP;
		energy = statEnergy;
	}

	public void Input() /*Создание вручную*/
	{
		Console.WriteLine("Введите показатель атаки\n");
		atack = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Введите показатель ловкости\n");
		agility = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Введите показатель стойкости\n");
		durability = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("ВВведите количество очков здоровья\n");
		hp = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Введите количество очков энергии\n");
		energy = Convert.ToInt32(Console.ReadLine());
		res.Input();
	}

	public void Print() /*Вывод информации*/
	{
		Console.WriteLine("Характеристики: ");
		Console.WriteLine("Атака - " + atack);
		Console.WriteLine("Ловкость - " + agility);
		Console.WriteLine("Стойкость - " + durability);
		Console.WriteLine("Здоровье - " + hp);
		Console.WriteLine("Энергия - " + energy);
		res.Print();
	}
}
}
