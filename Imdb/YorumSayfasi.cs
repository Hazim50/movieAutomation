using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imdb
{
    public partial class YorumSayfasi : Form
    {
        private string film_adi;
        public YorumSayfasi(string film_adi)
        {
            InitializeComponent();
            this.film_adi = film_adi;
            l_filmAdi.Text = film_adi;
        }


        static string conn_string = "Data Source=DESKTOP-4V8VAGV\\HZM;Initial Catalog=IMDB;Integrated Security=True;";
        SqlConnection connection = new SqlConnection(conn_string);

        private void YorumSayfasi_Load(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            fillStars(1); //sayfa açılırken default olarak 1 yıldız seçili olsun
        }

        int yildizSayisi = 1; //güncel yıldız puanını hesaplarken kullanılıyor
        void fillStars(int adet) // parametre olarak gelen yıldız sayısı kadar yıldızı doldursun
        {
            Dictionary<PictureBox, string> starList = new Dictionary<PictureBox, string>();
            starList = returnStarList(adet); // yıldızların boş veya dolu olduğunun görselini ve yolunu bu fonksiyon dönderiyor

            foreach (KeyValuePair<PictureBox, string> kvp in starList) //her bir yıldız görseli için döngü oluşturuluyor ve mevcut görsel yoluna göre yıldızların resminin dolu veya boş olduğu ayarlanıyor
            {
                PictureBox pictureBox = kvp.Key; //key, hangi yıldız olduğu 
                string imagePath = kvp.Value; // value, bu yıldızın görselinin yolu
                pictureBox.Image = Image.FromFile(imagePath); //görsel yükle
            }
        }

        Dictionary<PictureBox, string> returnStarList(int adet) //yıldızların görselinin belirlendiği fonksiyon
        {
            PictureBox[] yildizlar = { yildiz1, yildiz2, yildiz3, yildiz4, yildiz5 };
            Dictionary<PictureBox, string> starList = new Dictionary<PictureBox, string>();
            for (int i = 1; i <= 5; i++)
            {
                PictureBox yildiz = yildizlar[i - 1];
                if (i <= adet) //yildizSayisi değişkeninden küçük eşit olanlar dolu yıldız, diğerleri boş yıldız olacak
                {
                    starList.Add(yildiz, Application.StartupPath + "\\assets\\dolu.png");
                    yildizSayisi = i;
                }
                else
                {
                    starList.Add(yildiz, Application.StartupPath + "\\assets\\bos.png");
                }
            }
            return starList;
        }

        //yıldızlara tıklandığında kendi sayısına göre yıldızların görsellerini ayarlıyor
        private void yildiz1_MouseClick_1(object sender, MouseEventArgs e)
        {
            fillStars(1);
        }

        private void yildiz2_MouseClick_1(object sender, MouseEventArgs e)
        {
            fillStars(2);
        }

        private void yildiz3_MouseClick_1(object sender, MouseEventArgs e)
        {
            fillStars(3);
        }

        private void yildiz4_MouseClick_1(object sender, MouseEventArgs e)
        {
            fillStars(4);
        }

        private void yildiz5_MouseClick_1(object sender, MouseEventArgs e)
        {
            fillStars(5);
        }

        private void yildizVer() //yıldızların veritabanıyla bağlantısının yapıldığı fonksiyon
        {
            string sorgu = "select yildiz,yildiz_sayisi from Filmler where film_adi=@film_adi"; //yıldız sayısını ve yıldız puanını veritabanından çekiyor
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@film_adi", film_adi);
            SqlDataReader reader = komut.ExecuteReader();


            if (reader.Read()) // eğer başarılı ise
            {
                double mevcutYildiz = Convert.ToDouble(reader["yildiz"]);
                int mevcutYildizSayisi = Convert.ToInt32(reader["yildiz_sayisi"]);

                int yeniYildizSayisi = mevcutYildizSayisi + 1;
                double yeniYildiz = ((mevcutYildiz * mevcutYildizSayisi) + yildizSayisi) / yeniYildizSayisi; //burada mevcut yıldız puanı ve toplam kaç kez yıldız verildiği kullanılarak yeni yıldız puanı hesaplanıyor 

                string updateQuery = "UPDATE Filmler SET yildiz = @yeniYildiz, yildiz_sayisi = @yeniYildizSayisi WHERE film_adi=@film_adi"; // veritabanını güncelle
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@yeniYildiz", Math.Round(yeniYildiz, 2));
                    updateCommand.Parameters.AddWithValue("@yeniYildizSayisi", yeniYildizSayisi);
                    updateCommand.Parameters.AddWithValue("@film_adi", film_adi);
                    reader.Close();
                    updateCommand.ExecuteNonQuery();
                }
            }
        }

        private void yorumYap()
        {

            if (YorumKutusu.Text.Length > 0)
            {
                string filmId = "";

                string sorgu = "SELECT film_id FROM Filmler WHERE film_adi = @film_adi"; //adını biliyoruz, bu bilgiyi kullanarak film_id değerini veritabanından alıyoruz
                using (SqlCommand komut = new SqlCommand(sorgu, connection))
                {
                    komut.Parameters.AddWithValue("@film_adi", film_adi);

                    SqlDataReader reader = komut.ExecuteReader();
                    if (reader.Read())
                    {
                        filmId = reader["film_id"].ToString();
                    }
                    reader.Close();
                }


                DateTime dateTime = DateTime.Now;

                string sorgu2 = "insert into Yorumlar (kullanici_adi, film_id, yorum_tarihi, yorum_metni) " + //yeni yorumu veritabanına eklemek için olan sorgu
                        "values (@kullanici_adi, @film_id, @yorum_tarihi, @yorum_metni)";

                using (SqlCommand komut2 = new SqlCommand(sorgu2, connection))
                {
                    komut2.Parameters.AddWithValue("@kullanici_adi", GirişSayfasi.Username); // Giriş sayfasında tanımlanan static Username değişkeni burada kullanılıyor
                    komut2.Parameters.AddWithValue("@film_id", filmId);
                    komut2.Parameters.AddWithValue("@yorum_tarihi", dateTime);
                    komut2.Parameters.AddWithValue("@yorum_metni", YorumKutusu.Text);

                    komut2.ExecuteNonQuery();
                }
            }
        }

        private void b_yorumYap_Click(object sender, EventArgs e) //yorum yap butonuna tıklayınca yapılacak işlemler
        {
            yildizVer();
            yorumYap();
            MessageBox.Show("Basariyla Yorum Yapıldı ve Yıldız Verildi");
            this.Close();
        }

        private void link_geriDon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //geri dön yazısına basılınca sayfayı hemen kapat
        {
            this.Close();
        }
    }
}
