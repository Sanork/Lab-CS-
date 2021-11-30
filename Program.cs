using System;


namespace lab5
{
   class Program
    {
        static void Main(string[] args)
        {
			Guild guild = new Guild();
			guild.Init("Гильдия магов", 15, "Колдовство");
			Character exm1 = new Character();   //Статический массив
			exm1.arm.Init("Кожа", 8, "Легкая", 32);
			exm1.weap.Init("Лук", 2, 44);
			exm1.stat.Init(15, 72, 21, 1000, 500, exm1.stat.res);
			exm1.stat.res.Init(20, 10, 10);
			exm1.Init("Леголас", 52, "Лесной эльф", exm1.arm, exm1.weap, exm1.stat, exm1.stat.res, guild); /*Создание персонажа для примера*/
			exm1.Print();   /*Вывод*/

			Character exm2 = new Character();
			exm2.arm.Init("Железо", 8, "Тяжелая", 32);
			exm2.weap.Init("Меч", 7, 55);
			exm2.stat.Init(30, 20, 80, 2000, 400, exm2.stat.res);
			exm2.stat.res.Init(30, 50, 20);
			exm2.Init("Леон", 48, "Человек", exm2.arm, exm2.weap, exm2.stat, exm2.stat.res, guild); /*Создание персонажа для примера*/
			exm2.Print();

		}
	}
}
