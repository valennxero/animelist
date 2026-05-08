using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;


namespace animelist
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        JikanRespon respon;
        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string keyword = textBoxSearch.Text.ToLower();
                    string url = $"https://api.jikan.moe/v4/anime?q={keyword}";

                    string json = await client.GetStringAsync(url);

                    respon = JsonConvert.DeserializeObject<JikanRespon>(json);
                    //pictureBoxImg.Load(respon.data[0].images.jpg.image_url);
                    //pictureBoxImg.SizeMode = PictureBoxSizeMode.Zoom;
                    dataGridViewaAnime.Rows.Clear();

                    foreach (var anime in respon.data)
                    {
                        dataGridViewaAnime.Rows.Add(anime.title, anime.episodes, anime.year, anime.score, anime.rank, anime.mal_id);
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void dataGridViewaAnime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = dataGridViewaAnime.CurrentRow.Index;
            FormDetail formDetail = new FormDetail(respon.data[idx]);
            formDetail.Owner = this;
            formDetail.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (HttpClient _client = new HttpClient())
            {
                string url = "https://api.jikan.moe/v4/anime?mal_id=63816";
                string json = await _client.GetStringAsync(url);

                respon = JsonConvert.DeserializeObject<JikanRespon>(json);
                Anime frieren = respon.data[0];
                FormDetail formDetail = new FormDetail(frieren);
                formDetail.Owner = this;
                formDetail.ShowDialog();
            }
        }
    }
}
