using Npgsql;
using System.Data;
namespace Bazy

{
	public partial class Form1 : Form
	{
		public Form1(string login, string password)
		{ // 
			InitializeComponent();
			this.login = login;
			this.password = password;
			NpgsqlConnection connection = new NpgsqlConnection("Server =172.20.2.84; Port =5432;Database =BETONOPOLEX; User Id =jsiciar; Password =maslo");
			connection.Open();
			NpgsqlCommand command = new NpgsqlCommand();
			command.Connection = connection;
			command.CommandType = System.Data.CommandType.Text;
			command.CommandText = "select * from owocki";
			NpgsqlDataReader reader = command.ExecuteReader();
			if (reader != null )
			{
				DataTable dt = new DataTable();
				dt.Load( reader );
				dataGridView1.DataSource = dt;
			}
			command.Dispose();
			connection.Close();
		}
	}
}
