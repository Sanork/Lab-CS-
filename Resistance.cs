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
			this.poison_res = resistancePoison;
			this.fire_res = resistancePoison;
			this.frost_res = resistanceFrost;
		}

		public void Input()   /*Создание вручную*/
		{
			Console.WriteLine("Введите сопротивление яду\n");
			this.poison_res = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите сопротивление огню\n");
			this.fire_res = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите сопротивление холоду\n");
			this.frost_res = Convert.ToInt32(Console.ReadLine());
		}

		public void Print()  /*Вывод информации*/
		{
			Console.WriteLine("\nСопротивление: ");
			Console.WriteLine("Сопротивление яду - " + this.poison_res);
			Console.WriteLine("Сопротивление огню - " + this.fire_res);
			Console.WriteLine("Сопротивление холоду - " + this.frost_res);
		}
	}
}
