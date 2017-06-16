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
    public partial class ZuoZiPangTwo : Form
    {
        public ZuoZiPangTwo()
        {
            InitializeComponent();
        }
        //两点水冷
        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "两点水冷";
            string FName = "ZuoZiPangTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //两点水冷
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
        private void ZuoZiPangTwo_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
        //上一页
        private void button1_Click(object sender, EventArgs e)
        {
            ZuoZiPang ZuoZiPang = new ZuoZiPang();
            ZuoZiPang.Width = this.Width;
            ZuoZiPang.Height = this.Height;
            ZuoZiPang.WindowState = this.WindowState;
            ZuoZiPang.Show();
            this.Hide();
        }
        //下一页
        private void button2_Click(object sender, EventArgs e)
        {
            ZuoZiPangThree ZuoZiPangThree = new ZuoZiPangThree();
            ZuoZiPangThree.Width = this.Width;
            ZuoZiPangThree.Height = this.Height;
            ZuoZiPangThree.WindowState = this.WindowState;
            ZuoZiPangThree.Show();
            this.Hide();
        }
        //金字旁针
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "金字旁针";
            string FName = "ZuoZiPangTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //金字旁针
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string Name = "金字旁针";
            string FName = "ZuoZiPangTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //三点水江
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "三点水江";
            string FName = "ZuoZiPangTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //三点水江
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string Name = "三点水江";
            string FName = "ZuoZiPangTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //食字旁饭
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "食字旁饭";
            string FName = "ZuoZiPangTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //食字旁饭
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string Name = "食字旁饭";
            string FName = "ZuoZiPangTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //示字旁社
        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "示字旁社";
            string FName = "ZuoZiPangTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //示字旁社
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string Name = "示字旁社";
            string FName = "ZuoZiPangTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //竖心旁情
        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "竖心旁情";
            string FName = "ZuoZiPangTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //竖心旁情
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string Name = "竖心旁情";
            string FName = "ZuoZiPangTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //双人旁行
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "双人旁行";
            string FName = "ZuoZiPangTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //双人旁行
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string Name = "双人旁行";
            string FName = "ZuoZiPangTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //提手旁打
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "提手旁打";
            string FName = "ZuoZiPangTwo";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }
        //提手旁打
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string Name = "提手旁打";
            string FName = "ZuoZiPangTwo";
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
