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

namespace ChineseWord.PianPangBuShou
{
    public partial class BaoWei : Form
    {
        public BaoWei()
        {
            InitializeComponent();
        }
        //包围床
        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "包围床";
            string FName = "BaoWei";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //包围床
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            linkLabel9_LinkClicked(null,null);
        }

        //返回
        private void T_Back_Click(object sender, EventArgs e)
        {
            int Width = this.Width;

            int Height = this.Height;
            PianPangBushou PPBS = new PianPangBushou();
            PPBS.Height = Height;
            PPBS.Width = Width;
            PPBS.WindowState = this.WindowState;
            this.Hide();
            PPBS.ShowDialog();
        }

        //关闭
        private void BaoWei_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
        //下一页
        private void button1_Click(object sender, EventArgs e)
        {
            BaoWeiTwo BaoWeitwo = new BaoWeiTwo();
            BaoWeitwo.Width = this.Width;
            BaoWeitwo.Height = this.Height;
            BaoWeitwo.WindowState = this.WindowState;
            BaoWeitwo.Show();
            this.Hide();
        }
        //包围戒
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "包围戒";
            string FName = "BaoWei";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //包围戒
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string Name = "包围戒";
            string FName = "BaoWei";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //包围魅
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "包围魅";
            string FName = "BaoWei";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //包围魅
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string Name = "包围魅";
            string FName = "BaoWei";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //包围尿
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "包围尿";
            string FName = "BaoWei";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //包围尿
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string Name = "包围尿";
            string FName = "BaoWei";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //包围起
        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "包围起";
            string FName = "BaoWei";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //包围起
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string Name = "包围起";
            string FName = "BaoWei";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //包围问
        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "包围问";
            string FName = "BaoWei";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //包围问
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string Name = "包围问";
            string FName = "BaoWei";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //包字框句
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "包字框句";
            string FName = "BaoWei";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //包字框句
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string Name = "包字框句";
            string FName = "BaoWei";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //病字头病
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "病字头病";
            string FName = "BaoWei";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //病字头病
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string Name = "病字头病";
            string FName = "BaoWei";
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

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            string haarXmlPath = @"localsql\帮助文档.doc";
            string fileName = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\"));
            fileName = fileName.Substring(0, fileName.LastIndexOf("\\")) + "\\" + haarXmlPath;
            Process.Start(fileName);
        }
    }
}
