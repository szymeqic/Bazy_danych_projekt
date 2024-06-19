namespace Bazy
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox1 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			textBox2 = new TextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(12, 25);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(172, 23);
			textBox1.TabIndex = 0;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 7);
			label1.Name = "label1";
			label1.Size = new Size(68, 15);
			label1.TabIndex = 1;
			label1.Text = "Użytkownik";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 51);
			label2.Name = "label2";
			label2.Size = new Size(37, 15);
			label2.TabIndex = 2;
			label2.Text = "Hasło";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(12, 69);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(172, 23);
			textBox2.TabIndex = 3;
			textBox2.UseSystemPasswordChar = true;
			// 
			// button1
			// 
			button1.Location = new Point(240, 69);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 4;
			button1.Text = "Zaloguj";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(327, 105);
			Controls.Add(button1);
			Controls.Add(textBox2);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox1);
			Name = "Form2";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "BETONOPOLEX Logowanie";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Label label1;
		private Label label2;
		private TextBox textBox2;
		private Button button1;
	}
}