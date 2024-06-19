using Npgsql;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Bazy
//			W ramach projektu oczekuj� od zespo��w bazy danych min 5 tabel z dwoma relacjami wiele do wielu oraz interfejs.

//			- nale�y zadba� o odpowiednie powi�zania pomi�dzy tabelami oraz na�o�y� niezb�dne ograniczenia https://www.postgresql.org/docs/13/ddl-constraints.html
//			+ powinna zawiera� widok(VIEW);
//			- powinna zawiera� w�asnor�cznie zdefiniowan� funkcj�(FUNCTION);
//			- powinna zawiera� wyzwalacz(TRIGGER);
//			Do bazy danych nale�y zaprojektowa� interfejs(np.w PHP lub dowolny inny j�zyk), kt�ry pozwoli na:
//			+ wy�wietlenie zawarto�ci poszczeg�lnych tabel(SELECT);
//			- dodawanie, usuwanie i edycj� rekord�w z wybranych tabel(INSERT, DELETE, UPDATE);
//			+ wy�wietlenie widoku;
//			- wywo�anie funkcji;
//			- uruchomienie wyzwalacza.
//			Nale�y r�wnie� zadba� o takie wype�nienie bazy danymi, �eby mo�liwe by�o prze�ledzenie jej dzia�ania.
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
			switch (table)
			{
				case "towary":
					this.command.Connection = connection;
					this.command.CommandType = System.Data.CommandType.Text;
					this.command.CommandText = "select * from wyswietl_towary";
					break;

				case "klienci":
					this.command.Connection = connection;
					this.command.CommandType = System.Data.CommandType.Text;
					this.command.CommandText = "select nr_klienta as \"Numer\", NIP_klienta as \"NIP\", nazwa_klienta as \"Nazwa\" from " + table;
					break;

				case "faktury":
					this.command.Connection = connection;
					this.command.CommandType = System.Data.CommandType.Text;
					this.command.CommandText = "select data_wystawienia as \"Data wystawienia\", cena_razem_bez_podatku as \"Cena netto\", podatek as \"Podatek\", cena_razem as \"Cena razem\", klienci_nr_klienta as \"Numer klienta\" from " + table;
					break;

				case "adresy":
					this.command.Connection = connection;
					this.command.CommandType = System.Data.CommandType.Text;
					this.command.CommandText = "select id_adresu as \"ID\", ulica as \"Ulica\", nr_domu as \"Nr domu\", nr_lokalu as \"Nr lokalu\", kod_pocztowy as \"Kod pocztowy\", miasto as \"Miasto\" from " + table;
					break;

				default:
					break;
			}
			NpgsqlDataReader reader = command.ExecuteReader();
			if (reader != null)
			{
				DataTable dt = new DataTable();
				dt.Load(reader);
				dataGrid.DataSource = dt;
			}
		}

		public void insert_towary()
		{
			try
			{
				this.opis_towaru = textBox1.Text;
				this.cena_towaru = Convert.ToInt32(textBox2.Text);
				this.command.CommandType = System.Data.CommandType.Text;
				this.command.CommandText = $"INSERT INTO towary (opis_towaru, cena_towaru) VALUES ('{this.opis_towaru}', {this.cena_towaru})";
				command.ExecuteNonQuery();
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		public void insert_klienci()
		{
			try
			{
				this.nazwa_klienta = textBox5.Text;
				this.nip_klienta = textBox4.Text;
				this.command.CommandType = System.Data.CommandType.Text;
				this.command.CommandText = $"INSERT INTO klienci (NIP_klienta, nazwa_klienta) VALUES ('{this.nip_klienta}', '{this.nazwa_klienta}')";
				command.ExecuteNonQuery();
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		public void delete_towary()
		{
			try
			{
				if (radioButton1.Checked)
				{
					this.command.CommandText = $"DELETE FROM towary WHERE id_towaru = {this.textBox3.Text}";
					command.ExecuteNonQuery();
				}
				if (radioButton2.Checked)
				{
					this.command.CommandText = $"DELETE FROM towary WHERE opis_towaru = '{this.textBox3.Text}'";
					command.ExecuteNonQuery();
				}
				this.command.CommandType = System.Data.CommandType.Text;

			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		public void delete_klienci()
		{
			try
			{
				if (radioButton5.Checked)
				{
					this.command.CommandText = $"DELETE FROM klienci WHERE nr_klienta = {this.textBox6.Text}";
					command.ExecuteNonQuery();
				}

				if (radioButton3.Checked)
				{
					this.command.CommandText = $"DELETE FROM klienci WHERE NIP_klienta = '{this.textBox6.Text}'";
					command.ExecuteNonQuery();
				}

				if (radioButton4.Checked)
				{
					this.command.CommandText = $"DELETE FROM klienci WHERE nazwa_klienta = '{this.textBox6.Text}'";
					command.ExecuteNonQuery();
				}
				this.command.CommandType = System.Data.CommandType.Text;
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		public void Form1_Load(object sender, EventArgs e)
		{
			if (connect_db(connection))
			{
				this.parent.Hide();
				this.Text = "BETONOPOLEX, zalogowany jako: " + login;
				update_table(dataGridView1, "towary");
				update_table(dataGridView2, "klienci");
				update_table(dataGridView3, "faktury");
				update_table(dataGridView4, "adresy");
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

		public void button1_Click(object sender, EventArgs e)
		{
			insert_towary();
			update_table(dataGridView1, "towary");
			textBox1.Text = "";
			textBox2.Text = "";
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			delete_towary();
			update_table(dataGridView1, "towary");
			textBox3.Text = "";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			insert_klienci();
			update_table(dataGridView2, "klienci");
			textBox4.Text = "";
			textBox5.Text = "";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			delete_klienci();
			update_table(dataGridView2, "klienci");
			textBox6.Text = "";
		}
	}
}
