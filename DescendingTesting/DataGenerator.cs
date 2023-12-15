namespace DescendingTesting
{
	public static class DataGenerator
	{
		private static Random GRandom { get; } = new();
		private const int MinElem = -30, MaxElem = 30;

		public static List<int[]> GenerateData(int count)
		{
			return new List<int[]>
			{
				Array.Empty<int>(),
				GenerateArrayWithOneElement(),
				GenerateArrayWithSameElements(count),
				GenerateArrayWithNoZeros(count),
				GenerateArrayWithOneZero(count),
				GenerateArrayWithTwoZeros(count),
			};
		}

		private static int[] GenerateArrayWithOneElement()
		{
			return new int[]
			{
				RandomInt()
			};
		}

		private static int[] GenerateArrayWithSameElements(int count)
		{
			var element = RandomInt();

			return Enumerable.Repeat(element, count).ToArray();
		}

		private static int[] GenerateArray(int count)
		{
			var array = new int[count];

			for (int i = 0; i < count; i++)
			{
				array[i] = RandomInt();
			}

			return array;
		}

		private static int[] GenerateArrayWithNoZeros(int count)
		{
			var array = GenerateArray(count);

			for (int i = 0; i < array.Length; i++)
			{
				while (array[i] == 0)
				{
					array[i] = RandomInt();
				}
			}

			return array;
		}

		private static int[] GenerateArrayWithOneZero(int count)
		{
			var array = GenerateArrayWithNoZeros(count);

			int indexToPutZero = GRandom.Next(array.Length);

			array[indexToPutZero] = 0;

			return array;
		}

		private static int[] GenerateArrayWithTwoZeros(int count)
		{
			var array = GenerateArray(count);

			int indexToPutFirstZero, indexToPutSecondZero;
			do
			{
				indexToPutFirstZero = GRandom.Next(array.Length);
				indexToPutSecondZero = GRandom.Next(array.Length);
			}
			while (indexToPutFirstZero == indexToPutSecondZero);

			array[indexToPutFirstZero] = 0;
			array[indexToPutSecondZero] = 0;

			return array;
		}

		private static int RandomInt()
		{
			return GRandom.Next(MinElem, MaxElem);
		}
	}
}
