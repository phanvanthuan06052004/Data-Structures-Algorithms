using MusicRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuanPhat.Music
{
    public partial class FormMusic : Form
    {
        public static MusicRepo MusicRepo = new MusicRepo();
        public static Node fNode;
        public static LinkedList2 _ListFavorite = new LinkedList2();
        public FormMusic()
        {
            InitializeComponent();
            Music.uiMode = "none";
            MusicRepo.Innit();
            Node tNode = MusicRepo.getAll().GetFirst();
            
            fNode = tNode;
            _ListFavorite = MusicRepo.getFavoriteList();
            //Music.URL = fNode.data.URL;
            //Music.Ctlcontrols.play();
            timer1.Start();
            trackbarVolume.Value = 15;
            //var result = MusicRepo.getAll();
            //Console.WriteLine(result.count());

            // Console.WriteLine($"Number of items in result: {result.count()}");

            /* foreach (var audio in result)
             {
                 Console.WriteLine($"Name: {audio.name}, URL: {audio.URL}, Favorite: {audio.Favorite}");
             }*/

            /*dgvLMusic.DataSource = null;
            dgvLMusic.AutoGenerateColumns = false;
            dgvLMusic.DataSource = result;*/
            /*var result = MusicRepo.getAll();
            dgvLMusic.DataSource = null;
            dgvLMusic.AutoGenerateColumns = false;
            List<Audio> list1 = new List<Audio>();
            Node node1 = result.GetFirst();
            for (int i = 1; i <= result.count(); i++)
            {
                list1.Add(node1.data);
                node1 = node1.next;
            }
            dgvLMusic.DataSource = list1;*/
            
        }
        public FormMusic(MusicRepo x)
        {
            InitializeComponent();
            Music.uiMode = "none";
            MusicRepo = x;
            Node node = MusicRepo.getMusicList(x.getAll()).GetFirst();
            fNode = node;
            _ListFavorite = MusicRepo.getFavoriteList();
            Music.URL = fNode.data.URL;
            Music.Ctlcontrols.play();
            timer1.Start();
            trackbarVolume.Value = 15;
            /*var result = MusicRepo.getAll();
            dgvLMusic.DataSource = null;
            dgvLMusic.AutoGenerateColumns = false;
            dgvLMusic.DataSource = result;*/
            var result = MusicRepo.getAll();
            //dgvLMusic.DataSource = null;
           // dgvLMusic.AutoGenerateColumns = false;
           /* List<Audio> list1 = new List<Audio>();
            Node node1 = result.GetFirst();
            for (int i = 1; i <= result.count(); i++)
            {
                list1.Add(node1.data);
                node1 = node1.next;
            }
            dgvLMusic.DataSource = list1;*/

        }
        // private Form currenFormChild;

        /* private void openChildForm(Form chidForm)
         {
             if (currenFormChild != null)
             {
                 currenFormChild.Close();
             }
             currenFormChild = chidForm;
             chidForm.TopLevel = false;
             chidForm.FormBorderStyle = FormBorderStyle.None;
             chidForm.Dock = DockStyle.Fill;
             panelBody.Controls.Add(chidForm);
             chidForm.BringToFront();
             chidForm.Show();
         }*/
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMusicManagerment_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormMusicManager());
            FormMusicManager form = new FormMusicManager(MusicRepo.getAll());
            form.Show();
            Music.Ctlcontrols.stop();
            this.Hide();
           
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Music.Ctlcontrols.play();
            //btnPlay.Visible = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Music.Ctlcontrols.pause();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (fNode == MusicRepo.getAll().GetLast() || fNode == _ListFavorite.GetLast())
            {
                fNode = fNode;

                if (fNode.data.Favorite == true)
                {
                    btnAddFavorite1.IconFont = FontAwesome.Sharp.IconFont.Solid;
                }
                else
                {
                    btnAddFavorite1.IconFont = FontAwesome.Sharp.IconFont.Regular;
                }
            }
            else
            {
                fNode = fNode.next;
                if (fNode.data.Favorite == true)
                    btnAddFavorite1.IconFont = FontAwesome.Sharp.IconFont.Solid;
                else
                    btnAddFavorite1.IconFont = FontAwesome.Sharp.IconFont.Regular;
            }
            Music.URL = fNode.data.URL;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

            if (fNode == MusicRepo.getAll().GetFirst() || fNode == _ListFavorite.GetFirst())
            {
                fNode = fNode;
                if (fNode.data.Favorite == true)
                {
                    btnAddFavorite1.IconFont = FontAwesome.Sharp.IconFont.Solid;
                }
                else
                {
                    btnAddFavorite1.IconFont = FontAwesome.Sharp.IconFont.Regular;
                }
            }
            else
            {
                fNode = fNode.prev;
                if (fNode.data.Favorite == true)
                    btnAddFavorite1.IconFont = FontAwesome.Sharp.IconFont.Solid;
                else
                    btnAddFavorite1.IconFont = FontAwesome.Sharp.IconFont.Regular;
            }
            Music.URL = fNode.data.URL;
        }




        private void btnAddFavorite_Click(object sender, EventArgs e)
        {
            if(btnAddFavorite1.IconFont == FontAwesome.Sharp.IconFont.Regular)
            {
                btnAddFavorite1.IconFont = FontAwesome.Sharp.IconFont.Solid;
                fNode.data.Favorite = true;
                Audio tmp = fNode.data;
                _ListFavorite.AddNode(tmp);
            }
            else
            {
                btnAddFavorite1.IconFont = FontAwesome.Sharp.IconFont.Regular;
                fNode.data.Favorite = false;
                Audio tmp = fNode.data;
                _ListFavorite.removeNode();
            }
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            if(_ListFavorite.count() == 0)
            {
                MessageBox.Show("Danh sach Favorite dang rong!!!");


            }
            else
            {
                fNode = _ListFavorite.GetFirst();
                Music.URL = fNode.data.URL;
                btnAddFavorite1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Music.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                guna2ProgressBar1.Maximum = (int)Music.Ctlcontrols.currentItem.duration;
                guna2ProgressBar1.Value = (int)Music.Ctlcontrols.currentPosition;
            }
            lblStart.Text = Music.Ctlcontrols.currentPositionString.ToString();
            if (Music.currentMedia != null)
            {
                lblEnd.Text = Music.Ctlcontrols.currentItem.durationString.ToString();
            }
        }

        private void guna2ProgressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            Music.Ctlcontrols.currentPosition = Music.currentMedia.duration * e.X / guna2ProgressBar1.Width;
        }

        private void gtbVolume_Scroll(object sender, ScrollEventArgs e)
        {
            Music.settings.volume = trackbarVolume.Value;
        }

        private void btnHomeMusicRepo_Click(object sender, EventArgs e)
        {
            fNode = MusicRepo.getAll().GetFirst();
            Music.URL = fNode.data.URL;
            if(fNode.data.Favorite == true) btnAddFavorite1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            else btnAddFavorite1.IconFont = FontAwesome.Sharp.IconFont.Regular;
        }

        private void dgvLMusic_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
