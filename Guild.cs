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

		public void Init(string GuildName, int GuildRank, string GuildSpec) /*Функция создания гильдии*/
		{
			name = GuildName;
			rank = GuildRank;
			spec = GuildSpec;
		}

		public void Input() /*Функция создания гильдии вручную с консоли*/
		{
			Console.WriteLine("Введите название гильдии\n");
			name = Console.ReadLine();
			Console.WriteLine("Введите ранг гильдии\n");
			rank = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите специализацию гильдии\n");
			spec = Console.ReadLine();
		}

		public void Print() /*Функция вывода информации о броне*/
		{
			Console.WriteLine("\nГильдия: ");
			Console.WriteLine("Название гильдии - " + name);
			Console.WriteLine("Ранг гильдии - " + rank);
			Console.WriteLine("Специализация гильдии - " + spec);
		}
	}
}

