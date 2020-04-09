using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DiscordRPC;
using System.Collections.ObjectModel;
using CSCore.CoreAudioAPI;

namespace mPlayer
{
    public partial class Form1 : MaterialForm
    {
        public bool SongIsPlaying = false;
        public MusicPlayer mPlayer = new MusicPlayer();
        public DiscordRpcClient client;
        public string NowPlayingTitle = "";
        public int NowPlayingLengthMinutes;
        public int AudioProgressBarLength;

        private readonly ObservableCollection<MMDevice> _devices = new ObservableCollection<MMDevice>();

        public string CurrentmPlayerVersion = "0.1";

        public Form1()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance; //create a new materialskinmanager instance
            materialSkinManager.AddFormToManage(this); //add this form to the managed forms of materialskinmanager
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK; //set the theme to dark

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red900, Primary.Red800, Primary.Red500, Accent.Red700, TextShade.WHITE); //my special red theme

            AudioProgressBar.Value = 0; //set the value to 0 at form start

            client = new DiscordRpcClient("615718974860165131"); //mPlayer Discord Application ID
            client.Initialize(); //initalize the discordrpc
            VolumeSlider.ValueChanged += new EventHandler(VolumeSlider_OnValueChanged); //register event handler for the volume slider
            this.FormClosing += new FormClosingEventHandler(Form1_Closing);

            Directory.CreateDirectory("C:/Users/" + Environment.UserName + "/Music/mPlayer"); //create the directory if it does not exist, if it does, then dont do anything
            Directory.CreateDirectory("C:/Users/" + Environment.UserName + "/Music/mPlayer/Data");
            Directory.CreateDirectory("C:/Users/" + Environment.UserName + "/Music/mPlayer/Data/Settings");
            Directory.CreateDirectory("C:/Users/" + Environment.UserName + "/Music/mPlayer/Data/Thumbnails");

            foreach (var file in Directory.GetFiles("C:/Users/" + Environment.UserName + "/Music/mPlayer", "*.mp3")) //add each mp3 to the list
            {
                string tempfilename = Path.GetFileName(file);
                materialListView1.Items.Add(tempfilename);
            }

            materialListView1.HideSelection = true;

        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            mPlayer.Pause();
            TimeSpan position = mPlayer.Position;
            TimeSpan length = mPlayer.Length;
            client.SetPresence(new RichPresence()
            {
                Details = NowPlayingTitle,
                State = " || " + String.Format(@"{0:mm\:ss} / {1:mm\:ss}", position, length),
                Assets = new Assets()
                {
                    LargeImageKey = "mplayer",
                    LargeImageText = "mPlayer by Matt4499"
                }
            });
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            mPlayer.Play();
            TimeSpan position = mPlayer.Position;
            TimeSpan length = mPlayer.Length;
            client.SetPresence(new RichPresence()
            {
                Details = NowPlayingTitle,
                State = "► " + String.Format(@"{0:mm\:ss} / {1:mm\:ss}", position, length),
                Assets = new Assets()
                {
                    LargeImageKey = "mplayer",
                    LargeImageText = "mPlayer by Matt4499"
                }
            });
            timer1.Enabled = true;
            timer1.Start();
        }

     private void Form1_Closing(object sender, CancelEventArgs e)
        {
            timer1.Stop();
            mPlayer.Stop();
            client.SetPresence(new RichPresence()
            {
                Details = "Exiting...",
                State = "",
                Assets = new Assets()
                {
                    LargeImageKey = "mplayer",
                    LargeImageText = "mPlayer by Matt4499"
                }
            });
            client.Dispose();

        }

        private string ReplaceInvalidChars(string filename)
        {
            return string.Join("_", filename.Split(Path.GetInvalidFileNameChars()));
        }


        private void VolumeSlider_OnValueChanged(object sender, EventArgs e)
        {
            mPlayer.Volume = VolumeSlider.Value;
            VolumeLabel.Text = VolumeSlider.Value.ToString("000");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan position = mPlayer.Position;
            TimeSpan length = mPlayer.Length;
            string tempduration = String.Format(@"{0:mm\:ss} / {1:mm\:ss}", position, length);
            PositionLabel.Text = tempduration;

            client.SetPresence(new RichPresence()
            {
                Details = NowPlayingTitle,
                State = "► " + tempduration,
                Assets = new Assets()
                {
                    LargeImageKey = "mplayer",
                    LargeImageText = "mPlayer by Matt4499"
                }
            });

            AudioProgressBar.Maximum = Convert.ToInt32(length.TotalSeconds);
            AudioProgressBar.Value = Convert.ToInt32(position.TotalSeconds);

        }

        private void AudioProgressBar_Click(object sender, EventArgs e)
        {
            float absoluteMouse = (PointToClient(MousePosition).X - AudioProgressBar.Bounds.X);
            float calcFactor = AudioProgressBar.Width / (float)AudioProgressBar.Maximum;
            float relativeMouse = absoluteMouse / calcFactor;

            AudioProgressBar.Value = Convert.ToInt32(relativeMouse);
            mPlayer.Position = TimeSpan.FromSeconds(relativeMouse);
        }
        private void MaterialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count > 0)
            {
                var SongToPlay = materialListView1.SelectedItems[0];

                mPlayer.Open("C:/Users/" + Environment.UserName + "/Music/mPlayer/" + SongToPlay.Text, (MMDevice)DeviceBox.SelectedItem);
                mPlayer.Volume = VolumeSlider.Value;
                mPlayer.Play();
                NowPlayingTitle = SongToPlay.Text.Replace(".mp3", string.Empty);
                NowPlayingLabel.Text = SongToPlay.Text;
                timer1.Start();

                var SongTitleCleaned = ReplaceInvalidChars(SongToPlay.Text);
                var AlbumArtPathClean = "C:/Users/" + Environment.UserName + "/Music/mPlayer/Data/Thumbnails/" + SongTitleCleaned.Replace(".mp3", string.Empty) + ".jpg";
                if (!string.IsNullOrEmpty(AlbumArtPathClean) && File.Exists(AlbumArtPathClean))
                {
                    pictureBox1.Load(AlbumArtPathClean);
                } else
                {
                    pictureBox1.Image = Properties.Resources.DefaultAlbumArt;
                }
                materialListView1.HideSelection = true;
            }
        }

        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
            MusicDownload df = new MusicDownload();
            df.Show();

        }

        private void MaterialFlatButton2_Click(object sender, EventArgs e)
        {
            ResetMusicList();
        }

        public void ResetMusicList()
        {
            materialListView1.Items.Clear();
            foreach (var file in Directory.GetFiles("C:/Users/" + Environment.UserName + "/Music/mPlayer", "*.mp3")) //add each supported file to the list
            {
                string tempfilename = Path.GetFileName(file);
                materialListView1.Items.Add(tempfilename);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var mmdeviceEnumerator = new MMDeviceEnumerator())
            {
                using (
                    var mmdeviceCollection = mmdeviceEnumerator.EnumAudioEndpoints(DataFlow.Render, DeviceState.Active))
                {
                    foreach (var device in mmdeviceCollection)
                    {
                        _devices.Add(device);
                    }
                }
            }

            DeviceBox.DataSource = _devices;
            DeviceBox.DisplayMember = "FriendlyName";
            DeviceBox.ValueMember = "DeviceID";
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Form settingsform = new SettingsForm();
            settingsform.Show();
        }
    }
}
