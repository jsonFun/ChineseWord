using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChineseWord.DutiziPage
{
    public partial class DuTiZiPage : Form
    {
        public DuTiZiPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void T_Back_Click(object sender, EventArgs e)
        {
            int Width = this.Width;

            int Height = this.Height;
            Home Home = new Home();
            Home.Height = Height;
            Home.Width = Width;
            Home.WindowState = this.WindowState;
            this.Hide();
            Home.ShowDialog();
        }

        private void DuTiZiPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string Name = "八";
            string FName = "DuTiZiPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string Name = "巴";
            string FName = "DuTiZiPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string Name = "白";
            string FName = "DuTiZiPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string Name = "百";
            string FName = "DuTiZiPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string Name = "办";
            string FName = "DuTiZiPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string Name = "半";
            string FName = "DuTiZiPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string Name = "本";
            string FName = "DuTiZiPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string Name = "币";
            string FName = "DuTiZiPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string Name = "必";
            string FName = "DuTiZiPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            string Name = "不";
            string FName = "DuTiZiPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            string Name = "才";
            string FName = "DuTiZiPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            string Name = "册";
            string FName = "DuTiZiPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            string Name = "叉";
            string FName = "DuTiZiPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            string Name = "产";
            string FName = "DuTiZiPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            string Name = "车";
            string FName = "DuTiZiPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            string Name = "承";
            string FName = "DuTiZiPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            string Name = "尺";
            string FName = "DuTiZiPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            string Name = "斥";
            string FName = "DuTiZiPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            string Name = "虫";
            string FName = "DuTiZiPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            string Name = "丑";
            string FName = "DuTiZiPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            string Name = "出";
            string FName = "DuTiZiPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            string Name = "川";
            string FName = "DuTiZiPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            string Name = "串";
            string FName = "DuTiZiPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            string Name = "垂";
            string FName = "DuTiZiPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DuTiZiTwoPage dtp = new DuTiZiTwoPage();
            dtp.Width = this.Width;
            dtp.Height = this.Height;
            dtp.WindowState = this.WindowState;
            dtp.Show();
            this.Hide();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            string haarXmlPath = @"localsql\帮助文档.doc";
            string fileName = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\"));
            fileName = fileName.Substring(0, fileName.LastIndexOf("\\")) + "\\" + haarXmlPath;
            Process.Start(fileName);
        }
    }
}
