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
    public partial class FilmSayfasi : Form
    {
        public FilmSayfasi()
        {
            InitializeComponent();
        }
        static string conn_string = "Data Source=DESKTOP-4V8VAGV\\HZM;Initial Catalog=IMDB;Integrated Security=True;";
        SqlConnection connection = new SqlConnection(conn_string);
        private void FilmSayfasi_Load(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            
            
            fillFilmListesi();
            updateDatas();
            fillYorumListesi();
            //fillFilmListesi();
        }

        
        void updateDatas()
        {
            string sorgu2 = "select * from Filmler where film_adi=@film_adi";
            SqlCommand komut2 = new SqlCommand(sorgu2, connection);
            komut2.Parameters.AddWithValue("@film_adi", FilmListesi.CurrentRow.Cells[0].Value.ToString());

            SqlDataReader reader = komut2.ExecuteReader();
            if (reader.Read())
            {
                l_filmAdi.Text = FilmListesi.CurrentRow.Cells[0].Value.ToString();
                l_tur.Text = reader["tur"].ToString();
                l_yil.Text = Convert.ToDateTime(reader["yil"]).Year.ToString();
                l_basrol.Text = reader["basrol"].ToString();
                l_yonetmen.Text = reader["yonetmen"].ToString();
                l_imdbPuani.Text = Math.Round(Convert.ToSingle(reader["imdb_puani"]),2).ToString();
                l_sure.Text = reader["sure"].ToString();
                l_dil.Text = reader["dil"].ToString();
                l_yildiz.Text = Convert.ToDouble(reader["yildiz"]).ToString("F2");
            }

            //l_yil.Text = reader["yil"].ToString();
            reader.Close();
        }

        void fillFilmListesi()
        {
            string sorgu = "Select film_adi,yildiz from Filmler";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            FilmListesi.DataSource = dt;
            FilmListesi.Columns["yildiz"].DefaultCellStyle.Format = "F2";

            FilmListesi.Columns[0].HeaderText = "Film Adı";
            FilmListesi.Columns[1].HeaderText = "Yıldız";
        }

        private void FilmListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateDatas();
            fillYorumListesi();
        }

        void fillYorumListesi()
        {
            string sorgu = "select film_id from Filmler where film_adi=@film_adi";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@film_adi", FilmListesi.CurrentRow.Cells[0].Value.ToString());
            SqlDataReader reader = komut.ExecuteReader();
            string film_id = "";

            if (reader.Read())
            {
                film_id = reader["film_id"].ToString();
                reader.Close();
            }


            string sorgu2 = "select yorum_tarihi,yorum_metni from Yorumlar where film_id=@film_id";
            SqlCommand komut2 = new SqlCommand(sorgu2, connection);
            komut2.Parameters.AddWithValue("film_id", film_id);
            SqlDataAdapter adapter = new SqlDataAdapter(komut2);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            YorumListesi.DataSource = dt;
        }
        private void b_yorumYap_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["YorumSayfasi"] == null)
            {
                YorumSayfasi yorumSayfasi = new YorumSayfasi(FilmListesi.CurrentRow.Cells[0].Value.ToString());
                yorumSayfasi.FormClosed += (s, args) => this.Show();
                yorumSayfasi.FormClosed += (s, args) => updateDatas();
                yorumSayfasi.FormClosed += (s, args) => fillYorumListesi();
                yorumSayfasi.FormClosed += (s, args) => fillFilmListesi();
                this.Hide();
                yorumSayfasi.Show();
            }
            else
            {
                Application.OpenForms["YorumSayfasi"].Show();
            }
        }

        private void link_cikisYap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Application.OpenForms["GirisSayfasi"] == null)
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

        private void b_izle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Film İzlendi, Yorumlarınızı Bekliyoruz");
        }
    }
}
