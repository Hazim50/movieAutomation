using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imdb
{
    public partial class GirişSayfasi : Form
    {
        public GirişSayfasi()
        {
            InitializeComponent();
        }
        static string conn_string = "Data Source=DESKTOP-4V8VAGV\\HZM;Initial Catalog=IMDB;Integrated Security=True;";
        SqlConnection connection = new SqlConnection(conn_string);
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Application.OpenForms["KayitSayfasi"] == null)
            {
                KayitSayfasi kayitSayfasi = new KayitSayfasi();
                kayitSayfasi.FormClosed += (s, args) => this.Close();
                this.Hide();
                kayitSayfasi.Show();
            }
            else
            {
                this.Hide();
                Application.OpenForms["KayitSayfasi"].Show();
            }
        }

        public static string Username { get; private set; }
        private void button1_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            Username = tx_kAdi.Text;

            string kontrolSorgu = "select count(*) from Kullanicilar where kullanici_adi = @kullanici_adi and sifre = @sifre";
            SqlCommand kontrolKomut = new SqlCommand(kontrolSorgu, connection);
            kontrolKomut.Parameters.AddWithValue("@kullanici_adi", tx_kAdi.Text);
            kontrolKomut.Parameters.AddWithValue("@sifre", tx_Sifre.Text);

            int flag = (int)kontrolKomut.ExecuteScalar();

            if (flag != 0)
            {
                if (Application.OpenForms["FilmSayfasi"] == null)
                {
                    FilmSayfasi filmSayfasi = new FilmSayfasi();
                    filmSayfasi.FormClosed += (s, args) => this.Close();
                    this.Hide();
                    filmSayfasi.Show();
                }
                else
                {
                    this.Hide();
                    Application.OpenForms["FilmSayfasi"].Show();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı!");
            }
        }

        private void link_filmEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Application.OpenForms["FilmEklemeSayfasi"] == null)
            {
                FilmEklemeSayfasi filmEklemeSayfasi = new FilmEklemeSayfasi();
                filmEklemeSayfasi.FormClosed += (s, args) => this.Close();
                this.Hide();
                filmEklemeSayfasi.Show();
            }
            else
            {
                Application.OpenForms["FilmEklemeSayfasi"].Show();
            }
        }
    }
}
