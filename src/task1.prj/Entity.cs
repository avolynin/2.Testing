using System;

namespace Mallenom.Testing
{
	public class Entity
	{
		/// <summary>Возраст сущности</summary>
		private int _age = -1; //Age равняется -1 в случае, если возраст не задан
		/// <summary>Максимальный возможный возраст</summary>
		public const int MaxAge = 99;
		/// <summary>Минимальный возможный возраст</summary>
		public const int MinAge = 0;

		public int Age
		{
			get 
			{
				if(_age == -1) throw new Exception("Возраст неизвестен");

				return _age; 
			}
			set
			{
				if(value < MinAge) throw new ArgumentOutOfRangeException(null, "Возраст должен быть равен 0 или больше");
				if(value > MaxAge) throw new ArgumentOutOfRangeException(null, "Возраст должен быть равен 99 или меньше");

				_age = value;
			}
		}

		/// <returns>Возвращает строку "лет/год/года" в зависимости от возраста</returns>
		public string GetYearFormatRus()
		{
			string yearFormat = null;
			int lastNums = Age;

			//if(lastNums >= 100) lastNums %= 100;
			if(lastNums >= 10 && lastNums <= 19) yearFormat = "лет";
			if(lastNums >= 20 && lastNums <= 99) lastNums %= 10;

			if(lastNums == 0 || (lastNums >= 5 && lastNums <= 9)) yearFormat = "лет";
			if(lastNums == 1) yearFormat = "год";
			if(lastNums >= 2 && lastNums <= 4) yearFormat = "года";

			return yearFormat;
		}

		/// <returns>Возвращает строку формата "{age} лет/год/года."</returns>
		public string GetAgeYear(){ return $"{Age} {GetYearFormatRus()}"; }
	}
}
