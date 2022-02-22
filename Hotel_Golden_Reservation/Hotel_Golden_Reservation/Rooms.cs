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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MAKAVELI\\SQLEXPRESS;Initial Catalog=Hotel_Golden;Integrated Security=True");
        

        private void Rooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.dataSet1.Rooms);

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int IDX;
            int Sel_ID;
            IDX = dataGridView1.CurrentRow.Index;
            int.TryParse(dataGridView1.Rows[IDX].Cells[0].Value.ToString(), out Sel_ID);
            this.roomsTableAdapter.DeleteQuery(Sel_ID);
            this.roomsTableAdapter.Fill(this.dataSet1.Rooms);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Rooms (Room_Name,Room_Class) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1",textBox2.Text);
            komut.Parameters.AddWithValue("@p2", textBox3.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Odalar eklendi !");
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Rooms Set Room_Name=@p1,Room_Class=@p2 where Room_ID=@p3", baglanti);
            komutguncelle.Parameters.AddWithValue("@p1", textBox2.Text);
            komutguncelle.Parameters.AddWithValue("@p2", textBox3.Text);
            komutguncelle.Parameters.AddWithValue("@p3", textBox1.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Odalar güncellendi !");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
