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

namespace ChineseWord.BasePage
{
    public partial class DianTwoPage : Form
    {
        public DianTwoPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dianPage dian = new dianPage();
            dian.Width = this.Width;
            dian.Height = this.Height;
            dian.WindowState = this.WindowState;
            dian.Show();
            this.Hide();
        }

        private void DianTwoPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void T_Back_Click(object sender, EventArgs e)
        {
            int Width = this.Width;

            int Height = this.Height;
            BasicStrokes bs = new BasicStrokes();
            bs.Height = Height;
            bs.Width = Width;
            bs.WindowState = this.WindowState;
            this.Hide();
            bs.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "竖三点江";
            string FName = "DianTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string Name = "竖三点江";
            string FName = "DianTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string Name = "相背点六";
            string FName = "DianTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "相背点六";
            string FName = "DianTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string Name = "相向点丫";
            string FName = "DianTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "相向点丫";
            string FName = "DianTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string Name = "右点斗";
            string FName = "DianTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "右点斗";
            string FName = "DianTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string Name = "长点不";
            string FName = "DianTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "长点不";
            string FName = "DianTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string Name = "左点刃";
            string FName = "DianTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "左点刃";
            string FName = "DianTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string Name = "左右点小";
            string FName = "DianTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "左右点小";
            string FName = "DianTwoPage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string haarXmlPath = @"localsql\帮助文档.doc";
            string fileName = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\"));
            fileName = fileName.Substring(0, fileName.LastIndexOf("\\")) + "\\" + haarXmlPath;
            Process.Start(fileName);
        }
    }
}
