namespace mPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AudioProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.NowPlayingLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PauseButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.PlayButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.VolumeSlider = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PositionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.VolumeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DeviceBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AudioProgressBar
            // 
            this.AudioProgressBar.BackColor = System.Drawing.Color.White;
            this.AudioProgressBar.Depth = 0;
            this.AudioProgressBar.Location = new System.Drawing.Point(12, 685);
            this.AudioProgressBar.Maximum = 999;
            this.AudioProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.AudioProgressBar.Name = "AudioProgressBar";
            this.AudioProgressBar.Size = new System.Drawing.Size(1056, 5);
            this.AudioProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.AudioProgressBar.TabIndex = 0;
            this.AudioProgressBar.Click += new System.EventHandler(this.AudioProgressBar_Click);
            // 
            // NowPlayingLabel
            // 
            this.NowPlayingLabel.Depth = 0;
            this.NowPlayingLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.NowPlayingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NowPlayingLabel.Location = new System.Drawing.Point(541, 750);
            this.NowPlayingLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NowPlayingLabel.Name = "NowPlayingLabel";
            this.NowPlayingLabel.Size = new System.Drawing.Size(527, 36);
            this.NowPlayingLabel.TabIndex = 3;
            this.NowPlayingLabel.Text = "No Song Playing";
            this.NowPlayingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PauseButton
            // 
            this.PauseButton.AutoSize = true;
            this.PauseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PauseButton.Depth = 0;
            this.PauseButton.Icon = null;
            this.PauseButton.Location = new System.Drawing.Point(313, 750);
            this.PauseButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PauseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Primary = false;
            this.PauseButton.Size = new System.Drawing.Size(64, 36);
            this.PauseButton.TabIndex = 4;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.AutoSize = true;
            this.PlayButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlayButton.Depth = 0;
            this.PlayButton.Icon = null;
            this.PlayButton.Location = new System.Drawing.Point(250, 750);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PlayButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Primary = false;
            this.PlayButton.Size = new System.Drawing.Size(55, 36);
            this.PlayButton.TabIndex = 5;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // VolumeSlider
            // 
            this.VolumeSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.VolumeSlider.Location = new System.Drawing.Point(395, 724);
            this.VolumeSlider.Maximum = 100;
            this.VolumeSlider.Name = "VolumeSlider";
            this.VolumeSlider.Size = new System.Drawing.Size(135, 45);
            this.VolumeSlider.TabIndex = 7;
            this.VolumeSlider.TabStop = false;
            this.VolumeSlider.TickFrequency = 25;
            this.VolumeSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.VolumeSlider.Value = 100;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // PositionLabel
            // 
            this.PositionLabel.Depth = 0;
            this.PositionLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.PositionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PositionLabel.Location = new System.Drawing.Point(950, 696);
            this.PositionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(118, 21);
            this.PositionLabel.TabIndex = 10;
            this.PositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialListView1
            // 
            this.materialListView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Music});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(12, 185);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(1056, 477);
            this.materialListView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.materialListView1.TabIndex = 12;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.SelectedIndexChanged += new System.EventHandler(this.MaterialListView1_SelectedIndexChanged);
            // 
            // Music
            // 
            this.Music.Text = "Music";
            this.Music.Width = 1054;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(925, 77);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(142, 36);
            this.materialFlatButton1.TabIndex = 13;
            this.materialFlatButton1.Text = "Download Music";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.MaterialFlatButton1_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(773, 77);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(125, 36);
            this.materialFlatButton2.TabIndex = 14;
            this.materialFlatButton2.Text = "Refresh Music";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.MaterialFlatButton2_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(391, 773);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(73, 23);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "Volume";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.Depth = 0;
            this.VolumeLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.VolumeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.VolumeLabel.Location = new System.Drawing.Point(492, 773);
            this.VolumeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(38, 23);
            this.VolumeLabel.TabIndex = 16;
            this.VolumeLabel.Text = "100";
            this.VolumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pictureBox1.Image = global::mPlayer.Properties.Resources.DefaultAlbumArt;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(12, 696);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // DeviceBox
            // 
            this.DeviceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DeviceBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeviceBox.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceBox.FormattingEnabled = true;
            this.DeviceBox.Location = new System.Drawing.Point(250, 811);
            this.DeviceBox.Name = "DeviceBox";
            this.DeviceBox.Size = new System.Drawing.Size(280, 25);
            this.DeviceBox.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 863);
            this.Controls.Add(this.DeviceBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.VolumeLabel);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.VolumeSlider);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.NowPlayingLabel);
            this.Controls.Add(this.AudioProgressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mPlayer | Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialProgressBar AudioProgressBar;
        private MaterialSkin.Controls.MaterialLabel NowPlayingLabel;
        private MaterialSkin.Controls.MaterialFlatButton PauseButton;
        private MaterialSkin.Controls.MaterialFlatButton PlayButton;
        private System.Windows.Forms.TrackBar VolumeSlider;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialLabel PositionLabel;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader Music;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel VolumeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox DeviceBox;
    }
}

