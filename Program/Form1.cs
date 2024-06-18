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
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			bool connected = false;
			NpgsqlConnection connection = new NpgsqlConnection("Server =172.20.2.84; Port =5432;Database =BETONOPOLEX; User Id=" + login + ";Password=" + password);
			//while (!connected)
			//{
			try
			{
				connection.Open();
				connected = true;
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
			//}
			if (connected)
			{
				this.parent.Hide();
				NpgsqlCommand command = new NpgsqlCommand();
				command.Connection = connection;
				command.CommandType = System.Data.CommandType.Text;
				command.CommandText = "select * from owocki";
				NpgsqlDataReader reader = command.ExecuteReader();
				if (reader != null)
				{
					DataTable dt = new DataTable();
					dt.Load(reader);
					dataGridView1.DataSource = dt;
				}
				command.Dispose();
				connection.Close();
			}
			else 
			{
				this.Close();
			}
		}

		private void ng(object sender, FormClosingEventArgs e)
		{
			parent.Show();
		}
	}
}
