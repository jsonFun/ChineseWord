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
    public partial class ZiTouThree : Form
    {
        public ZiTouThree()
        {
            InitializeComponent();
        }
        //四字头罗
        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "四字头罗";
            string FName = "ZiTouThree";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //四字头罗
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
        private void ZiTouThree_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
        //上一页
        private void button1_Click(object sender, EventArgs e)
        {
            ZiTouTwo ZiTouTwo = new ZiTouTwo();
            ZiTouTwo.Width = this.Width;
            ZiTouTwo.Height = this.Height;
            ZiTouTwo.WindowState = this.WindowState;
            ZiTouTwo.Show();
            this.Hide();
        }

        //秃宝盖军
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "秃宝盖军";
            string FName = "ZiTouThree";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //秃宝盖军
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string Name = "秃宝盖军";
            string FName = "ZiTouThree";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //小子头当
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "小子头当";
            string FName = "ZiTouThree";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //小子头当
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string Name = "小子头当";
            string FName = "ZiTouThree";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //穴宝盖空
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "穴宝盖空";
            string FName = "ZiTouThree";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //穴宝盖空
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string Name = "穴宝盖空";
            string FName = "ZiTouThree";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //雨字头雪
        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "雨字头雪";
            string FName = "ZiTouThree";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //雨字头雪
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string Name = "雨字头雪";
            string FName = "ZiTouThree";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //爪字头采
        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "爪字头采";
            string FName = "ZiTouThree";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //爪字头采
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string Name = "爪字头采";
            string FName = "ZiTouThree";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //竹字头笑
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "竹字头笑";
            string FName = "ZiTouThree";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //竹字头笑
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string Name = "竹字头笑";
            string FName = "ZiTouThree";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string haarXmlPath = @"localsql\帮助文档.doc";
            string fileName = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\"));
            fileName = fileName.Substring(0, fileName.LastIndexOf("\\")) + "\\" + haarXmlPath;
            Process.Start(fileName);
        }
    }
}
