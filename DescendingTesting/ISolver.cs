namespace DescendingTesting
{
	public interface ISolver
	{
		int? GetMinAbsElementRight(int[] numbers);
		int? GetMinAbsElementWrong(int[] numbers);
		int GetSumAbsAfterFirstZeroRight(int[] numbers);
		int GetSumAbsAfterFirstZeroWrong(int[] numbers);
		int[] ConvertArrayRight(int[] numbers);
		int[] ConvertArrayWrong(int[] numbers);
	}
}
