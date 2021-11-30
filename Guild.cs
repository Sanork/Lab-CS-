using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    public class Guild
    {
        private string name;
		private int rank;
		private string spec;

		public void Init(string name, int rank, string spec) /*Функция создания гильдии*/
		{
			this.name = name;
			this.rank = rank;
			this.spec = spec;
		}

		public void Input() /*Функция создания гильдии вручную с консоли*/
		{
			Console.WriteLine("Введите название гильдии\n");
			this.name = Console.ReadLine();
			Console.WriteLine("Введите ранг гильдии\n");
			this.rank = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите специализацию гильдии\n");
			this.spec = Console.ReadLine();
		}

		public void Print() /*Функция вывода информации о броне*/
		{
			Console.WriteLine("\nГильдия: ");
			Console.WriteLine("Название гильдии - " + this.name);
			Console.WriteLine("Ранг гильдии - " + this.rank);
			Console.WriteLine("Специализация гильдии - " + this.spec);
		}
	}
}

