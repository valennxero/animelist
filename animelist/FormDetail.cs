using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animelist
{
    public partial class FormDetail : Form
    {
        Anime animeDetail;
        public FormDetail(Anime pAnime)
        {
            InitializeComponent();
            animeDetail = pAnime;
        }

        private void FormDetail_Load(object sender, EventArgs e)
        {
            pictureBoxImg.Load(animeDetail.images.jpg.image_url);
            pictureBoxImg.SizeMode = PictureBoxSizeMode.Zoom;
            labelTitle.Text = animeDetail.title;
            labelScore.Text = animeDetail.score.ToString();
            labelId.Text = animeDetail.mal_id.ToString();

            string rankText;
            if(animeDetail.score == 0)
            {
                rankText = "Worst";
            }
            else if (animeDetail.score >= 1 && animeDetail.score <= 5)
            {
                rankText = "Sampah";
            }
            else if (animeDetail.score >= 6 && animeDetail.score <7)
            {
                rankText = "Kureng";
            }
            else if (animeDetail.score >= 7 && animeDetail.score < 8)
            {
                rankText = "Medioker/Standar";
            }
            else if (animeDetail.score >= 8 && animeDetail.score < 9)
            {
                rankText = "Cakep";
            }
            else
            {
                rankText = "Goat";
            }

            labelKategoriScore.Text = rankText;
            labelRank.Text = "#" + animeDetail.rank.ToString();
            labelSeason.Text = animeDetail.season;
            labelYear.Text = animeDetail.year.ToString();
            labelEps.Text = animeDetail.episodes.ToString();
            foreach (var studio in animeDetail.studios)
            {
                labelStudio.Text += studio.name + ", ";
            }
            labelStudio.Text = labelStudio.Text.TrimEnd(',', ' ');
            foreach (var genre in animeDetail.genres)
            {
                labelGenre.Text += genre.name + ", ";
            }
            labelGenre.Text = labelGenre.Text.TrimEnd(',', ' ');
            labelSynopsis.Text = animeDetail.synopsis;
        }
    }
}
