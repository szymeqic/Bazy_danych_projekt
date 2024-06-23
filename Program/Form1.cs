using Npgsql;
using System.Collections.Generic;
using System.Data;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;
namespace Bazy
//			W ramach projektu oczekujê od zespo³ów bazy danych min 5 tabel z dwoma relacjami wiele do wielu oraz interfejs.

//			- nale¿y zadbaæ o odpowiednie powi¹zania pomiêdzy tabelami oraz na³o¿yæ niezbêdne ograniczenia https://www.postgresql.org/docs/13/ddl-constraints.html
//			+ powinna zawieraæ widok(VIEW);
//			+ powinna zawieraæ w³asnorêcznie zdefiniowan¹ funkcjê(FUNCTION);
//			+ powinna zawieraæ wyzwalacz(TRIGGER);
//			Do bazy danych nale¿y zaprojektowaæ interfejs(np.w PHP lub dowolny inny jêzyk), który pozwoli na:
//			+ wyœwietlenie zawartoœci poszczególnych tabel(SELECT);
//			+ dodawanie, usuwanie i edycjê rekordów z wybranych tabel(INSERT, DELETE, UPDATE);
//			+ wyœwietlenie widoku;
//			+ wywo³anie funkcji;
//			+ uruchomienie wyzwalacza.
//			Nale¿y równie¿ zadbaæ o takie wype³nienie bazy danymi, ¿eby mo¿liwe by³o przeœledzenie jej dzia³ania.
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
					this.command.CommandText = "select data_wystawienia as \"Data wystawienia\", id_faktury as \"ID\", cena_razem_bez_podatku as \"Cena netto\", podatek as \"Podatek\", cena_razem as \"Cena razem\", klienci_nr_klienta as \"Numer klienta\" from " + table;
					break;

				case "adresy":
					this.command.Connection = connection;
					this.command.CommandType = System.Data.CommandType.Text;
					this.command.CommandText = "select id_adresu as \"ID\", ulica as \"Ulica\", nr_domu as \"Nr domu\", nr_lokalu as \"Nr lokalu\", kod_pocztowy as \"Kod pocztowy\", miasto as \"Miasto\" from " + table;
					break;

				case "faktura_towary":
					this.command.Connection = connection;
					this.command.CommandType = System.Data.CommandType.Text;
					this.command.CommandText = "select id_faktury as \"ID faktury\", id_towaru as \"ID towaru\", ilosc_towaru as \"Iloœæ towaru\", cena_laczna_towaru as \"£¹czna cena towaru\" from " + table;
					break;

				case "adresy_klientow":
					this.command.Connection = connection;
					this.command.CommandType = System.Data.CommandType.Text;
					this.command.CommandText = "select klienci_nr_klienta as \"Numer klienta\", adresy_id_adresu as \"ID adresu\", status as \"Status\" from " + table;
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
				this.command.CommandText = $"SELECT MAX (nr_klienta) FROM klienci";
				command.Parameters.Add(new NpgsqlParameter("p_out", DbType.String) { Direction = ParameterDirection.Output });
				command.ExecuteNonQuery();
				string temp = Convert.ToString(command.Parameters[0].Value);
				this.command.CommandText = $"INSERT INTO adresy_klientow (klienci_nr_klienta) VALUES ({temp})";
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

		public void update_towary()
		{
			try
			{
				if (radioButton6.Checked)
				{
					this.command.CommandText = $"UPDATE towary SET opis_towaru = '{this.textBox10.Text}', cena_towaru = {this.textBox11.Text} WHERE id_towaru = {this.textBox9.Text}";
					command.ExecuteNonQuery();
				}
				if (radioButton7.Checked)
				{
					this.command.CommandText = $"UPDATE towary SET opis_towaru = '{this.textBox10.Text}', cena_towaru = {this.textBox11.Text} WHERE opis_towaru = '{this.textBox9.Text}'";
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

		public void update_klienci()
		{
			try
			{
				if (radioButton8.Checked)
				{
					this.command.CommandText = $"UPDATE klienci SET nazwa_klienta = '{textBox14.Text}', NIP_klienta = '{textBox13.Text}' WHERE nr_klienta = {this.textBox12.Text}";
					command.ExecuteNonQuery();
				}

				if (radioButton9.Checked)
				{
					this.command.CommandText = $"UPDATE klienci SET nazwa_klienta = '{textBox14.Text}', NIP_klienta = '{textBox13.Text}' WHERE NIP_klienta = '{this.textBox12.Text}'";
					command.ExecuteNonQuery();
				}

				if (radioButton10.Checked)
				{
					this.command.CommandText = $"UPDATE klienci SET nazwa_klienta = '{textBox14.Text}', NIP_klienta = '{textBox13.Text}' WHERE nazwa_klienta = '{this.textBox12.Text}'";
					command.ExecuteNonQuery();
				}
				this.command.CommandType = System.Data.CommandType.Text;
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		public void insert_faktury()
		{
			try
			{
				this.command.CommandType = System.Data.CommandType.Text;
				this.command.CommandText = $"INSERT INTO faktury (data_wystawienia, cena_razem_bez_podatku, podatek, klienci_nr_klienta) VALUES ('{dateTimePicker1.Value.ToString("yyyy-MM-dd")}', {textBox16.Text}, {textBox17.Text}, {textBox18.Text})";
				command.ExecuteNonQuery();
				this.command.CommandText = $"SELECT MAX (id_faktury) FROM faktury";
				command.Parameters.Add(new NpgsqlParameter("p_out", DbType.String) { Direction = ParameterDirection.Output });
				command.ExecuteNonQuery();
				string temp = Convert.ToString(command.Parameters[0].Value);
				MessageBox.Show(temp);
				command.CommandText = $"INSERT INTO faktura_towary (id_faktury) VALUES ({temp})";
				command.ExecuteNonQuery();
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		public void update_faktury()
		{
			try
			{
				this.command.CommandText = $"UPDATE faktury SET data_wystawienia = '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}', cena_razem_bez_podatku = '{textBox16.Text}', podatek = {textBox17.Text}, klienci_nr_klienta = {textBox18.Text} WHERE id_faktury = {this.textBox15.Text}";
				command.ExecuteNonQuery();
				this.command.CommandType = System.Data.CommandType.Text;
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		public void delete_faktury()
		{
			try
			{
				this.command.CommandText = $"DELETE FROM faktury WHERE id_faktury = {this.textBox15.Text}";
				command.ExecuteNonQuery();
				this.command.CommandType = System.Data.CommandType.Text;
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		public void insert_adresy()
		{
			try
			{
				this.command.CommandType = System.Data.CommandType.Text;
				this.command.CommandText = $"INSERT INTO adresy (ulica, nr_domu, nr_lokalu, kod_pocztowy, miasto) VALUES ('{textBox19.Text}', '{textBox20.Text}', '{textBox21.Text}', '{textBox22.Text}', '{textBox23.Text}')";
				command.ExecuteNonQuery();
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		public void update_adresy()
		{
			try
			{
				this.command.CommandText = $"UPDATE adresy SET ulica = '{textBox19.Text}', nr_domu = '{textBox20.Text}', nr_lokalu = '{textBox21.Text}', kod_pocztowy = '{textBox22.Text}', miasto = '{textBox23.Text}' WHERE id_adresu = {textBox24.Text}";
				command.ExecuteNonQuery();
				this.command.CommandType = System.Data.CommandType.Text;
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		public void delete_adresy()
		{
			try
			{
				this.command.CommandText = $"DELETE FROM adresy WHERE id_adresu = {textBox24.Text}";
				command.ExecuteNonQuery();
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
				update_table(dataGridView5, "faktura_towary");
				update_table(dataGridView6, "adresy_klientow");
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

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.command.CommandText = $"SELECT oblicz_powierzchnie({this.textBox7.Text}, {this.textBox8.Text})";
			command.Parameters.Add(new NpgsqlParameter("p_out", DbType.String) { Direction = ParameterDirection.Output });
			command.ExecuteNonQuery();
			this.label8.Text = "Pole = " + Convert.ToString(command.Parameters[0].Value);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			update_towary();
			update_table(dataGridView1, "towary");
			textBox9.Text = "";
			textBox10.Text = "";
			textBox11.Text = "";

		}

		private void radioButton5_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void button7_Click(object sender, EventArgs e)
		{
			update_klienci();
			update_table(dataGridView2, "klienci");
			textBox12.Text = "";
			textBox13.Text = "";
			textBox14.Text = "";
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (radioButton11.Checked)
			{
				insert_faktury();
				update_table(dataGridView3, "faktury");
			}
			if (radioButton12.Checked)
			{
				update_faktury();
				update_table(dataGridView3, "faktury");
			}
			if (radioButton13.Checked)
			{
				delete_faktury();
				update_table(dataGridView3, "faktury");
			}
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (radioButton14.Checked)
			{
				insert_adresy();
				update_table(dataGridView4, "adresy");
			}
			if (radioButton15.Checked)
			{
				update_adresy();
				update_table(dataGridView4, "adresy");
			}
			if (radioButton16.Checked)
			{
				delete_adresy();
				update_table(dataGridView4, "adresy");
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			try
			{
				NumberFormatInfo nfi = new NumberFormatInfo();
				nfi.NumberDecimalSeparator = ".";
				this.command.CommandText = $"UPDATE faktura_towary SET id_towaru = {textBox26.Text}, ilosc_towaru = {textBox27.Text} WHERE id_faktury = {textBox25.Text}";
				command.ExecuteNonQuery();
				this.command.CommandText = $"SELECT cena_towaru FROM towary WHERE id_towaru = {textBox26.Text}";
				command.Parameters.Add(new NpgsqlParameter("p_out", DbType.String) { Direction = ParameterDirection.Output });
				command.ExecuteNonQuery();
				var cena = command.Parameters[0].Value;
				command.CommandText = $"UPDATE faktura_towary SET cena_laczna_towaru = {(Convert.ToDouble(cena) * Convert.ToInt64(textBox27.Text)).ToString(nfi)} WHERE id_faktury = {textBox25.Text}";
				command.ExecuteNonQuery();
				update_table(dataGridView5, "faktura_towary");
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}

		}

		private void button11_Click(object sender, EventArgs e)
		{
			try
			{
				this.command.CommandText = $"UPDATE adresy_klientow SET adresy_id_adresu = {textBox29.Text}, status = '{textBox30.Text}' WHERE klienci_nr_klienta = {textBox28.Text}";
				command.ExecuteNonQuery();
				update_table(dataGridView6, "adresy_klientow");
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private void button12_Click(object sender, EventArgs e)
		{
			update_table(dataGridView6, "adresy_klientow");
		}

		private void button13_Click(object sender, EventArgs e)
		{
			update_table(dataGridView5, "faktura_towary");
		}
	}
}
