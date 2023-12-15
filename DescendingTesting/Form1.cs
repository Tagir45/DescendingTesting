namespace DescendingTesting
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			foreach (ColumnHeader header in listView1.Columns)
			{
				header.Width = listView1.Width / listView1.Columns.Count;
			}
		}

		private ISolver GetSolver()
		{
			if (NoPlugsRadioButton.Checked)
			{
				return new SolverWithNoPlugs();
			}
			if (OnePlugRadioButton.Checked)
			{
				return new SolverWith1Plug();
			}
			if (TwoPlugsRadioButton.Checked)
			{
				return new SolverWith2Plugs();
			}
			
			return new SolverWith3Plugs();
		}

		private void CountTextBox_TextChanged(object sender, EventArgs e)
		{
			TestingButton.Enabled = CountIsCorrect();
		}

		private bool CountIsCorrect()
		{
			var value = CountTextBox.Text;
			return value is not null &&
				int.TryParse(value, out _) &&
				Convert.ToInt32(value) > 0;
		}

		private void TestingButton_Click(object sender, EventArgs e)
		{
			listView1.Items.Clear();

			var results = Tester.Test(GetSolver(), Convert.ToInt32(CountTextBox.Text));
			FillTable(results);
		}

		private void FillTable(List<TestingResult> results)
		{
			for (int i = 0; i < results.Count; i++)
			{
				var result = results[i];

				var item = new ListViewItem(i.ToString());

				item.SubItems.Add(GetStringArray(result.Numbers));
				item.SubItems.Add(result.ExpectedResult.MinElement.ToString());
				item.SubItems.Add(result.RealResult.MinElement.ToString());
				item.SubItems.Add(result.ExpectedResult.Sum.ToString());
				item.SubItems.Add(result.RealResult.Sum.ToString());
				item.SubItems.Add(GetStringArray(result.ExpectedResult.CovertedNumbers));
				item.SubItems.Add(GetStringArray(result.RealResult.CovertedNumbers));
				item.SubItems.Add(result.Successful ? "Успешно" : "Неудачно");

				listView1.Items.Add(item);
			}
		}

		private static string GetStringArray(int[] array)
		{
			return string.Join(",", array);
		}
	}
}