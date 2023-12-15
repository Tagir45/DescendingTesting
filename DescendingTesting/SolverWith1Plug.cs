namespace DescendingTesting
{
	public class SolverWith1Plug : ISolver
	{
		public int? GetMinAbsElementRight(int[] numbers)
		{
			return Solver.GetMinAbsElementRight(numbers);
		}

		public int? GetMinAbsElementWrong(int[] numbers)
		{
			return Solver.GetMinAbsElementWrong(numbers);
		}

		public int GetSumAbsAfterFirstZeroRight(int[] numbers)
		{
			return Solver.GetSumAbsAfterFirstZeroRight(numbers);
		}

		public int GetSumAbsAfterFirstZeroWrong(int[] numbers)
		{
			return Solver.GetSumAbsAfterFirstZeroWrong(numbers);
		}

		public int[] ConvertArrayRight(int[] numbers)
		{
			return numbers;
		}

		public int[] ConvertArrayWrong(int[] numbers)
		{
			return numbers;
		}
	}
}
