using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_Golden_Reservation
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MAKAVELI\\SQLEXPRESS;Initial Catalog=Hotel_Golden;Integrated Security=True");

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Escorts' table. You can move, or remove it, as needed.
            this.escortsTableAdapter.Fill(this.dataSet1.Escorts);
            // TODO: This line of code loads data into the 'dataSet1.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.dataSet1.Rooms);
            // TODO: This line of code loads data into the 'dataSet1.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.dataSet1.Employees);
            // TODO: This line of code loads data into the 'dataSet1.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dataSet1.Customers);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int IDX;
            int Sel_ID;
            IDX = dataGridView1.CurrentRow.Index;
            int.TryParse(dataGridView1.Rows[IDX].Cells[0].Value.ToString(), out Sel_ID);
            this.customersTableAdapter.DeleteQuery(Sel_ID);
            this.customersTableAdapter.Fill(this.dataSet1.Customers);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Customers (Employee_ID,Room_ID,Escort_ID,Customer_Name,Customer_LName,Customer_Phone,Date) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
            komut.Parameters.AddWithValue("@p1", comboBox1.SelectedValue);
            komut.Parameters.AddWithValue("@p2", comboBox2.SelectedValue);
            komut.Parameters.AddWithValue("@p3", comboBox3.SelectedValue);
            komut.Parameters.AddWithValue("@p4", textBox2.Text);
            komut.Parameters.AddWithValue("@p5", textBox3.Text);
            komut.Parameters.AddWithValue("@p6", textBox4.Text);
            komut.Parameters.AddWithValue("@p7", dateTimePicker1.Value);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteriler eklendi !");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Customers Set Employee_ID=@p1,Room_ID=@p2,Escort_ID=@p3,Customer_Name=@p4,Customer_LName=@p5,Customer_Phone=@p6,Date=@p7 where Country_ID=@p8", baglanti);
            komutguncelle.Parameters.AddWithValue("@p1", comboBox1.SelectedValue);
            komutguncelle.Parameters.AddWithValue("@p2", comboBox2.SelectedValue);
            komutguncelle.Parameters.AddWithValue("@p3", comboBox3.SelectedValue);
            komutguncelle.Parameters.AddWithValue("@p4", textBox2.Text);
            komutguncelle.Parameters.AddWithValue("@p5", textBox3.Text);
            komutguncelle.Parameters.AddWithValue("@p6", textBox4.Text);
            komutguncelle.Parameters.AddWithValue("@p7", dateTimePicker1.Value);
            komutguncelle.Parameters.AddWithValue("@p8", textBox1.Text);

            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşçiler güncellendi !");
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
