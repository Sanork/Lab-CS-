using System;

namespace lab5
{
   class Program
    {
        static void Main(string[] args)
        {
			
		    Guild guild = new Guild();
			guild.Init("Гильдия магов", 15, "Колдовство");
			Character exm = new Character();   //Статический массив
			exm.arm.Init("Кожа", 8, "Легкая", 32);
			exm.weap.Init("Лук", 2, 44);
			exm.stat.Init(15, 72, 21, 1000, 500, exm.stat.res);
			exm.stat.res.Init(20, 10, 10);
			exm.Init("Леголас", 52, "Лесной эльф", exm.arm, exm.weap, exm.stat, exm.stat.res, guild); /*Создание персонажа для примера*/
			exm.Print();   /*Вывод*/
			

		
		}
    }
}
