namespace DescendingTesting
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.TaskPage = new System.Windows.Forms.TabPage();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.TestingPage = new System.Windows.Forms.TabPage();
			this.listView1 = new System.Windows.Forms.ListView();
			this.NumberColumn = new System.Windows.Forms.ColumnHeader();
			this.ArrayColumn = new System.Windows.Forms.ColumnHeader();
			this.ExpectedMinElemColumn = new System.Windows.Forms.ColumnHeader();
			this.RealMinElemColumn = new System.Windows.Forms.ColumnHeader();
			this.ExpectedSumColumn = new System.Windows.Forms.ColumnHeader();
			this.RealSumColumn = new System.Windows.Forms.ColumnHeader();
			this.ExpectedConvertedArrayColumn = new System.Windows.Forms.ColumnHeader();
			this.RealConvertedArrayColumn = new System.Windows.Forms.ColumnHeader();
			this.SuccessColumn = new System.Windows.Forms.ColumnHeader();
			this.TestingButton = new System.Windows.Forms.Button();
			this.CountLabel = new System.Windows.Forms.Label();
			this.CountTextBox = new System.Windows.Forms.TextBox();
			this.ThreePlugsRadioButton = new System.Windows.Forms.RadioButton();
			this.TwoPlugsRadioButton = new System.Windows.Forms.RadioButton();
			this.OnePlugRadioButton = new System.Windows.Forms.RadioButton();
			this.NoPlugsRadioButton = new System.Windows.Forms.RadioButton();
			this.tabControl1.SuspendLayout();
			this.TaskPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.TestingPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.TaskPage);
			this.tabControl1.Controls.Add(this.TestingPage);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1560, 558);
			this.tabControl1.TabIndex = 0;
			// 
			// TaskPage
			// 
			this.TaskPage.Controls.Add(this.pictureBox1);
			this.TaskPage.Location = new System.Drawing.Point(4, 32);
			this.TaskPage.Name = "TaskPage";
			this.TaskPage.Padding = new System.Windows.Forms.Padding(3);
			this.TaskPage.Size = new System.Drawing.Size(1278, 522);
			this.TaskPage.TabIndex = 0;
			this.TaskPage.Text = "Постановка задачи";
			this.TaskPage.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(6, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1266, 510);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// TestingPage
			// 
			this.TestingPage.Controls.Add(this.listView1);
			this.TestingPage.Controls.Add(this.TestingButton);
			this.TestingPage.Controls.Add(this.CountLabel);
			this.TestingPage.Controls.Add(this.CountTextBox);
			this.TestingPage.Controls.Add(this.ThreePlugsRadioButton);
			this.TestingPage.Controls.Add(this.TwoPlugsRadioButton);
			this.TestingPage.Controls.Add(this.OnePlugRadioButton);
			this.TestingPage.Controls.Add(this.NoPlugsRadioButton);
			this.TestingPage.Location = new System.Drawing.Point(4, 32);
			this.TestingPage.Name = "TestingPage";
			this.TestingPage.Padding = new System.Windows.Forms.Padding(3);
			this.TestingPage.Size = new System.Drawing.Size(1552, 522);
			this.TestingPage.TabIndex = 1;
			this.TestingPage.Text = "Тестирование";
			this.TestingPage.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumberColumn,
            this.ArrayColumn,
            this.ExpectedMinElemColumn,
            this.RealMinElemColumn,
            this.ExpectedSumColumn,
            this.RealSumColumn,
            this.ExpectedConvertedArrayColumn,
            this.RealConvertedArrayColumn,
            this.SuccessColumn});
			this.listView1.Location = new System.Drawing.Point(6, 263);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(1540, 253);
			this.listView1.TabIndex = 7;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// NumberColumn
			// 
			this.NumberColumn.Text = "Номер текста";
			// 
			// ArrayColumn
			// 
			this.ArrayColumn.Text = "Массив";
			// 
			// ExpectedMinElemColumn
			// 
			this.ExpectedMinElemColumn.Text = "Ожидаемый минимальный элемент";
			// 
			// RealMinElemColumn
			// 
			this.RealMinElemColumn.Text = "Фактический минимальный элемент";
			// 
			// ExpectedSumColumn
			// 
			this.ExpectedSumColumn.Text = "Ожидаемая сумма";
			// 
			// RealSumColumn
			// 
			this.RealSumColumn.Text = "Фактическая сумма";
			// 
			// ExpectedConvertedArrayColumn
			// 
			this.ExpectedConvertedArrayColumn.Text = "Ожидаемый преобразованный массив";
			// 
			// RealConvertedArrayColumn
			// 
			this.RealConvertedArrayColumn.Text = "Фактический преобразованный массив";
			// 
			// SuccessColumn
			// 
			this.SuccessColumn.Text = "Результат";
			// 
			// TestingButton
			// 
			this.TestingButton.Enabled = false;
			this.TestingButton.Location = new System.Drawing.Point(430, 175);
			this.TestingButton.Name = "TestingButton";
			this.TestingButton.Size = new System.Drawing.Size(233, 73);
			this.TestingButton.TabIndex = 6;
			this.TestingButton.Text = "Тестировать";
			this.TestingButton.UseVisualStyleBackColor = true;
			this.TestingButton.Click += new System.EventHandler(this.TestingButton_Click);
			// 
			// CountLabel
			// 
			this.CountLabel.AutoSize = true;
			this.CountLabel.Location = new System.Drawing.Point(282, 107);
			this.CountLabel.Name = "CountLabel";
			this.CountLabel.Size = new System.Drawing.Size(260, 23);
			this.CountLabel.TabIndex = 5;
			this.CountLabel.Text = "Количество элементов массива";
			// 
			// CountTextBox
			// 
			this.CountTextBox.Location = new System.Drawing.Point(565, 107);
			this.CountTextBox.Name = "CountTextBox";
			this.CountTextBox.Size = new System.Drawing.Size(125, 30);
			this.CountTextBox.TabIndex = 4;
			this.CountTextBox.TextChanged += new System.EventHandler(this.CountTextBox_TextChanged);
			// 
			// ThreePlugsRadioButton
			// 
			this.ThreePlugsRadioButton.AutoSize = true;
			this.ThreePlugsRadioButton.Location = new System.Drawing.Point(768, 177);
			this.ThreePlugsRadioButton.Name = "ThreePlugsRadioButton";
			this.ThreePlugsRadioButton.Size = new System.Drawing.Size(155, 27);
			this.ThreePlugsRadioButton.TabIndex = 3;
			this.ThreePlugsRadioButton.Text = "С 3 заглушками";
			this.ThreePlugsRadioButton.UseVisualStyleBackColor = true;
			// 
			// TwoPlugsRadioButton
			// 
			this.TwoPlugsRadioButton.AutoSize = true;
			this.TwoPlugsRadioButton.Location = new System.Drawing.Point(768, 133);
			this.TwoPlugsRadioButton.Name = "TwoPlugsRadioButton";
			this.TwoPlugsRadioButton.Size = new System.Drawing.Size(155, 27);
			this.TwoPlugsRadioButton.TabIndex = 2;
			this.TwoPlugsRadioButton.Text = "С 2 заглушками";
			this.TwoPlugsRadioButton.UseVisualStyleBackColor = true;
			// 
			// OnePlugRadioButton
			// 
			this.OnePlugRadioButton.AutoSize = true;
			this.OnePlugRadioButton.Location = new System.Drawing.Point(768, 87);
			this.OnePlugRadioButton.Name = "OnePlugRadioButton";
			this.OnePlugRadioButton.Size = new System.Drawing.Size(144, 27);
			this.OnePlugRadioButton.TabIndex = 1;
			this.OnePlugRadioButton.Text = "С 1 заглушкой";
			this.OnePlugRadioButton.UseVisualStyleBackColor = true;
			// 
			// NoPlugsRadioButton
			// 
			this.NoPlugsRadioButton.AutoSize = true;
			this.NoPlugsRadioButton.Checked = true;
			this.NoPlugsRadioButton.Location = new System.Drawing.Point(768, 41);
			this.NoPlugsRadioButton.Name = "NoPlugsRadioButton";
			this.NoPlugsRadioButton.Size = new System.Drawing.Size(135, 27);
			this.NoPlugsRadioButton.TabIndex = 0;
			this.NoPlugsRadioButton.TabStop = true;
			this.NoPlugsRadioButton.Text = "Без заглушек";
			this.NoPlugsRadioButton.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.OldLace;
			this.ClientSize = new System.Drawing.Size(1584, 582);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Нисходящее тестирование";
			this.tabControl1.ResumeLayout(false);
			this.TaskPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.TestingPage.ResumeLayout(false);
			this.TestingPage.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private TabControl tabControl1;
		private TabPage TaskPage;
		private TabPage TestingPage;
		private RadioButton ThreePlugsRadioButton;
		private RadioButton TwoPlugsRadioButton;
		private RadioButton OnePlugRadioButton;
		private RadioButton NoPlugsRadioButton;
		private PictureBox pictureBox1;
		private Button TestingButton;
		private Label CountLabel;
		private TextBox CountTextBox;
		private ListView listView1;
		private ColumnHeader NumberColumn;
		private ColumnHeader ArrayColumn;
		private ColumnHeader ExpectedMinElemColumn;
		private ColumnHeader RealMinElemColumn;
		private ColumnHeader ExpectedSumColumn;
		private ColumnHeader RealSumColumn;
		private ColumnHeader ExpectedConvertedArrayColumn;
		private ColumnHeader RealConvertedArrayColumn;
		private ColumnHeader SuccessColumn;
	}
}