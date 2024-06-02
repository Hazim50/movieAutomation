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
    public partial class FilmEklemeSayfasi : Form
    {
        public FilmEklemeSayfasi()
        {
            InitializeComponent();
        }

        static string conn_string = "Data Source=DESKTOP-4V8VAGV\\HZM;Initial Catalog=IMDB;Integrated Security=True;";
        SqlConnection connection = new SqlConnection(conn_string);

        private void link_geriDon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //geri dön yazısına tıklayınca kayıt eklemeden kapatsın
        {
            this.Close();
        }

        private void b_filmEkle_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            try
            {
                string ad = tx_ad.Text; //textboxlardan verileri alıyoruz
                string yonetmen = tx_yonetmen.Text;
                string basrol = tx_basrol.Text;
                string tur = tx_tur.Text;
                float imdbPuani = Convert.ToSingle(tx_imdbPuani.Text);
                float yildiz = Convert.ToSingle(tx_yildiz.Text);
                int sure = Convert.ToInt32(tx_sure.Text);
                string dil = tx_dil.Text;
                int yildizSayisi = Convert.ToInt32(tx_yildizSayisi.Text);
                DateTime cikisYili = dtp_yil.Value;

                string kontrolSorgu = "select count(*) from Filmler where film_adi=@film_adi";
                SqlCommand kontrolKomut = new SqlCommand(kontrolSorgu, connection);
                kontrolKomut.Parameters.AddWithValue("@film_adi", tx_ad.Text);
                int flag = (int)kontrolKomut.ExecuteScalar();
                if (flag == 0)
                {
                    string sorgu = "insert into Filmler (film_adi,yonetmen,basrol,tur,yil,imdb_puani,yildiz,sure,dil,yildiz_sayisi) " + //veritabanına ekleyecek sorgu
                        "values (@film_adi,@yonetmen,@basrol,@tur,@yil,@imdb_puani,@yildiz,@sure,@dil,@yildiz_sayisi)";
                    SqlCommand komut = new SqlCommand(sorgu, connection);
                    komut.Parameters.AddWithValue("@film_adi", ad);
                    komut.Parameters.AddWithValue("@yonetmen", yonetmen);
                    komut.Parameters.AddWithValue("@basrol", basrol);
                    komut.Parameters.AddWithValue("@tur", tur);
                    komut.Parameters.AddWithValue("@imdb_puani", imdbPuani); 
                    komut.Parameters.AddWithValue("@yildiz", yildiz);
                    komut.Parameters.AddWithValue("@sure", sure);
                    komut.Parameters.AddWithValue("@dil", dil);
                    komut.Parameters.AddWithValue("@yildiz_sayisi", yildizSayisi);
                    komut.Parameters.AddWithValue("@yil", cikisYili);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Film Başarıyla Eklendi");

                    if (Application.OpenForms["GirisSayfasi"] == null) //film ekledikten sonra giriş sayfasına dönsün
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
