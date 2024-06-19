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
		public string nazwa_klienta;
		public string nip_klienta;
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
			components = new System.ComponentModel.Container();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			groupBox2 = new GroupBox();
			label3 = new Label();
			button2 = new Button();
			textBox3 = new TextBox();
			radioButton2 = new RadioButton();
			radioButton1 = new RadioButton();
			groupBox1 = new GroupBox();
			button1 = new Button();
			label2 = new Label();
			label1 = new Label();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			dataGridView1 = new DataGridView();
			tabPage2 = new TabPage();
			groupBox4 = new GroupBox();
			radioButton5 = new RadioButton();
			radioButton4 = new RadioButton();
			radioButton3 = new RadioButton();
			button4 = new Button();
			textBox6 = new TextBox();
			groupBox3 = new GroupBox();
			label5 = new Label();
			label4 = new Label();
			button3 = new Button();
			textBox5 = new TextBox();
			textBox4 = new TextBox();
			dataGridView2 = new DataGridView();
			tabPage3 = new TabPage();
			dataGridView3 = new DataGridView();
			tabPage4 = new TabPage();
			dataGridView4 = new DataGridView();
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			contextMenuStrip1 = new ContextMenuStrip(components);
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			tabPage2.SuspendLayout();
			groupBox4.SuspendLayout();
			groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
			tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
			tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Controls.Add(tabPage3);
			tabControl1.Controls.Add(tabPage4);
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
			groupBox2.Controls.Add(label3);
			groupBox2.Controls.Add(button2);
			groupBox2.Controls.Add(textBox3);
			groupBox2.Controls.Add(radioButton2);
			groupBox2.Controls.Add(radioButton1);
			groupBox2.Location = new Point(426, 135);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(336, 76);
			groupBox2.TabIndex = 2;
			groupBox2.TabStop = false;
			groupBox2.Text = "Usuń artykuł";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(6, 22);
			label3.Name = "label3";
			label3.Size = new Size(32, 15);
			label3.TabIndex = 4;
			label3.Text = "adsd";
			label3.Click += label3_Click;
			// 
			// button2
			// 
			button2.Location = new Point(255, 43);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 3;
			button2.Text = "Zatwierdź";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(6, 40);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(136, 23);
			textBox3.TabIndex = 2;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(255, 18);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(60, 19);
			radioButton2.TabIndex = 1;
			radioButton2.TabStop = true;
			radioButton2.Text = "Nazwa";
			radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Location = new Point(199, 18);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(36, 19);
			radioButton1.TabIndex = 0;
			radioButton1.TabStop = true;
			radioButton1.Text = "ID";
			radioButton1.UseVisualStyleBackColor = true;
			radioButton1.CheckedChanged += radioButton1_CheckedChanged;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(textBox2);
			groupBox1.Controls.Add(textBox1);
			groupBox1.Location = new Point(426, 6);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(336, 123);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Dodaj artykuł";
			// 
			// button1
			// 
			button1.Location = new Point(255, 94);
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
			// 
			// textBox1
			// 
			textBox1.Location = new Point(6, 41);
			textBox1.MaxLength = 85;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(205, 23);
			textBox1.TabIndex = 0;
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
			tabPage2.Controls.Add(groupBox4);
			tabPage2.Controls.Add(groupBox3);
			tabPage2.Controls.Add(dataGridView2);
			tabPage2.Location = new Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(768, 398);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Klienci";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(radioButton5);
			groupBox4.Controls.Add(radioButton4);
			groupBox4.Controls.Add(radioButton3);
			groupBox4.Controls.Add(button4);
			groupBox4.Controls.Add(textBox6);
			groupBox4.Location = new Point(402, 276);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(360, 116);
			groupBox4.TabIndex = 2;
			groupBox4.TabStop = false;
			groupBox4.Text = "Usuń klienta";
			// 
			// radioButton5
			// 
			radioButton5.AutoSize = true;
			radioButton5.Location = new Point(6, 56);
			radioButton5.Name = "radioButton5";
			radioButton5.Size = new Size(36, 19);
			radioButton5.TabIndex = 4;
			radioButton5.TabStop = true;
			radioButton5.Text = "ID";
			radioButton5.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			radioButton4.AutoSize = true;
			radioButton4.Location = new Point(98, 56);
			radioButton4.Name = "radioButton4";
			radioButton4.Size = new Size(60, 19);
			radioButton4.TabIndex = 3;
			radioButton4.TabStop = true;
			radioButton4.Text = "Nazwa";
			radioButton4.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			radioButton3.AutoSize = true;
			radioButton3.Location = new Point(48, 56);
			radioButton3.Name = "radioButton3";
			radioButton3.Size = new Size(44, 19);
			radioButton3.TabIndex = 2;
			radioButton3.TabStop = true;
			radioButton3.Text = "NIP";
			radioButton3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			button4.Location = new Point(279, 81);
			button4.Name = "button4";
			button4.Size = new Size(75, 23);
			button4.TabIndex = 1;
			button4.Text = "Zatwierdź";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// textBox6
			// 
			textBox6.Location = new Point(6, 81);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(267, 23);
			textBox6.TabIndex = 0;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(label5);
			groupBox3.Controls.Add(label4);
			groupBox3.Controls.Add(button3);
			groupBox3.Controls.Add(textBox5);
			groupBox3.Controls.Add(textBox4);
			groupBox3.Location = new Point(6, 276);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(360, 116);
			groupBox3.TabIndex = 1;
			groupBox3.TabStop = false;
			groupBox3.Text = "Dodaj klienta";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(6, 63);
			label5.Name = "label5";
			label5.Size = new Size(42, 15);
			label5.TabIndex = 4;
			label5.Text = "Nazwa";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(6, 19);
			label4.Name = "label4";
			label4.Size = new Size(26, 15);
			label4.TabIndex = 3;
			label4.Text = "NIP";
			// 
			// button3
			// 
			button3.Location = new Point(279, 80);
			button3.Name = "button3";
			button3.Size = new Size(75, 23);
			button3.TabIndex = 2;
			button3.Text = "Zatwierdź";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// textBox5
			// 
			textBox5.Location = new Point(6, 80);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(207, 23);
			textBox5.TabIndex = 1;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(6, 37);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(100, 23);
			textBox4.TabIndex = 0;
			// 
			// dataGridView2
			// 
			dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView2.Location = new Point(6, 6);
			dataGridView2.Name = "dataGridView2";
			dataGridView2.Size = new Size(756, 264);
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
			dataGridView3.Size = new Size(756, 232);
			dataGridView3.TabIndex = 0;
			// 
			// tabPage4
			// 
			tabPage4.Controls.Add(dataGridView4);
			tabPage4.Location = new Point(4, 24);
			tabPage4.Name = "tabPage4";
			tabPage4.Padding = new Padding(3);
			tabPage4.Size = new Size(768, 398);
			tabPage4.TabIndex = 3;
			tabPage4.Text = "Adresy";
			tabPage4.UseVisualStyleBackColor = true;
			// 
			// dataGridView4
			// 
			dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView4.Location = new Point(6, 6);
			dataGridView4.Name = "dataGridView4";
			dataGridView4.Size = new Size(756, 188);
			dataGridView4.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(61, 4);
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
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			tabPage2.ResumeLayout(false);
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
			tabPage4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
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
		private GroupBox groupBox2;
		private DataGridView dataGridView2;
		private DataGridView dataGridView3;
		private TextBox textBox3;
		private RadioButton radioButton2;
		private RadioButton radioButton1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private ContextMenuStrip contextMenuStrip1;
		private Label label3;
		private Button button2;
		private DataGridView dataGridView4;
		private GroupBox groupBox4;
		private GroupBox groupBox3;
		private RadioButton radioButton5;
		private RadioButton radioButton4;
		private RadioButton radioButton3;
		private Button button4;
		private TextBox textBox6;
		private Button button3;
		private TextBox textBox5;
		private TextBox textBox4;
		private Label label5;
		private Label label4;
	}
}
