using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using YoutubeExplode;
using YoutubeExplode.Models.MediaStreams;

namespace mPlayer
{
    public partial class MusicDownload : MaterialForm
    {
        public MusicDownload()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance; //create a new materialskinmanager instance
            materialSkinManager.AddFormToManage(this); //add this form to the managed forms of materialskinmanager
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK; //set the theme to dark

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red900, Primary.Red800, Primary.Blue500, Accent.Red700, TextShade.WHITE); //my special red theme

            materialProgressBar1.Hide();
            ProgressLabel.Hide();

        }

        private async void MaterialFlatButton2_Click(object sender, EventArgs e)
        {
            var client = new YoutubeClient();
            string link = SearchBoxInput.Text;
            string id = YoutubeClient.ParseVideoId(link);

            var video = await client.GetVideoAsync(id);

            var title = video.Title;
            var author = video.Author;
            var duration = video.Duration;
            var desc = video.Description;
            var thumbnail = video.Thumbnails.HighResUrl;
            var views = video.Statistics.ViewCount;
            var likes = video.Statistics.LikeCount;
            var dislikes = video.Statistics.DislikeCount;
            var keywords = video.Keywords;

            materialLabel1.Text = title;
            materialLabel2.Text = author;
            materialLabel3.Text = duration.ToString();
            materialLabel7.Text = views.ToString() + " views";
            textBox1.Text = desc;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Load(thumbnail);
            textBox2.Text = "";
            foreach(string keyword in keywords)
            {
                textBox2.Text = textBox2.Text + keyword + ", ";
            }
            materialLabel4.Text = "Likes - " + likes + " Dislikes - " + dislikes;


            SaveThumbnailCheckBox.Show();
            
        }

        private async void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
            SaveThumbnailCheckBox.Hide();
            materialProgressBar1.Show();
            ProgressLabel.Show();
            materialProgressBar1.Value = 0;
            materialFlatButton1.Hide();
            materialFlatButton2.Hide();

            var client = new YoutubeClient();
            var videoId = YoutubeClient.ParseVideoId(SearchBoxInput.Text);
            ProgressLabel.Text = "Searching Video";
            materialProgressBar1.Value = materialProgressBar1.Value + 1;

            var video = await client.GetVideoAsync(videoId);
            ProgressLabel.Text = "Found Video";
            materialProgressBar1.Value = materialProgressBar1.Value + 1;

            var streamInfoSet = await client.GetVideoMediaStreamInfosAsync(videoId);
            var streamInfo = streamInfoSet.Muxed.WithHighestVideoQuality();

            var fileExtension = streamInfo.Container.GetFileExtension();
            var fileName = $"{video.Title} - {video.Author}.{fileExtension}";
            fileName = ReplaceInvalidChars(fileName);

            ProgressLabel.Text = "Downloading Video";
            bool SaveThumbnail = SaveThumbnailCheckBox.Checked;
            int TempProgressBarValue;
            if (SaveThumbnail)
            {
                TempProgressBarValue = 1;
            } else
            {
                TempProgressBarValue = 2;
            }
            materialProgressBar1.Value = materialProgressBar1.Value + TempProgressBarValue;

            await client.DownloadMediaStreamAsync(streamInfo, fileName);

            ProgressLabel.Text = "Converting to MP3";
            materialProgressBar1.Value = materialProgressBar1.Value + 4;

            var Convert = new NReco.VideoConverter.FFMpegConverter();
            var MP3FolderPath = "C:/Users/" + Environment.UserName + "/Music/mPlayer/";
            String SaveMP3File = MP3FolderPath + fileName.Replace(".mp4", ".mp3");
            Convert.ConvertMedia(fileName, SaveMP3File, "mp3");

            if (SaveThumbnail)
            {
                ProgressLabel.Text = "Saving Thumbnail";
                materialProgressBar1.Value = materialProgressBar1.Value + 1;
                var thumbnail = video.Thumbnails.HighResUrl;
                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile(thumbnail, "C:/Users/" + Environment.UserName + "/Music/mPlayer/Data/Thumbnails/" + fileName.Replace(".mp4", string.Empty) + ".jpg"); ;
                }

            }

            ProgressLabel.Text = "Cleaning Old Files";
            materialProgressBar1.Value = materialProgressBar1.Value + 1;

            File.Delete(fileName);

            ProgressLabel.Text = "Done. Refresh your Music!";
            materialProgressBar1.Value = materialProgressBar1.Value + 1;

            materialFlatButton1.Show();
            materialFlatButton2.Show();

        }
        private string ReplaceInvalidChars(string filename)
        {
            return string.Join("_", filename.Split(Path.GetInvalidFileNameChars()));
        }

    }
}
