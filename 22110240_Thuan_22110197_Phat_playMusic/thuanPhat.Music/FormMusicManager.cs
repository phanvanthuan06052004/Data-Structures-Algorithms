using MusicRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace thuanPhat.Music
{
    public partial class FormMusicManager : Form
    {
        private static LinkedList2 _dsList = new LinkedList2();
        private static bool _inited = true;
        //private static List<Audio> _dsAudio = new List<Audio>();
        private static LinkedList2 _dsAudio = new LinkedList2();
        private List<Audio> list = new List<Audio>();
        public FormMusicManager(LinkedList2 music)
        {
            InitializeComponent();
            _dsList = music;
            saveData(music);


        }
        private void saveData(LinkedList2 dsList)
        {
            Console.WriteLine(dsList.count());
            //_dsAudio.Clear();
            _dsAudio = new LinkedList2();
            for (Node i = dsList.GetFirst(); i != null; i = i.next)
                /*_dsAudio.Add(new Audio(i.data.name, i.data.URL, false));*/
                _dsAudio.AddNode(new Audio(i.data.name, i.data.URL, false));
            dgvListMusic.DataSource = null;
            dgvListMusic.AutoGenerateColumns = false;
            List<Audio> list1 = new List<Audio>();
            Node node = _dsAudio.GetFirst();
            for (int i = 1; i <= _dsAudio.count(); i++)
            {
                list1.Add(node.data);
                node = node.next;
            }
            //  dgvListMusic.DataSource = _dsAudio;
            dgvListMusic.DataSource = list1;
        }

        //public LinkedList2 GetDataManager()
        //{
        //    LinkedList2 tmp = new LinkedList2();
        //    for(int i= 0; i< _dsAudio.Count(); i++)
        //    {
        //        tmp.AddNode(new Audio(_dsAudio[i].name, _dsAudio[i].URL, false));
        //    }
        //    return tmp;
        //}

        public bool closethis()
        {
            _inited = false;
            return _inited;
        }

       
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            MusicRepo musicRepo = new MusicRepo();
            //LinkedList2 tmp = GetDataManager();
            LinkedList2 tmp = _dsAudio;
            musicRepo.getMusicList(tmp);
            FormMusic music = new FormMusic(musicRepo);
            dgvListMusic.DataSource = null;
            music.Show();
        }

        private void showMusic(object sender, EventArgs e)
        {
            if(dgvListMusic.SelectedRows.Count > 0 ) 
            {
                DataGridViewRow selecRow = dgvListMusic.SelectedRows[0];
                txtName.Text = selecRow.Cells[0].Value.ToString();
                txtURL.Text = selecRow.Cells[1].Value.ToString();
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult tmp = dlgOpenFile.ShowDialog();
            if(tmp == DialogResult.OK)
            {
                txtURL.Text = dlgOpenFile.FileName.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = false;
            String name = txtName.Text;
            //for(int i = 0; i < _dsAudio.Count; i++)
            //{
            //    if (_dsAudio[i].name == name)
            //    {
            //        MessageBox.Show("The music name already exists. Please enter another one.","Information",
            //            MessageBoxButtons.OK,MessageBoxIcon.Information);
            //        check = true;
            //        break;
            //    }
            //}
            Node node = _dsAudio.GetFirst();
            for (int i = 1; i <= _dsAudio.count(); i++)
            {
                if (node.data.name == name)
                {
                    MessageBox.Show("The music name already exists. Please enter another one.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    check = true;
                    break;
                }
                node = node.next;
            }
            if ( txtURL.Text != "") 
            {
                if(check != true)
                {
                    Audio tmp = new Audio(txtName.Text, txtURL.Text, false);
                    // _dsAudio.Add(tmp);
                    _dsAudio.AddNode(tmp);
                    list.Add(tmp);
                    dgvListMusic.DataSource = null;
                    dgvListMusic.AutoGenerateColumns = false;
                    // dgvListMusic.DataSource = _dsAudio;
                    List<Audio> list1 = new List<Audio>();
                    Node node1 = _dsAudio.GetFirst();
                    for (int i = 1; i <= _dsAudio.count(); i++)
                    {
                        list1.Add(node1.data);
                        node1 = node1.next;
                    }
                    dgvListMusic.DataSource = list1;
                }
            }
            else
            {
                MessageBox.Show("Please update the music information."
                    , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            bool check = false;
            Node node = _dsAudio.GetFirst();
            Node node1 = _dsAudio.GetFirst();
            List<Audio> list1 = new List<Audio>();
            for (int i = 0; i < _dsAudio.count(); i++)
            {
                if (node.data.name == name)
                {
                    _dsAudio.RemoveAt(i);
                    check = true;
                    dgvListMusic.DataSource = null;
                    dgvListMusic.AutoGenerateColumns = false;
                    for (int j = 1; j <= _dsAudio.count(); j++)
                    {
                        list1.Add(node1.data);
                        node1 = node1.next;
                    }
                    dgvListMusic.DataSource = list1;
                    break;
                }
                node = node.next;
            }
            
            if (!check)
             {
                MessageBox.Show("Not found", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void dgvListMusic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = dlgOpenFile.ShowDialog();
            List<Audio> list1 = new List<Audio>();
            if (dgvListMusic.Columns[e.ColumnIndex].Name == "btnAdd")
            {
                if (result == DialogResult.OK)
                {
                    int index = dgvListMusic.CurrentCell.RowIndex;
                    //for (int i = 0; i < _dsAudio.Count() - 1; i++)
                    //{
                    //    if (_dsAudio[i].name.Equals(dgvListMusic.Rows[index].Cells[0].Value.ToString().Trim()))
                    //    {
                    //        _dsAudio[i].URL = dlgOpenFile.FileName.ToString();  
                    //    }
                    //}
                    Node node1 = _dsAudio.GetFirst();
                    
                    for (int i = 0; i < _dsAudio.count() ; i++)
                    {
                        if (node1.data.name.Equals(dgvListMusic.Rows[index].Cells[0].Value.ToString().Trim()))
                        {
                            node1.data.URL = dlgOpenFile.FileName.ToString();
                        }
                        list1.Add(node1.data);
                        node1 = node1.next;
                    }
                }
            }
            dgvListMusic.DataSource = null;
            dgvListMusic.AutoGenerateColumns = false;
            //dgvListMusic.DataSource = _dsAudio;
            dgvListMusic.DataSource = list1;
        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    string tmp = txtSearch.Text;
        //    var k = _dsAudio.Where(s => s.name.ToLower().Contains(tmp)).ToList();
        //    dgvSearch.DataSource = null;
        //    dgvSearch.AutoGenerateColumns = false;
        //    dgvSearch.DataSource = k;
        //}
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tmp = txtSearch.Text;
            //var k = _dsAudio.Where(s => s.name.ToLower().Contains(tmp)).ToList();
            Node node = _dsAudio.GetFirst();
            List<Audio> list1 = new List<Audio>();
            for (int i = 0; i < _dsAudio.count(); i++)
            {
                if (node.data.name.ToLower().Contains(tmp.ToLower()))
                 list1.Add(node.data);
                node = node.next;
            }
            dgvSearch.DataSource = null;
            dgvSearch.AutoGenerateColumns = false;
            dgvSearch.DataSource = list1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSortUp_Click(object sender, EventArgs e)
        {
           
                Node node = _dsAudio.GetFirst();
                for (Node i = node; i.next != null; i = i.next)
                    for (Node j = i.next; j != null; j = j.next)
                    {
                        if (i.data.name.CompareTo(j.data.name) > 0)
                        {
                            string tmp = j.data.name;
                            j.data.name = i.data.name;
                            i.data.name = tmp;
                        }
                    }
                List<Audio> list1 = new List<Audio>();
                for (int i = 0; i < _dsAudio.count(); i++)
                {
                    list1.Add(node.data);
                    node = node.next;
                }
                dgvListMusic.DataSource = null;
                dgvListMusic.AutoGenerateColumns = false;
                //dgvListMusic.DataSource = _dsAudio;
                dgvListMusic.DataSource = list1;
        }

        private void btnSortDown_Click(object sender, EventArgs e)
        {
                Node node = _dsAudio.GetFirst();
                for (Node i = node; i != null; i = i.next)
                    for (Node j = _dsAudio.GetLast(); j != i; j = j.prev)
                    {
                        if (i.data.name.CompareTo(j.data.name) < 0)
                        {
                            string tmp = j.data.name;
                            j.data.name = i.data.name;
                            i.data.name = tmp;
                        }
                    }
                List<Audio> list1 = new List<Audio>();
                for (int i = 0; i < _dsAudio.count(); i++)
                {
                    list1.Add(node.data);
                    node = node.next;
                }
                dgvListMusic.DataSource = null;
                dgvListMusic.AutoGenerateColumns = false;
                //dgvListMusic.DataSource = _dsAudio;
                dgvListMusic.DataSource = list1;
  
        }
    }
}
