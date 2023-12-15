namespace DescendingTesting
{
	public static class Solver
	{
		public static int? GetMinAbsElementRight(int[] numbers)
		{
			if (numbers.Length == 0)
			{
				return null;
			}

			int minAbsElement = numbers[0];

			foreach (var n in numbers)
			{
				if (Math.Abs(n) < Math.Abs(minAbsElement))
				{
					minAbsElement = n;
				}
			}

			return minAbsElement;
		}

		public static int? GetMinAbsElementWrong(int[] numbers)
		{
			if (numbers.Length == 0)
			{
				return null;
			}

			int minAbsElement = numbers[0];

			foreach (var n in numbers)
			{
				if (Math.Abs(n) < Math.Abs(minAbsElement))
				{
					minAbsElement = Math.Abs(n);
				}
			}

			return minAbsElement;
		}

		public static int GetSumAbsAfterFirstZeroRight(int[] numbers)
		{
			int firstZeroIndex = numbers.Length;

			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i] == 0)
				{
					firstZeroIndex = i;
					break;
				}
			}

			int sum = 0;

			for (int i = firstZeroIndex + 1; i < numbers.Length; i++)
			{
				sum += Math.Abs(numbers[i]);
			}

			return sum;
		}

		public static int GetSumAbsAfterFirstZeroWrong(int[] numbers)
		{
			int firstZeroIndex = numbers.Length;

			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i] == 0)
				{
					firstZeroIndex = i;
					break;
				}
			}

			int sum = 0;

			for (int i = firstZeroIndex + 2; i < numbers.Length; i++)
			{
				sum += Math.Abs(numbers[i]);
			}

			return sum;
		}

		public static int[] ConvertArrayRight(int[] numbers)
		{
			List<int> listWithElemsOnEvenPositions = new(), listWithElemsOnOddPositions = new();

			for (int i = 0; i < numbers.Length; i++)
			{
				if (i % 2 == 0)
				{
					listWithElemsOnEvenPositions.Add(numbers[i]);
				}
				else
				{
					listWithElemsOnOddPositions.Add(numbers[i]);
				}
			}

			return listWithElemsOnEvenPositions.Concat(listWithElemsOnOddPositions).ToArray();
		}

		public static int[] ConvertArrayWrong(int[] numbers)
		{
			List<int> listWithElemsOnEvenPositions = new(), listWithElemsOnOddPositions = new();

			for (int i = 0; i < numbers.Length; i++)
			{
				if (i % 4 == 0)
				{
					listWithElemsOnEvenPositions.Add(numbers[i]);
				}
				else
				{
					listWithElemsOnOddPositions.Add(numbers[i]);
				}
			}

			return listWithElemsOnEvenPositions.Concat(listWithElemsOnOddPositions).ToArray();
		}
	}
}
