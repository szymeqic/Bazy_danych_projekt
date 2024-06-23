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
			groupBox6 = new GroupBox();
			label11 = new Label();
			label10 = new Label();
			textBox11 = new TextBox();
			textBox10 = new TextBox();
			button6 = new Button();
			label9 = new Label();
			textBox9 = new TextBox();
			radioButton7 = new RadioButton();
			radioButton6 = new RadioButton();
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
			groupBox7 = new GroupBox();
			label14 = new Label();
			label13 = new Label();
			label12 = new Label();
			button7 = new Button();
			textBox14 = new TextBox();
			textBox13 = new TextBox();
			textBox12 = new TextBox();
			radioButton10 = new RadioButton();
			radioButton9 = new RadioButton();
			radioButton8 = new RadioButton();
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
			groupBox8 = new GroupBox();
			textBox15 = new TextBox();
			label15 = new Label();
			radioButton11 = new RadioButton();
			radioButton13 = new RadioButton();
			radioButton12 = new RadioButton();
			groupBox9 = new GroupBox();
			button8 = new Button();
			label19 = new Label();
			label18 = new Label();
			label17 = new Label();
			label16 = new Label();
			textBox18 = new TextBox();
			textBox17 = new TextBox();
			textBox16 = new TextBox();
			dateTimePicker1 = new DateTimePicker();
			dataGridView3 = new DataGridView();
			tabPage4 = new TabPage();
			groupBox10 = new GroupBox();
			dataGridView4 = new DataGridView();
			tabPage5 = new TabPage();
			groupBox5 = new GroupBox();
			button5 = new Button();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			textBox8 = new TextBox();
			textBox7 = new TextBox();
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			contextMenuStrip1 = new ContextMenuStrip(components);
			groupBox11 = new GroupBox();
			radioButton14 = new RadioButton();
			radioButton15 = new RadioButton();
			radioButton16 = new RadioButton();
			textBox19 = new TextBox();
			label20 = new Label();
			label21 = new Label();
			textBox20 = new TextBox();
			label22 = new Label();
			textBox21 = new TextBox();
			label23 = new Label();
			textBox22 = new TextBox();
			textBox23 = new TextBox();
			label24 = new Label();
			button9 = new Button();
			textBox24 = new TextBox();
			label25 = new Label();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			groupBox6.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			tabPage2.SuspendLayout();
			groupBox7.SuspendLayout();
			groupBox4.SuspendLayout();
			groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
			tabPage3.SuspendLayout();
			groupBox8.SuspendLayout();
			groupBox9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
			tabPage4.SuspendLayout();
			groupBox10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
			tabPage5.SuspendLayout();
			groupBox5.SuspendLayout();
			groupBox11.SuspendLayout();
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
			tabPage1.Controls.Add(groupBox6);
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
			// groupBox6
			// 
			groupBox6.Controls.Add(label11);
			groupBox6.Controls.Add(label10);
			groupBox6.Controls.Add(textBox11);
			groupBox6.Controls.Add(textBox10);
			groupBox6.Controls.Add(button6);
			groupBox6.Controls.Add(label9);
			groupBox6.Controls.Add(textBox9);
			groupBox6.Controls.Add(radioButton7);
			groupBox6.Controls.Add(radioButton6);
			groupBox6.Location = new Point(426, 217);
			groupBox6.Name = "groupBox6";
			groupBox6.Size = new Size(339, 175);
			groupBox6.TabIndex = 3;
			groupBox6.TabStop = false;
			groupBox6.Text = "Edytuj artykuł";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(6, 128);
			label11.Name = "label11";
			label11.Size = new Size(34, 15);
			label11.TabIndex = 8;
			label11.Text = "Cena";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(6, 84);
			label10.Name = "label10";
			label10.Size = new Size(31, 15);
			label10.TabIndex = 7;
			label10.Text = "Opis";
			// 
			// textBox11
			// 
			textBox11.Location = new Point(6, 146);
			textBox11.Name = "textBox11";
			textBox11.Size = new Size(73, 23);
			textBox11.TabIndex = 6;
			// 
			// textBox10
			// 
			textBox10.Location = new Point(6, 102);
			textBox10.Name = "textBox10";
			textBox10.Size = new Size(205, 23);
			textBox10.TabIndex = 5;
			// 
			// button6
			// 
			button6.Location = new Point(261, 146);
			button6.Name = "button6";
			button6.Size = new Size(75, 23);
			button6.TabIndex = 4;
			button6.Text = "Zatwierdź";
			button6.UseVisualStyleBackColor = true;
			button6.Click += button6_Click;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(6, 26);
			label9.Name = "label9";
			label9.Size = new Size(42, 15);
			label9.TabIndex = 3;
			label9.Text = "Wybór";
			// 
			// textBox9
			// 
			textBox9.Location = new Point(6, 44);
			textBox9.Name = "textBox9";
			textBox9.Size = new Size(136, 23);
			textBox9.TabIndex = 2;
			// 
			// radioButton7
			// 
			radioButton7.AutoSize = true;
			radioButton7.Location = new Point(258, 19);
			radioButton7.Name = "radioButton7";
			radioButton7.Size = new Size(60, 19);
			radioButton7.TabIndex = 1;
			radioButton7.TabStop = true;
			radioButton7.Text = "Nazwa";
			radioButton7.UseVisualStyleBackColor = true;
			// 
			// radioButton6
			// 
			radioButton6.AutoSize = true;
			radioButton6.Location = new Point(199, 19);
			radioButton6.Name = "radioButton6";
			radioButton6.Size = new Size(36, 19);
			radioButton6.TabIndex = 0;
			radioButton6.TabStop = true;
			radioButton6.Text = "ID";
			radioButton6.UseVisualStyleBackColor = true;
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
			label3.Location = new Point(6, 19);
			label3.Name = "label3";
			label3.Size = new Size(42, 15);
			label3.TabIndex = 4;
			label3.Text = "Wybór";
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
			tabPage2.Controls.Add(groupBox7);
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
			// groupBox7
			// 
			groupBox7.Controls.Add(label14);
			groupBox7.Controls.Add(label13);
			groupBox7.Controls.Add(label12);
			groupBox7.Controls.Add(button7);
			groupBox7.Controls.Add(textBox14);
			groupBox7.Controls.Add(textBox13);
			groupBox7.Controls.Add(textBox12);
			groupBox7.Controls.Add(radioButton10);
			groupBox7.Controls.Add(radioButton9);
			groupBox7.Controls.Add(radioButton8);
			groupBox7.Location = new Point(437, 214);
			groupBox7.Name = "groupBox7";
			groupBox7.Size = new Size(325, 178);
			groupBox7.TabIndex = 3;
			groupBox7.TabStop = false;
			groupBox7.Text = "Edytuj klienta";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(6, 133);
			label14.Name = "label14";
			label14.Size = new Size(42, 15);
			label14.TabIndex = 9;
			label14.Text = "Nazwa";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(6, 89);
			label13.Name = "label13";
			label13.Size = new Size(26, 15);
			label13.TabIndex = 8;
			label13.Text = "NIP";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(6, 45);
			label12.Name = "label12";
			label12.Size = new Size(42, 15);
			label12.TabIndex = 7;
			label12.Text = "Wybór";
			// 
			// button7
			// 
			button7.Location = new Point(244, 148);
			button7.Name = "button7";
			button7.Size = new Size(75, 23);
			button7.TabIndex = 6;
			button7.Text = "Zatwierdź";
			button7.UseVisualStyleBackColor = true;
			button7.Click += button7_Click;
			// 
			// textBox14
			// 
			textBox14.Location = new Point(6, 151);
			textBox14.Name = "textBox14";
			textBox14.Size = new Size(207, 23);
			textBox14.TabIndex = 5;
			// 
			// textBox13
			// 
			textBox13.Location = new Point(6, 107);
			textBox13.Name = "textBox13";
			textBox13.Size = new Size(100, 23);
			textBox13.TabIndex = 4;
			// 
			// textBox12
			// 
			textBox12.Location = new Point(6, 63);
			textBox12.Name = "textBox12";
			textBox12.Size = new Size(182, 23);
			textBox12.TabIndex = 3;
			// 
			// radioButton10
			// 
			radioButton10.AutoSize = true;
			radioButton10.Location = new Point(98, 22);
			radioButton10.Name = "radioButton10";
			radioButton10.Size = new Size(60, 19);
			radioButton10.TabIndex = 2;
			radioButton10.TabStop = true;
			radioButton10.Text = "Nazwa";
			radioButton10.UseVisualStyleBackColor = true;
			// 
			// radioButton9
			// 
			radioButton9.AutoSize = true;
			radioButton9.Location = new Point(48, 22);
			radioButton9.Name = "radioButton9";
			radioButton9.Size = new Size(44, 19);
			radioButton9.TabIndex = 1;
			radioButton9.TabStop = true;
			radioButton9.Text = "NIP";
			radioButton9.UseVisualStyleBackColor = true;
			// 
			// radioButton8
			// 
			radioButton8.AutoSize = true;
			radioButton8.Location = new Point(6, 22);
			radioButton8.Name = "radioButton8";
			radioButton8.Size = new Size(36, 19);
			radioButton8.TabIndex = 0;
			radioButton8.TabStop = true;
			radioButton8.Text = "ID";
			radioButton8.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(radioButton5);
			groupBox4.Controls.Add(radioButton4);
			groupBox4.Controls.Add(radioButton3);
			groupBox4.Controls.Add(button4);
			groupBox4.Controls.Add(textBox6);
			groupBox4.Location = new Point(437, 128);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(325, 80);
			groupBox4.TabIndex = 2;
			groupBox4.TabStop = false;
			groupBox4.Text = "Usuń klienta";
			// 
			// radioButton5
			// 
			radioButton5.AutoSize = true;
			radioButton5.Location = new Point(6, 22);
			radioButton5.Name = "radioButton5";
			radioButton5.Size = new Size(36, 19);
			radioButton5.TabIndex = 4;
			radioButton5.TabStop = true;
			radioButton5.Text = "ID";
			radioButton5.UseVisualStyleBackColor = true;
			radioButton5.CheckedChanged += radioButton5_CheckedChanged;
			// 
			// radioButton4
			// 
			radioButton4.AutoSize = true;
			radioButton4.Location = new Point(98, 22);
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
			radioButton3.Location = new Point(48, 22);
			radioButton3.Name = "radioButton3";
			radioButton3.Size = new Size(44, 19);
			radioButton3.TabIndex = 2;
			radioButton3.TabStop = true;
			radioButton3.Text = "NIP";
			radioButton3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			button4.Location = new Point(244, 51);
			button4.Name = "button4";
			button4.Size = new Size(75, 23);
			button4.TabIndex = 1;
			button4.Text = "Zatwierdź";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// textBox6
			// 
			textBox6.Location = new Point(6, 51);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(182, 23);
			textBox6.TabIndex = 0;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(label5);
			groupBox3.Controls.Add(label4);
			groupBox3.Controls.Add(button3);
			groupBox3.Controls.Add(textBox5);
			groupBox3.Controls.Add(textBox4);
			groupBox3.Location = new Point(437, 6);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(325, 116);
			groupBox3.TabIndex = 1;
			groupBox3.TabStop = false;
			groupBox3.Text = "Dodaj klienta";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(6, 69);
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
			button3.Location = new Point(244, 87);
			button3.Name = "button3";
			button3.Size = new Size(75, 23);
			button3.TabIndex = 2;
			button3.Text = "Zatwierdź";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// textBox5
			// 
			textBox5.Location = new Point(6, 87);
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
			dataGridView2.Size = new Size(425, 386);
			dataGridView2.TabIndex = 0;
			// 
			// tabPage3
			// 
			tabPage3.Controls.Add(groupBox8);
			tabPage3.Controls.Add(groupBox9);
			tabPage3.Controls.Add(dataGridView3);
			tabPage3.Location = new Point(4, 24);
			tabPage3.Name = "tabPage3";
			tabPage3.Padding = new Padding(3);
			tabPage3.Size = new Size(768, 398);
			tabPage3.TabIndex = 2;
			tabPage3.Text = "Faktury";
			tabPage3.UseVisualStyleBackColor = true;
			// 
			// groupBox8
			// 
			groupBox8.Controls.Add(textBox15);
			groupBox8.Controls.Add(label15);
			groupBox8.Controls.Add(radioButton11);
			groupBox8.Controls.Add(radioButton13);
			groupBox8.Controls.Add(radioButton12);
			groupBox8.Location = new Point(499, 283);
			groupBox8.Name = "groupBox8";
			groupBox8.Size = new Size(263, 112);
			groupBox8.TabIndex = 12;
			groupBox8.TabStop = false;
			groupBox8.Text = "Akcja";
			// 
			// textBox15
			// 
			textBox15.Location = new Point(173, 80);
			textBox15.Name = "textBox15";
			textBox15.Size = new Size(84, 23);
			textBox15.TabIndex = 0;
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(173, 62);
			label15.Name = "label15";
			label15.Size = new Size(18, 15);
			label15.TabIndex = 1;
			label15.Text = "ID";
			// 
			// radioButton11
			// 
			radioButton11.AutoSize = true;
			radioButton11.Location = new Point(6, 32);
			radioButton11.Name = "radioButton11";
			radioButton11.Size = new Size(56, 19);
			radioButton11.TabIndex = 9;
			radioButton11.TabStop = true;
			radioButton11.Text = "Dodaj";
			radioButton11.UseVisualStyleBackColor = true;
			// 
			// radioButton13
			// 
			radioButton13.AutoSize = true;
			radioButton13.Location = new Point(6, 82);
			radioButton13.Name = "radioButton13";
			radioButton13.Size = new Size(52, 19);
			radioButton13.TabIndex = 11;
			radioButton13.TabStop = true;
			radioButton13.Text = "Usuń";
			radioButton13.UseVisualStyleBackColor = true;
			// 
			// radioButton12
			// 
			radioButton12.AutoSize = true;
			radioButton12.Location = new Point(6, 57);
			radioButton12.Name = "radioButton12";
			radioButton12.Size = new Size(58, 19);
			radioButton12.TabIndex = 10;
			radioButton12.TabStop = true;
			radioButton12.Text = "Edytuj";
			radioButton12.UseVisualStyleBackColor = true;
			// 
			// groupBox9
			// 
			groupBox9.Controls.Add(button8);
			groupBox9.Controls.Add(label19);
			groupBox9.Controls.Add(label18);
			groupBox9.Controls.Add(label17);
			groupBox9.Controls.Add(label16);
			groupBox9.Controls.Add(textBox18);
			groupBox9.Controls.Add(textBox17);
			groupBox9.Controls.Add(textBox16);
			groupBox9.Controls.Add(dateTimePicker1);
			groupBox9.Location = new Point(6, 283);
			groupBox9.Name = "groupBox9";
			groupBox9.Size = new Size(487, 112);
			groupBox9.TabIndex = 2;
			groupBox9.TabStop = false;
			groupBox9.Text = "Wprowadź dane";
			// 
			// button8
			// 
			button8.Location = new Point(406, 82);
			button8.Name = "button8";
			button8.Size = new Size(75, 23);
			button8.TabIndex = 8;
			button8.Text = "Zatwierdź";
			button8.UseVisualStyleBackColor = true;
			button8.Click += button8_Click;
			// 
			// label19
			// 
			label19.AutoSize = true;
			label19.Location = new Point(220, 65);
			label19.Name = "label19";
			label19.Size = new Size(82, 15);
			label19.TabIndex = 7;
			label19.Text = "Numer klienta";
			// 
			// label18
			// 
			label18.AutoSize = true;
			label18.Location = new Point(114, 65);
			label18.Name = "label18";
			label18.Size = new Size(50, 15);
			label18.TabIndex = 6;
			label18.Text = "Podatek";
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Location = new Point(6, 65);
			label17.Name = "label17";
			label17.Size = new Size(102, 15);
			label17.TabIndex = 5;
			label17.Text = "Cena bez podatku";
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Location = new Point(6, 19);
			label16.Name = "label16";
			label16.Size = new Size(31, 15);
			label16.TabIndex = 4;
			label16.Text = "Data";
			// 
			// textBox18
			// 
			textBox18.Location = new Point(220, 83);
			textBox18.Name = "textBox18";
			textBox18.Size = new Size(100, 23);
			textBox18.TabIndex = 3;
			// 
			// textBox17
			// 
			textBox17.Location = new Point(114, 83);
			textBox17.Name = "textBox17";
			textBox17.Size = new Size(100, 23);
			textBox17.TabIndex = 2;
			// 
			// textBox16
			// 
			textBox16.Location = new Point(6, 83);
			textBox16.Name = "textBox16";
			textBox16.Size = new Size(100, 23);
			textBox16.TabIndex = 1;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(6, 37);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(208, 23);
			dateTimePicker1.TabIndex = 0;
			dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
			// 
			// dataGridView3
			// 
			dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView3.Location = new Point(6, 6);
			dataGridView3.Name = "dataGridView3";
			dataGridView3.Size = new Size(756, 271);
			dataGridView3.TabIndex = 0;
			// 
			// tabPage4
			// 
			tabPage4.Controls.Add(groupBox11);
			tabPage4.Controls.Add(groupBox10);
			tabPage4.Controls.Add(dataGridView4);
			tabPage4.Location = new Point(4, 24);
			tabPage4.Name = "tabPage4";
			tabPage4.Padding = new Padding(3);
			tabPage4.Size = new Size(768, 398);
			tabPage4.TabIndex = 3;
			tabPage4.Text = "Adresy";
			tabPage4.UseVisualStyleBackColor = true;
			// 
			// groupBox10
			// 
			groupBox10.Controls.Add(button9);
			groupBox10.Controls.Add(label24);
			groupBox10.Controls.Add(textBox23);
			groupBox10.Controls.Add(textBox22);
			groupBox10.Controls.Add(label23);
			groupBox10.Controls.Add(textBox21);
			groupBox10.Controls.Add(label22);
			groupBox10.Controls.Add(textBox20);
			groupBox10.Controls.Add(label21);
			groupBox10.Controls.Add(label20);
			groupBox10.Controls.Add(textBox19);
			groupBox10.Location = new Point(6, 291);
			groupBox10.Name = "groupBox10";
			groupBox10.Size = new Size(489, 104);
			groupBox10.TabIndex = 1;
			groupBox10.TabStop = false;
			groupBox10.Text = "Wprowadź dane";
			// 
			// dataGridView4
			// 
			dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView4.Location = new Point(6, 6);
			dataGridView4.Name = "dataGridView4";
			dataGridView4.Size = new Size(756, 279);
			dataGridView4.TabIndex = 0;
			// 
			// tabPage5
			// 
			tabPage5.Controls.Add(groupBox5);
			tabPage5.Location = new Point(4, 24);
			tabPage5.Name = "tabPage5";
			tabPage5.Padding = new Padding(3);
			tabPage5.Size = new Size(768, 398);
			tabPage5.TabIndex = 4;
			tabPage5.Text = "Narzędzia";
			tabPage5.UseVisualStyleBackColor = true;
			// 
			// groupBox5
			// 
			groupBox5.Controls.Add(button5);
			groupBox5.Controls.Add(label8);
			groupBox5.Controls.Add(label7);
			groupBox5.Controls.Add(label6);
			groupBox5.Controls.Add(textBox8);
			groupBox5.Controls.Add(textBox7);
			groupBox5.Location = new Point(6, 6);
			groupBox5.Name = "groupBox5";
			groupBox5.Size = new Size(199, 184);
			groupBox5.TabIndex = 0;
			groupBox5.TabStop = false;
			groupBox5.Text = "Oblicz pole";
			// 
			// button5
			// 
			button5.Location = new Point(118, 155);
			button5.Name = "button5";
			button5.Size = new Size(75, 23);
			button5.TabIndex = 5;
			button5.Text = "Oblicz";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(6, 155);
			label8.Name = "label8";
			label8.Size = new Size(40, 15);
			label8.TabIndex = 4;
			label8.Text = "Wynik";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(6, 86);
			label7.Name = "label7";
			label7.Size = new Size(37, 15);
			label7.TabIndex = 3;
			label7.Text = "Bok B";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(6, 28);
			label6.Name = "label6";
			label6.Size = new Size(38, 15);
			label6.TabIndex = 2;
			label6.Text = "Bok A";
			label6.Click += label6_Click;
			// 
			// textBox8
			// 
			textBox8.Location = new Point(6, 104);
			textBox8.Name = "textBox8";
			textBox8.Size = new Size(100, 23);
			textBox8.TabIndex = 1;
			// 
			// textBox7
			// 
			textBox7.Location = new Point(6, 46);
			textBox7.Name = "textBox7";
			textBox7.Size = new Size(100, 23);
			textBox7.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(61, 4);
			// 
			// groupBox11
			// 
			groupBox11.Controls.Add(label25);
			groupBox11.Controls.Add(textBox24);
			groupBox11.Controls.Add(radioButton16);
			groupBox11.Controls.Add(radioButton15);
			groupBox11.Controls.Add(radioButton14);
			groupBox11.Location = new Point(501, 291);
			groupBox11.Name = "groupBox11";
			groupBox11.Size = new Size(261, 104);
			groupBox11.TabIndex = 2;
			groupBox11.TabStop = false;
			groupBox11.Text = "Akcja";
			// 
			// radioButton14
			// 
			radioButton14.AutoSize = true;
			radioButton14.Location = new Point(7, 22);
			radioButton14.Name = "radioButton14";
			radioButton14.Size = new Size(56, 19);
			radioButton14.TabIndex = 0;
			radioButton14.TabStop = true;
			radioButton14.Text = "Dodaj";
			radioButton14.UseVisualStyleBackColor = true;
			// 
			// radioButton15
			// 
			radioButton15.AutoSize = true;
			radioButton15.Location = new Point(7, 47);
			radioButton15.Name = "radioButton15";
			radioButton15.Size = new Size(58, 19);
			radioButton15.TabIndex = 1;
			radioButton15.TabStop = true;
			radioButton15.Text = "Edytuj";
			radioButton15.UseVisualStyleBackColor = true;
			// 
			// radioButton16
			// 
			radioButton16.AutoSize = true;
			radioButton16.Location = new Point(7, 72);
			radioButton16.Name = "radioButton16";
			radioButton16.Size = new Size(52, 19);
			radioButton16.TabIndex = 2;
			radioButton16.TabStop = true;
			radioButton16.Text = "Usuń";
			radioButton16.UseVisualStyleBackColor = true;
			// 
			// textBox19
			// 
			textBox19.Location = new Point(6, 37);
			textBox19.Name = "textBox19";
			textBox19.Size = new Size(100, 23);
			textBox19.TabIndex = 0;
			// 
			// label20
			// 
			label20.AutoSize = true;
			label20.Location = new Point(6, 19);
			label20.Name = "label20";
			label20.Size = new Size(33, 15);
			label20.TabIndex = 1;
			label20.Text = "Ulica";
			// 
			// label21
			// 
			label21.AutoSize = true;
			label21.Location = new Point(112, 19);
			label21.Name = "label21";
			label21.Size = new Size(55, 15);
			label21.TabIndex = 2;
			label21.Text = "Nr domu";
			// 
			// textBox20
			// 
			textBox20.Location = new Point(112, 37);
			textBox20.Name = "textBox20";
			textBox20.Size = new Size(55, 23);
			textBox20.TabIndex = 3;
			// 
			// label22
			// 
			label22.AutoSize = true;
			label22.Location = new Point(173, 19);
			label22.Name = "label22";
			label22.Size = new Size(55, 15);
			label22.TabIndex = 4;
			label22.Text = "Nr lokalu";
			// 
			// textBox21
			// 
			textBox21.Location = new Point(173, 37);
			textBox21.Name = "textBox21";
			textBox21.Size = new Size(55, 23);
			textBox21.TabIndex = 5;
			// 
			// label23
			// 
			label23.AutoSize = true;
			label23.Location = new Point(234, 19);
			label23.Name = "label23";
			label23.Size = new Size(82, 15);
			label23.TabIndex = 6;
			label23.Text = "Kod pocztowy";
			// 
			// textBox22
			// 
			textBox22.Location = new Point(234, 37);
			textBox22.Name = "textBox22";
			textBox22.Size = new Size(82, 23);
			textBox22.TabIndex = 7;
			// 
			// textBox23
			// 
			textBox23.Location = new Point(322, 37);
			textBox23.Name = "textBox23";
			textBox23.Size = new Size(161, 23);
			textBox23.TabIndex = 8;
			// 
			// label24
			// 
			label24.AutoSize = true;
			label24.Location = new Point(322, 19);
			label24.Name = "label24";
			label24.Size = new Size(43, 15);
			label24.TabIndex = 9;
			label24.Text = "Miasto";
			// 
			// button9
			// 
			button9.Location = new Point(408, 75);
			button9.Name = "button9";
			button9.Size = new Size(75, 23);
			button9.TabIndex = 10;
			button9.Text = "Zatwierdź";
			button9.UseVisualStyleBackColor = true;
			button9.Click += button9_Click;
			// 
			// textBox24
			// 
			textBox24.Location = new Point(166, 72);
			textBox24.Name = "textBox24";
			textBox24.Size = new Size(89, 23);
			textBox24.TabIndex = 3;
			// 
			// label25
			// 
			label25.AutoSize = true;
			label25.Location = new Point(166, 54);
			label25.Name = "label25";
			label25.Size = new Size(18, 15);
			label25.TabIndex = 4;
			label25.Text = "ID";
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
			groupBox6.ResumeLayout(false);
			groupBox6.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			tabPage2.ResumeLayout(false);
			groupBox7.ResumeLayout(false);
			groupBox7.PerformLayout();
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			tabPage3.ResumeLayout(false);
			groupBox8.ResumeLayout(false);
			groupBox8.PerformLayout();
			groupBox9.ResumeLayout(false);
			groupBox9.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
			tabPage4.ResumeLayout(false);
			groupBox10.ResumeLayout(false);
			groupBox10.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
			tabPage5.ResumeLayout(false);
			groupBox5.ResumeLayout(false);
			groupBox5.PerformLayout();
			groupBox11.ResumeLayout(false);
			groupBox11.PerformLayout();
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
		private TabPage tabPage5;
		private GroupBox groupBox5;
		private Label label6;
		private TextBox textBox8;
		private TextBox textBox7;
		private Button button5;
		private Label label8;
		private Label label7;
		private GroupBox groupBox6;
		private Label label11;
		private Label label10;
		private TextBox textBox11;
		private TextBox textBox10;
		private Button button6;
		private Label label9;
		private TextBox textBox9;
		private RadioButton radioButton7;
		private RadioButton radioButton6;
		private GroupBox groupBox7;
		private RadioButton radioButton8;
		private Label label14;
		private Label label13;
		private Label label12;
		private Button button7;
		private TextBox textBox14;
		private TextBox textBox13;
		private TextBox textBox12;
		private RadioButton radioButton10;
		private RadioButton radioButton9;
		private GroupBox groupBox9;
		private Label label15;
		private TextBox textBox15;
		private TextBox textBox18;
		private TextBox textBox17;
		private TextBox textBox16;
		private DateTimePicker dateTimePicker1;
		private Button button8;
		private Label label19;
		private Label label18;
		private Label label17;
		private Label label16;
		private RadioButton radioButton13;
		private RadioButton radioButton12;
		private RadioButton radioButton11;
		private GroupBox groupBox8;
		private GroupBox groupBox10;
		private GroupBox groupBox11;
		private RadioButton radioButton16;
		private RadioButton radioButton15;
		private RadioButton radioButton14;
		private TextBox textBox20;
		private Label label21;
		private Label label20;
		private TextBox textBox19;
		private Label label25;
		private TextBox textBox24;
		private Button button9;
		private Label label24;
		private TextBox textBox23;
		private TextBox textBox22;
		private Label label23;
		private TextBox textBox21;
		private Label label22;
	}
}
