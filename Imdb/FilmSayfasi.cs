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
            string sorgu = "Select film_adi,yildiz from Filmler";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            FilmListesi.DataSource = dt;
            FilmListesi.Columns[0].HeaderText = "Kitap Adı";
            FilmListesi.Columns[1].HeaderText = "Yıldız";

            updateDatas();

            fillStars(1);

        }

        void updateDatas()
        {
            string sorgu2 = "select * from Filmler where film_adi=@film_adi";
            SqlCommand komut2 = new SqlCommand(sorgu2, connection);
            komut2.Parameters.AddWithValue("@film_adi", FilmListesi.CurrentRow.Cells[0].Value.ToString());

            SqlDataReader reader = komut2.ExecuteReader();
            //l_filmAdi.Text = "sdfjsdkf";
            if (reader.Read())
            {
                l_filmAdi.Text = FilmListesi.CurrentRow.Cells[0].Value.ToString();
                l_tur.Text = reader["tur"].ToString();
                l_yil.Text = reader["yil"].ToString();
                l_basrol.Text = reader["basrol"].ToString();
                l_yonetmen.Text = reader["yonetmen"].ToString();
                l_imdbPuani.Text = reader["imdb_puani"].ToString();
                l_sure.Text = reader["sure"].ToString();
                l_dil.Text = reader["dil"].ToString();
                l_yildiz.Text = reader["yildiz"].ToString();
            }

            //l_yil.Text = reader["yil"].ToString();
            reader.Close();
        }

        private void FilmListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateDatas();
        }

        int yildizSayisi = 1;
        void fillStars(int adet)
        {
            Dictionary<PictureBox, string> starList = new Dictionary<PictureBox, string>();
            starList = returnStarList(adet);

            foreach (KeyValuePair<PictureBox, string> kvp in starList)
            {
                PictureBox pictureBox = kvp.Key;
                string imagePath = kvp.Value;
                pictureBox.Image = Image.FromFile(imagePath);
            }
        }

        Dictionary<PictureBox, string> returnStarList(int adet)
        {
            PictureBox[] yildizlar = { yildiz1, yildiz2, yildiz3, yildiz4, yildiz5 };
            Dictionary<PictureBox, string> starList = new Dictionary<PictureBox, string>();
            for (int i = 1; i<= 5; i++)
            {
                PictureBox yildiz = yildizlar[i-1];
                if (i <= adet)
                {
                    starList.Add(yildiz, Application.StartupPath + "\\assets\\dolu.png");
                }
                else
                {
                    starList.Add(yildiz, Application.StartupPath + "\\assets\\bos.png");
                }
            }
            return starList;
        }

        private void yildiz1_MouseClick(object sender, MouseEventArgs e)
        {
            fillStars(1);
        }

        private void yildiz2_MouseClick(object sender, MouseEventArgs e)
        {
            fillStars(2);
        }

        private void yildiz3_MouseClick(object sender, MouseEventArgs e)
        {
            fillStars(3);
        }

        private void yildiz4_MouseClick(object sender, MouseEventArgs e)
        {
            fillStars(4);
        }

        private void yildiz5_MouseClick(object sender, MouseEventArgs e)
        {
            fillStars(5);
        }
    }
}
