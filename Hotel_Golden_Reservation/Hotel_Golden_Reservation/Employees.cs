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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MAKAVELI\\SQLEXPRESS;Initial Catalog=Hotel_Golden;Integrated Security=True");

        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.dataSet1.Employees);

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int IDX;
            int Sel_ID;
            IDX = dataGridView1.CurrentRow.Index;
            int.TryParse(dataGridView1.Rows[IDX].Cells[0].Value.ToString(), out Sel_ID);
            this.employeesTableAdapter.DeleteQuery(Sel_ID);
            this.employeesTableAdapter.Fill(this.dataSet1.Employees);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Employees (Employee_Name,Employee_LName) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.Parameters.AddWithValue("@p2", textBox3.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Rezervasyon elemanı eklendi !");
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Employees Set Employee_Name=@p1,Employee_LName=@p2 where Employee_ID=@p3", baglanti);
            komutguncelle.Parameters.AddWithValue("@p1", textBox2.Text);
            komutguncelle.Parameters.AddWithValue("@p2", textBox3.Text);
            komutguncelle.Parameters.AddWithValue("@p3", textBox1.Text);
            
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşçiler güncellendi !");
        }
    }
}
