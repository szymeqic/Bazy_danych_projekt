using Npgsql;

namespace Bazy

{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public string login;
		public string password;
		public string opis_towaru;
		public int cena_towaru;
		public Form2 parent;
		NpgsqlConnection connection;
		NpgsqlCommand command;

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
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			groupBox2 = new GroupBox();
			groupBox1 = new GroupBox();
			button1 = new Button();
			label2 = new Label();
			label1 = new Label();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			dataGridView1 = new DataGridView();
			tabPage2 = new TabPage();
			dataGridView2 = new DataGridView();
			tabPage3 = new TabPage();
			dataGridView3 = new DataGridView();
			tabPage4 = new TabPage();
			tabPage5 = new TabPage();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
			tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Controls.Add(tabPage3);
			tabControl1.Controls.Add(tabPage4);
			tabControl1.Controls.Add(tabPage5);
			tabControl1.Location = new Point(12, 12);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(776, 426);
			tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(groupBox2);
			tabPage1.Controls.Add(groupBox1);
			tabPage1.Controls.Add(dataGridView1);
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(768, 398);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Towary";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			groupBox2.Location = new Point(540, 135);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(222, 113);
			groupBox2.TabIndex = 2;
			groupBox2.TabStop = false;
			groupBox2.Text = "Usuń artykuł";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(textBox2);
			groupBox1.Controls.Add(textBox1);
			groupBox1.Location = new Point(540, 6);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(222, 123);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Dodaj artykuł";
			// 
			// button1
			// 
			button1.Location = new Point(136, 84);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 4;
			button1.Text = "Zatwierdź";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(6, 67);
			label2.Name = "label2";
			label2.Size = new Size(34, 15);
			label2.TabIndex = 3;
			label2.Text = "Cena";
			label2.Click += label2_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 23);
			label1.Name = "label1";
			label1.Size = new Size(31, 15);
			label1.TabIndex = 2;
			label1.Text = "Opis";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(6, 85);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(73, 23);
			textBox2.TabIndex = 1;
			textBox2.TextChanged += text_towary;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(6, 41);
			textBox1.MaxLength = 85;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(205, 23);
			textBox1.TabIndex = 0;
			textBox1.TextChanged += text_towary;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(6, 6);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(414, 386);
			dataGridView1.TabIndex = 0;
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(dataGridView2);
			tabPage2.Location = new Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(768, 398);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Klienci";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView2.Location = new Point(6, 6);
			dataGridView2.Name = "dataGridView2";
			dataGridView2.Size = new Size(359, 386);
			dataGridView2.TabIndex = 0;
			// 
			// tabPage3
			// 
			tabPage3.Controls.Add(dataGridView3);
			tabPage3.Location = new Point(4, 24);
			tabPage3.Name = "tabPage3";
			tabPage3.Padding = new Padding(3);
			tabPage3.Size = new Size(768, 398);
			tabPage3.TabIndex = 2;
			tabPage3.Text = "Faktury";
			tabPage3.UseVisualStyleBackColor = true;
			// 
			// dataGridView3
			// 
			dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView3.Location = new Point(6, 6);
			dataGridView3.Name = "dataGridView3";
			dataGridView3.Size = new Size(388, 386);
			dataGridView3.TabIndex = 0;
			// 
			// tabPage4
			// 
			tabPage4.Location = new Point(4, 24);
			tabPage4.Name = "tabPage4";
			tabPage4.Padding = new Padding(3);
			tabPage4.Size = new Size(768, 398);
			tabPage4.TabIndex = 3;
			tabPage4.Text = "tabPage4";
			tabPage4.UseVisualStyleBackColor = true;
			// 
			// tabPage5
			// 
			tabPage5.Location = new Point(4, 24);
			tabPage5.Name = "tabPage5";
			tabPage5.Padding = new Padding(3);
			tabPage5.Size = new Size(768, 398);
			tabPage5.TabIndex = 4;
			tabPage5.Text = "tabPage5";
			tabPage5.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(tabControl1);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "BETONOPOLEX";
			FormClosing += ng;
			Load += Form1_Load;
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private DataGridView dataGridView1;
		private TabPage tabPage2;
		private TabPage tabPage3;
		private GroupBox groupBox1;
		private Label label1;
		private TextBox textBox2;
		private TextBox textBox1;
		private Button button1;
		private Label label2;
		private TabPage tabPage4;
		private TabPage tabPage5;
		private GroupBox groupBox2;
		private DataGridView dataGridView2;
		private DataGridView dataGridView3;
	}
}
