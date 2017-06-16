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
    public partial class BaoWeiTwo : Form
    {
        public BaoWeiTwo()
        {
            InitializeComponent();
        }
        //风字框风
        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "风字框风";
            string FName = "BaoWeiTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //风字框风
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
        private void BaoWeiTwo_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
        //上一页
        private void button1_Click(object sender, EventArgs e)
        {
            BaoWei BaoWei = new BaoWei();
            BaoWei.Width = this.Width;
            BaoWei.Height = this.Height;
            BaoWei.WindowState = this.WindowState;
            BaoWei.Show();
            this.Hide();
        }
        //国字框
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "国字框";
            string FName = "BaoWeiTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //国字框
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string Name = "国字框";
            string FName = "BaoWeiTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //过字底过
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "过字底过";
            string FName = "BaoWeiTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //过字底过
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string Name = "过字底过";
            string FName = "BaoWeiTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //虎子头虎
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "虎子头虎";
            string FName = "BaoWeiTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //虎子头虎
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string Name = "虎子头虎";
            string FName = "BaoWeiTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //老子头老
        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "老子头老";
            string FName = "BaoWeiTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //老子头老
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string Name = "老子头老";
            string FName = "BaoWeiTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //区字框区
        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "区字框区";
            string FName = "BaoWeiTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //区字框区
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string Name = "区字框区";
            string FName = "BaoWeiTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //山子框凶
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "山子框凶";
            string FName = "BaoWeiTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //山子框凶
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string Name = "山子框凶";
            string FName = "BaoWeiTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //同字框同
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "同字框同";
            string FName = "BaoWeiTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //同字框同
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string Name = "同字框同";
            string FName = "BaoWeiTwo";
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
