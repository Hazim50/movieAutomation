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
    public partial class KayitSayfasi : Form
    {
        public KayitSayfasi()
        {
            InitializeComponent();
        }
        static string conn_string = "Data Source=DESKTOP-4V8VAGV\\HZM;Initial Catalog=IMDB;Integrated Security=True;";
        SqlConnection connection = new SqlConnection(conn_string);
        private void link_girisYap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //giriş yap yazısına tıklayınca login sayfasına yönlendiriyor
        {
            if (Application.OpenForms["GirişSayfasi"] == null)
            {
                GirişSayfasi girişSayfasi = new GirişSayfasi();
                girişSayfasi.FormClosed += (s, args) => this.Close();
                this.Hide();
                girişSayfasi.Show();
            }
            else
            {
                this.Hide();
                Application.OpenForms["GirişSayfasi"].Show();
            }
        }

        private void b_kayitOl_Click(object sender, EventArgs e) //Kayıt ol butonuna basınca yapılacak işlemler
        {
            string ad = tx_ad.Text;
            string soyad = tx_soyad.Text;
            string tel = tx_tel.Text;
            string mail = tx_mail.Text;
            string kAdi = tx_kAdi.Text;
            string sifre = tx_sifre.Text;
            DateTime dGunu = dtp_dTarihi.Value;

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            string kontrolSorgu = "select count(*) from Kullanicilar where mail = @mail or kullanici_adi = @kullanici_adi"; //textbox'a girilenlerden daha önceden kullanıcı adı ya da mail sistemde kayıtlıysa hata versin
            SqlCommand kontrolKomut = new SqlCommand(kontrolSorgu, connection);
            kontrolKomut.Parameters.AddWithValue("@mail", mail);
            kontrolKomut.Parameters.AddWithValue("@kullanici_adi", tx_kAdi.Text);

            int flag = (int)kontrolKomut.ExecuteScalar();

            if (flag == 0) //eğer 0 ise kayıtlı kullanıcı yoktur, veritabanına eklesin
            {
                string sorgu = "insert into Kullanicilar (ad, soyad, tel, dogum_tarihi, mail, kullanici_adi, sifre) " +
                    "values (@ad, @soyad, @tel, @dogum_tarihi, @mail, @kullanici_adi, @sifre)"; //veritabanına ekleme kodları
                SqlCommand sqlCommand = new SqlCommand(sorgu, connection);
                sqlCommand.Parameters.AddWithValue("@ad", ad);
                sqlCommand.Parameters.AddWithValue("@soyad", soyad);
                sqlCommand.Parameters.AddWithValue("@tel", tel);
                sqlCommand.Parameters.AddWithValue("@dogum_tarihi", dGunu);
                sqlCommand.Parameters.AddWithValue("@mail", mail);
                sqlCommand.Parameters.AddWithValue("@kullanici_adi", kAdi);
                sqlCommand.Parameters.AddWithValue("@sifre", sifre);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Basariyla Kayıt Oldunuz");

                if (Application.OpenForms["GirisSayfasi"] == null) //ekledikten sonra bu sayfayı kapatıp giriş sayfasını açsın
                {
                    GirişSayfasi girişSayfasi = new GirişSayfasi();
                    girişSayfasi.FormClosed += (s, args) => this.Close();
                    this.Hide();
                    girişSayfasi.Show();
                }
                else
                {
                    Application.OpenForms["GirisSayfasi"].Activate();
                }
            }
            else
            {
                MessageBox.Show("Bu mail veya kullanıcı adı sistemde kayıtlı!");
            }
        }
    }
}
