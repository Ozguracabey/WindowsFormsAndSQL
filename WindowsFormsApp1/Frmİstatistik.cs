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

namespace WindowsFormsApp1
{
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-AMJGV2F\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            //toplam personel sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(*) From Tbl_Personel", baglanti);
            SqlDataReader reader = komut1.ExecuteReader();
            while (reader.Read())
            {
                label5.Text = reader[0].ToString();
            }
            baglanti.Close();

            //evli personel sayısı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) From Tbl_Personel Where PerDurum=1", baglanti);
            SqlDataReader reader2 = komut2.ExecuteReader();
            while (reader2.Read())
            {
                label6.Text = reader2[0].ToString();
            }
            baglanti.Close();

            //BEKAR PERSONEL SAYISI
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) From Tbl_Personel Where PerDurum=0", baglanti);
            SqlDataReader reader3 = komut3.ExecuteReader();
            while (reader3.Read())
            {
                label7.Text = reader3[0].ToString();
            }
            baglanti.Close();

            //KAÇ FARKLI ŞEHİR SAYISI
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select Count(distinct(PerSehir)) From Tbl_Personel", baglanti);
            SqlDataReader reader4 = komut4.ExecuteReader();
            while (reader4.Read())
            {
                label8.Text = reader4[0].ToString();
            }
            baglanti.Close();

            //toplam maaş
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select Sum(PerMaas) From Tbl_Personel", baglanti);
            SqlDataReader reader5 = komut5.ExecuteReader();
            while (reader5.Read())
            {
                label9.Text = reader5[0].ToString();
            }
            baglanti.Close();

            //ortalama maaş
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select Avg(PerMaas) From Tbl_Personel", baglanti);
            SqlDataReader reader6 = komut6.ExecuteReader();
            while (reader6.Read())
            {
                label11.Text = reader6[0].ToString();
            }
            baglanti.Close();
            //this.reportViewer1.RefreshReport();
        }
    }
}
