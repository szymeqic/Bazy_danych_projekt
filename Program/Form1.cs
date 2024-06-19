using Npgsql;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
namespace Bazy

{
	public partial class Form1 : Form
	{
		public Form1(string login, string password, Form2 parent)
		{ // 
			InitializeComponent();
			this.login = login;
			this.password = password;
			this.parent = parent;
			this.connection = new NpgsqlConnection("Server =172.20.2.84; Port =5432;Database =BETONOPOLEX; User Id=" + login + ";Password=" + password);
			this.command = new NpgsqlCommand();
		}

		private bool connect_db(NpgsqlConnection connection)
		{
			bool connected = false;
			try
			{
				this.connection.Open();
				connected = true;
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
			return connected;
		}

		private void update_table(DataGridView dataGrid, string table)
		{
			this.command.Connection = connection;
			this.command.CommandType = System.Data.CommandType.Text;
			this.command.CommandText = "select * from " + table;
			NpgsqlDataReader reader = command.ExecuteReader();
			if (reader != null)
			{
				DataTable dt = new DataTable();
				dt.Load(reader);
				dataGrid.DataSource = dt;
			}
		}

		private void insert_towary()
		{
			this.command.CommandType = System.Data.CommandType.Text;
			this.command.CommandText = $"INSERT INTO towary (opis_towaru, cena_towaru) VALUES (@opis_towaru, @cena_towaru)";
			this.command.Parameters.AddWithValue("opis_towaru", this.opis_towaru);
			this.command.Parameters.AddWithValue("cena_towaru", this.cena_towaru);
			command.ExecuteNonQuery();
		}

		private void text_towary(object sender, EventArgs e)
		{
			if (this.textBox2.Text != "")
			{
				this.cena_towaru = Convert.ToInt32(textBox2.Text);
			}
			if (this.textBox1.Text != "")
			{
				this.opis_towaru = textBox1.Text;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			if (connect_db(connection))
			{
				this.parent.Hide();
				this.Text = "BETONOPOLEX, zalogowany jako: " + login;
				update_table(dataGridView1, "towary");
				update_table(dataGridView2, "klienci");
				update_table(dataGridView3, "faktury");
			}
			else
			{
				this.command.Dispose();
				this.connection.Close();
				this.Close();
			}
		}

		private void ng(object sender, FormClosingEventArgs e)
		{
			parent.Show();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			insert_towary();
			update_table(dataGridView1, "towary");
		}
	}
}
