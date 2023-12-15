namespace DescendingTesting
{
	public record TestingResult(int[] Numbers, Decision ExpectedResult, Decision RealResult, bool Successful)
	{
	}
}
