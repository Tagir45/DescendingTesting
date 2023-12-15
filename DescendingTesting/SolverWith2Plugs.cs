namespace DescendingTesting
{
	public class SolverWith2Plugs : ISolver
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
			return 0;
		}

		public int GetSumAbsAfterFirstZeroWrong(int[] numbers)
		{
			return 0;
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
