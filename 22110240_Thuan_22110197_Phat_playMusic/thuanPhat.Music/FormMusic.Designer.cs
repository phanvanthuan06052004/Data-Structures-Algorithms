namespace thuanPhat.Music
{
    partial class FormMusic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMusic));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelBody = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddFavorite1 = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.Music = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.trackbarVolume = new Guna.UI2.WinForms.Guna2TrackBar();
            this.btnPause = new FontAwesome.Sharp.IconButton();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.btnPrev = new FontAwesome.Sharp.IconButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnMusicManagerment = new FontAwesome.Sharp.IconButton();
            this.btnFavorite = new FontAwesome.Sharp.IconButton();
            this.btnHomeMusicRepo = new FontAwesome.Sharp.IconButton();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Music)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelBody
            // 
            this.panelBody.AutoSize = true;
            this.panelBody.BackColor = System.Drawing.Color.Black;
            this.panelBody.BackgroundImage = global::thuanPhat.Music.Properties.Resources._79b3e821de78e415da6773d3d487d4a7cdb290ac;
            this.panelBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBody.Controls.Add(this.btnAddFavorite1);
            this.panelBody.Controls.Add(this.iconPictureBox1);
            this.panelBody.Controls.Add(this.Music);
            this.panelBody.Controls.Add(this.lblEnd);
            this.panelBody.Controls.Add(this.lblStart);
            this.panelBody.Controls.Add(this.guna2ProgressBar1);
            this.panelBody.Controls.Add(this.trackbarVolume);
            this.panelBody.Controls.Add(this.btnPause);
            this.panelBody.Controls.Add(this.btnNext);
            this.panelBody.Controls.Add(this.btnPlay);
            this.panelBody.Controls.Add(this.btnPrev);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(207, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(928, 633);
            this.panelBody.TabIndex = 1;
            // 
            // btnAddFavorite1
            // 
            this.btnAddFavorite1.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFavorite1.FlatAppearance.BorderSize = 0;
            this.btnAddFavorite1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFavorite1.ForeColor = System.Drawing.Color.Black;
            this.btnAddFavorite1.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnAddFavorite1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddFavorite1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddFavorite1.IconSize = 30;
            this.btnAddFavorite1.Location = new System.Drawing.Point(561, 320);
            this.btnAddFavorite1.Name = "btnAddFavorite1";
            this.btnAddFavorite1.Size = new System.Drawing.Size(82, 37);
            this.btnAddFavorite1.TabIndex = 18;
            this.btnAddFavorite1.UseVisualStyleBackColor = false;
            this.btnAddFavorite1.Click += new System.EventHandler(this.btnAddFavorite_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.VolumeHigh;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 31;
            this.iconPictureBox1.Location = new System.Drawing.Point(665, 325);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(39, 31);
            this.iconPictureBox1.TabIndex = 11;
            this.iconPictureBox1.TabStop = false;
            // 
            // Music
            // 
            this.Music.Enabled = true;
            this.Music.Location = new System.Drawing.Point(236, 51);
            this.Music.Name = "Music";
            this.Music.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Music.OcxState")));
            this.Music.Size = new System.Drawing.Size(462, 196);
            this.Music.TabIndex = 10;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEnd.Location = new System.Drawing.Point(720, 279);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(44, 16);
            this.lblEnd.TabIndex = 9;
            this.lblEnd.Text = "00 : 00";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblStart.Location = new System.Drawing.Point(165, 279);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(44, 16);
            this.lblStart.TabIndex = 8;
            this.lblStart.Text = "00 : 00";
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2ProgressBar1.Location = new System.Drawing.Point(228, 282);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2ProgressBar1.Size = new System.Drawing.Size(460, 10);
            this.guna2ProgressBar1.TabIndex = 7;
            this.guna2ProgressBar1.Text = "guna2ProgressBar1";
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ProgressBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2ProgressBar1_MouseDown);
            // 
            // trackbarVolume
            // 
            this.trackbarVolume.BackColor = System.Drawing.Color.Transparent;
            this.trackbarVolume.Location = new System.Drawing.Point(710, 319);
            this.trackbarVolume.Name = "trackbarVolume";
            this.trackbarVolume.Size = new System.Drawing.Size(122, 37);
            this.trackbarVolume.TabIndex = 6;
            this.trackbarVolume.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.trackbarVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.gtbVolume_Scroll);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.ForeColor = System.Drawing.Color.Black;
            this.btnPause.IconChar = FontAwesome.Sharp.IconChar.Stop;
            this.btnPause.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPause.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPause.IconSize = 30;
            this.btnPause.Location = new System.Drawing.Point(195, 319);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(82, 37);
            this.btnPause.TabIndex = 5;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.ForwardStep;
            this.btnNext.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.IconSize = 30;
            this.btnNext.Location = new System.Drawing.Point(473, 320);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(82, 37);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.Black;
            this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.Pause;
            this.btnPlay.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlay.IconSize = 30;
            this.btnPlay.Location = new System.Drawing.Point(385, 319);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(82, 37);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.ForeColor = System.Drawing.Color.Black;
            this.btnPrev.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            this.btnPrev.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrev.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrev.IconSize = 30;
            this.btnPrev.Location = new System.Drawing.Point(300, 319);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(82, 37);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BackgroundImage = global::thuanPhat.Music.Properties.Resources._1080x2400_HD_Wallpaper_023_303x610;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.btnExit);
            this.guna2Panel1.Controls.Add(this.btnMusicManagerment);
            this.guna2Panel1.Controls.Add(this.btnFavorite);
            this.guna2Panel1.Controls.Add(this.btnHomeMusicRepo);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(207, 633);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(28, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "ℤ𝕀ℕ𝔾 𝕄ℙ𝟛";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.CausesValidation = false;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnExit.IconColor = System.Drawing.Color.Crimson;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 60;
            this.btnExit.Location = new System.Drawing.Point(0, 457);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(207, 146);
            this.btnExit.TabIndex = 3;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMusicManagerment
            // 
            this.btnMusicManagerment.BackColor = System.Drawing.Color.Transparent;
            this.btnMusicManagerment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMusicManagerment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicManagerment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMusicManagerment.IconChar = FontAwesome.Sharp.IconChar.FileAudio;
            this.btnMusicManagerment.IconColor = System.Drawing.Color.Crimson;
            this.btnMusicManagerment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMusicManagerment.IconSize = 60;
            this.btnMusicManagerment.Location = new System.Drawing.Point(0, 320);
            this.btnMusicManagerment.Name = "btnMusicManagerment";
            this.btnMusicManagerment.Size = new System.Drawing.Size(207, 137);
            this.btnMusicManagerment.TabIndex = 2;
            this.btnMusicManagerment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusicManagerment.UseVisualStyleBackColor = false;
            this.btnMusicManagerment.Click += new System.EventHandler(this.btnMusicManagerment_Click);
            // 
            // btnFavorite
            // 
            this.btnFavorite.AllowDrop = true;
            this.btnFavorite.BackColor = System.Drawing.Color.Transparent;
            this.btnFavorite.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorite.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.btnFavorite.IconColor = System.Drawing.Color.Crimson;
            this.btnFavorite.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFavorite.IconSize = 60;
            this.btnFavorite.Location = new System.Drawing.Point(0, 183);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(207, 137);
            this.btnFavorite.TabIndex = 1;
            this.btnFavorite.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFavorite.UseVisualStyleBackColor = false;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // btnHomeMusicRepo
            // 
            this.btnHomeMusicRepo.BackColor = System.Drawing.Color.Transparent;
            this.btnHomeMusicRepo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHomeMusicRepo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeMusicRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeMusicRepo.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.btnHomeMusicRepo.IconColor = System.Drawing.Color.Red;
            this.btnHomeMusicRepo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHomeMusicRepo.IconSize = 130;
            this.btnHomeMusicRepo.Location = new System.Drawing.Point(0, 0);
            this.btnHomeMusicRepo.Name = "btnHomeMusicRepo";
            this.btnHomeMusicRepo.Size = new System.Drawing.Size(207, 183);
            this.btnHomeMusicRepo.TabIndex = 0;
            this.btnHomeMusicRepo.UseVisualStyleBackColor = false;
            this.btnHomeMusicRepo.Click += new System.EventHandler(this.btnHomeMusicRepo_Click);
            // 
            // FormMusic
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1135, 633);
            this.ControlBox = false;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.guna2Panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMusic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "𝕄𝕦𝕤𝕚𝕔";
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Music)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private FontAwesome.Sharp.IconButton btnHomeMusicRepo;
        private Guna.UI2.WinForms.Guna2Panel panelBody;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMusicManagerment;
        private FontAwesome.Sharp.IconButton btnFavorite;
        private FontAwesome.Sharp.IconButton btnPause;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnPlay;
        private FontAwesome.Sharp.IconButton btnPrev;
        private Guna.UI2.WinForms.Guna2TrackBar trackbarVolume;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private AxWMPLib.AxWindowsMediaPlayer Music;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnAddFavorite1;
        private System.Windows.Forms.Label label1;
    }
}

