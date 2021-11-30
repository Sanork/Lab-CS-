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
		this.res = res;
		this.atack = statAtack;
		this.agility = statAgility;
		this.durability = statDurability;
		this.hp = statHP;
		this.energy = statEnergy;
	}

	public void Input() /*Создание вручную*/
	{
		Console.WriteLine("Введите показатель атаки\n");
		this.atack = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Введите показатель ловкости\n");
		this.agility = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Введите показатель стойкости\n");
		this.durability = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("ВВведите количество очков здоровья\n");
		this.hp = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Введите количество очков энергии\n");
		this.energy = Convert.ToInt32(Console.ReadLine());
		this.res.Input();
	}

	public void Print() /*Вывод информации*/
	{
		Console.WriteLine("Характеристики: ");
		Console.WriteLine("Атака - " + this.atack);
		Console.WriteLine("Ловкость - " + this.agility);
		Console.WriteLine("Стойкость - " + this.durability);
		Console.WriteLine("Здоровье - " + this.hp);
		Console.WriteLine("Энергия - " + this.energy);
		this.res.Print();
	}
}
}
