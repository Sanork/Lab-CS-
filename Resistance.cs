using System;

namespace lab5
{
	public class Resistance
	{
		private int poison_res;  /*Сопротивление яду*/
		private int fire_res;    /*Сопротивление огню*/
		private int frost_res;   /*Сопротивление холоду*/

		public void Init(int resistancePoison, int resistanceFire, int resistanceFrost)   /*Создание*/
		{
			poison_res = resistancePoison;
			fire_res = resistancePoison;
			frost_res = resistanceFrost;
		}

		public void Input()   /*Создание вручную*/
		{
			Console.WriteLine("Введите сопротивление яду\n");
			poison_res = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите сопротивление огню\n");
			fire_res = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите сопротивление холоду\n");
			frost_res = Convert.ToInt32(Console.ReadLine());
		}

		public void Print()  /*Вывод информации*/
		{
			Console.WriteLine("\nСопротивление: ");
			Console.WriteLine("Сопротивление яду - " + poison_res);
			Console.WriteLine("Сопротивление огню - " + fire_res);
			Console.WriteLine("Сопротивление холоду - " + frost_res);
		}
	}
}
