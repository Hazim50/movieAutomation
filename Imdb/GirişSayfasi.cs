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
        static string conn_string = "Data Source=DESKTOP-4V8VAGV\\HZM;Initial Catalog=IMDB;Integrated Security=True;"; //Bağlantı için kullanılacak connection string
        SqlConnection connection = new SqlConnection(conn_string);

        public static string Username { get; private set; } //yorum yaparken UserName değişkeni kullanılacak kullanılıyor
        public static string AdSoyad { get; private set; } //Film Sayfasında ad soyad göstermek için

        private void link_filmEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Film ekle sayfasını açmak için
        {
            FilmEklemeSayfasi filmEklemeSayfasi = new FilmEklemeSayfasi();
            filmEklemeSayfasi.FormClosed += (s, args) => this.Show();
            this.Hide();
            filmEklemeSayfasi.Show();
        }

        private void link_kayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Kayıt olma sayfasını açmak için
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

        private void b_girisYap_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            Username = tx_kAdi.Text;
            string sorgu = "select ad,soyad from Kullanicilar where kullanici_adi = @kullanici_adi"; // sol üstte ad soyad yazması için kullanıcı adı kullanarak veritabanından ad soyadı çekiyoruz
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@kullanici_adi",tx_kAdi.Text);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                AdSoyad = reader["ad"] + " " + reader["soyad"];
            }
            reader.Close(); //reader kapatmazsak devamında hata veriyor


            string kontrolSorgu = "select count(*) from Kullanicilar where kullanici_adi = @kullanici_adi and sifre = @sifre"; //kullanıcı adı ve şifresi doğru ise 1 dönderecek olan sorgu
            SqlCommand kontrolKomut = new SqlCommand(kontrolSorgu, connection);
            kontrolKomut.Parameters.AddWithValue("@kullanici_adi", tx_kAdi.Text); //kullanıcı adı ve şifre textBox'larındaki verileri alıyoruz
            kontrolKomut.Parameters.AddWithValue("@sifre", tx_Sifre.Text);

            int flag = (int)kontrolKomut.ExecuteScalar(); 

            if (flag != 0) // 0 değilse 1'dir, yani kullanıcı kayıtlıdır kayıtlı ise giriş yaptırıyoruz (FilmSayfasi açılıyor)
            {
                FilmSayfasi filmSayfasi = new FilmSayfasi();
                filmSayfasi.FormClosed += (s, args) => this.Close();
                this.Hide();
                filmSayfasi.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı!");
            }
        }
    }
}
