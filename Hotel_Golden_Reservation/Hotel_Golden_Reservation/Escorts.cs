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
    public partial class Escorts : Form
    {
        public Escorts()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MAKAVELI\\SQLEXPRESS;Initial Catalog=Hotel_Golden;Integrated Security=True");

        private void Escorts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dataSet1.Customers);
            // TODO: This line of code loads data into the 'dataSet1.Escorts' table. You can move, or remove it, as needed.
            this.escortsTableAdapter.Fill(this.dataSet1.Escorts);
            // TODO: This line of code loads data into the 'dataSet1.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.dataSet1.Employees);

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int IDX;
            int Sel_ID;
            IDX = dataGridView1.CurrentRow.Index;
            int.TryParse(dataGridView1.Rows[IDX].Cells[0].Value.ToString(), out Sel_ID);
            this.escortsTableAdapter.DeleteQuery(Sel_ID);
            this.escortsTableAdapter.Fill(this.dataSet1.Escorts);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Escorts (Escort_Name,Escort_LName,Customer_Phone) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.Parameters.AddWithValue("@p2", textBox3.Text);
            komut.Parameters.AddWithValue("@p3", comboBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yardımcılar(Escorts) eklendi !");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateBtnü_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Escorts Set Escort_Name=@p1,Escort_LName=@p2, Customer_Phone = @p3 where Escort_ID=@p4", baglanti);
            komutguncelle.Parameters.AddWithValue("@p1", textBox2.Text);
            komutguncelle.Parameters.AddWithValue("@p2", textBox3.Text);
            komutguncelle.Parameters.AddWithValue("@p3", comboBox1.SelectedValue);
            komutguncelle.Parameters.AddWithValue("@p4", textBox1.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yardımcılar güncellendi !");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
