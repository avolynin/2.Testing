using System;

using NUnit.Framework;

namespace Mallenom.Testing.Tests
{
	[TestFixture]
	class EntityTest
	{
		private Entity _entity;

		[SetUp]
		public void SetUp()
		{
			_entity = new Entity();
		}

		[Test]
		public void GetYearFormatRus_0_let()
		{
			//arrange
			_entity.Age = 0;
			string expected = "лет";

			//act
			string result = _entity.GetYearFormatRus();

			//assert
			Assert.AreEqual(expected, result);
		}

		[Test]
		public void GetYearFormatRus_1_god()
		{
			//arrange
			_entity.Age = 1;
			string expected = "год";

			//act
			string result = _entity.GetYearFormatRus();

			//assert
			Assert.AreEqual(expected, result);
		}

		[Test]
		public void GetYearFormatRus_2_goda()
		{
			//arrange
			_entity.Age = 2;
			string expected = "года";

			//act
			string result = _entity.GetYearFormatRus();

			//assert
			Assert.AreEqual(expected, result);
		}

		[Test]
		public void GetYearFormatRus_5_let()
		{
			//arrange
			_entity.Age = 5;
			string expected = "лет";

			//act
			string result = _entity.GetYearFormatRus();

			//assert
			Assert.AreEqual(expected, result);
		}

		[Test]
		public void GetYearFormatRus_11_let()
		{
			//arrange
			_entity.Age = 11;
			string expected = "лет";

			//act
			string result = _entity.GetYearFormatRus();

			//assert
			Assert.AreEqual(expected, result);
		}

		[Test]
		public void GetYearFormatRus_21_god()
		{
			//arrange
			_entity.Age = 21;
			string expected = "год";

			//act
			string result = _entity.GetYearFormatRus();

			//assert
			Assert.AreEqual(expected, result);
		}

		[Test]
		public void GetYearFormatRus_25_let()
		{
			//arrange
			_entity.Age = 25;
			string expected = "лет";

			//act
			string result = _entity.GetYearFormatRus();

			//assert
			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Age_minus1_Exception()
		{
			Assert.Throws<Exception>(
				() =>
				{
					var tmp = _entity.Age;
				});
		}
	}
}
