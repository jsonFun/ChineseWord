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
    public partial class DuTiZiTwoPage : Form
    {
        public DuTiZiTwoPage()
        {
            InitializeComponent();
        }

        private void DuTiZiTwoPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
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
        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            DuTiZiPage dtp = new DuTiZiPage();
            dtp.Width = this.Width;
            dtp.Height = this.Height;
            dtp.WindowState = this.WindowState;
            dtp.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string Name = "匆";
            string FName = "DuTiZiTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string Name = "寸";
            string FName = "DuTiZiTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string Name = "太";
            string FName = "DuTiZiTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string Name = "丹";
            string FName = "DuTiZiTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string Name = "刀";
            string FName = "DuTiZiTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string Name = "电";
            string FName = "DuTiZiTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string Name = "丁";
            string FName = "DuTiZiTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string Name = "东";
            string FName = "DuTiZiTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string Name = "斗";
            string FName = "DuTiZiTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            string Name = "儿";
            string FName = "DuTiZiTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            string Name = "而";
            string FName = "DuTiZiTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            string Name = "耳";
            string FName = "DuTiZiTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            string Name = "二";
            string FName = "DuTiZiTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            string Name = "方";
            string FName = "DuTiZiTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            string Name = "飞";
            string FName = "DuTiZiTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            string Name = "丰";
            string FName = "DuTiZiTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            string Name = "夫";
            string FName = "DuTiZiTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            string Name = "父";
            string FName = "DuTiZiTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            string Name = "甘";
            string FName = "DuTiZiTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            string Name = "个";
            string FName = "DuTiZiTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            string Name = "更";
            string FName = "DuTiZiTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            string Name = "工";
            string FName = "DuTiZiTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            string Name = "弓";
            string FName = "DuTiZiTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            string Name = "瓜";
            string FName = "DuTiZiTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            DuTiZiThreePage dtp = new DuTiZiThreePage();
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
