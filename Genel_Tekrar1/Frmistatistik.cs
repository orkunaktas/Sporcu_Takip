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
    public partial class Frmistatistik : Form
    {
        public Frmistatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MATEBOOK-13;Initial Catalog=SporcuVeriTabani;Integrated Security=True");

        private void Frmistatistik_Load(object sender, EventArgs e)
        {

            //Sporcu Sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) from Tbl_Sporcu", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lbltoplamsporcu.Text = dr1[0].ToString();
            }
            baglanti.Close();


            //Branş Sayısı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select count(distinct(SprBrans)) from Tbl_Sporcu", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                label3.Text = dr2[0].ToString();
            }
            baglanti.Close();


            //Uyruk Sayısı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select count(distinct(SprUyruk)) from Tbl_Sporcu", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                label5.Text = dr3[0].ToString();
            }
            baglanti.Close();


            //Toplam Maaş
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select sum(SprMaas) from Tbl_Sporcu", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                label7.Text = dr4[0].ToString();
            }
            baglanti.Close();


            //Ortalama Maaş
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select avg(SprMaas) from Tbl_Sporcu", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                label9.Text = dr5[0].ToString();
            }
            baglanti.Close();



        }
    }
}
