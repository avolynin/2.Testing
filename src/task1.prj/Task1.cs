using System;

namespace Mallenom.Testing
{
	class Task1
	{
		static void Main(string[] args)
		{
			Entity entity = new Entity();
			int N; //Целочисленный возраст в годах
			Console.Write($"Введите ваш возраст (от {Entity.MinAge} до {Entity.MaxAge}): ");

			try
			{
				N = Int32.Parse(Console.ReadLine());
				entity.Age = N;
				Console.WriteLine("Мне " + entity.GetAgeYear());
			}
			catch(FormatException exc){ Console.WriteLine("Возраст должен состоять из целочисленного значения"); }
			catch(Exception exc){ Console.WriteLine(exc.Message); }
		}
	}
}
