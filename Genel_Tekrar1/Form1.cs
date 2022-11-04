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

namespace Genel_Tekrar1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MATEBOOK-13;Initial Catalog=SporcuVeriTabani;Integrated Security=True");


        void temizle()
        {
            textBox1.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            txtuyruk.Text = "";
            txtbrans.Text = "";
            mskmaas.Text = "";
            txtad.Focus();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
           
            this.tbl_SporcuTableAdapter.Fill(this.sporcuVeriTabaniDataSet.Tbl_Sporcu);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbl_SporcuTableAdapter.Fill(this.sporcuVeriTabaniDataSet.Tbl_Sporcu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Sporcu (SprAd,SprSoyad,SprUyruk,SprBrans,SprMaas) values(@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtuyruk.Text);
            komut.Parameters.AddWithValue("@p4", txtbrans.Text);
            komut.Parameters.AddWithValue("@p5", mskmaas.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sporcu Eklendi");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtuyruk.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtbrans.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            mskmaas.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("delete from Tbl_Sporcu where Sprid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", textBox1.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sporcu Silindi");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("update Tbl_Sporcu set SprAd=@a1 , SprSoyad=@a2 , SprUyruk=@a3 , SprBrans=@a4 , SprMaas=@a5  where Sprid=@a6" , baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", txtad.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtsoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", txtuyruk.Text);
            komutguncelle.Parameters.AddWithValue("@a4", txtbrans.Text);
            komutguncelle.Parameters.AddWithValue("@a5", mskmaas.Text);
            komutguncelle.Parameters.AddWithValue("@a6", textBox1.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sporcu Güncellendi");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frmistatistik fr = new Frmistatistik();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
