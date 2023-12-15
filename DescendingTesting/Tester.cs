namespace DescendingTesting
{
	public static class Tester
	{
		public static List<TestingResult> Test(ISolver solver, int count)
		{
			var data = DataGenerator.GenerateData(count);
			var results = new List<TestingResult>();

			foreach (var item in data)
			{
				var expectedDecision = new Decision(solver.GetMinAbsElementRight(item),
					solver.GetSumAbsAfterFirstZeroRight(item), solver.ConvertArrayRight(item));
				var realDecision = new Decision(solver.GetMinAbsElementWrong(item),
					solver.GetSumAbsAfterFirstZeroWrong(item), solver.ConvertArrayWrong(item));

				results.Add(new(item, expectedDecision, realDecision,
					!DecisionsAreEqual(expectedDecision, realDecision)));
			}

			return results;
		}

		private static bool DecisionsAreEqual(Decision dec1, Decision dec2)
		{
			return dec1.MinElement == dec2.MinElement &&
				dec1.Sum == dec2.Sum &&
				dec1.CovertedNumbers.SequenceEqual(dec2.CovertedNumbers);
		}
	}
}
