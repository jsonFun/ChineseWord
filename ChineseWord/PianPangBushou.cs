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

namespace ChineseWord
{
    public partial class PianPangBushou : Form
    {
        public PianPangBushou()
        {
            InitializeComponent();
        }

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

       

        private void PianPangBushou_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
        //包围
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            PianPangBuShou.BaoWei pie = new PianPangBuShou.BaoWei();
            pie.Width = this.Width;
            pie.Height = this.Height;
            pie.WindowState = this.WindowState;
            pie.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PianPangBuShou.ZiTou pie = new PianPangBuShou.ZiTou();
            pie.Width = this.Width;
            pie.Height = this.Height;
            pie.WindowState = this.WindowState;
            pie.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PianPangBuShou.ZiDi ZiDi = new PianPangBuShou.ZiDi();
            ZiDi.Width = this.Width;
            ZiDi.Height = this.Height;
            ZiDi.WindowState = this.WindowState;
            ZiDi.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PianPangBuShou.ZuoZiPang ZuoZiPang = new PianPangBuShou.ZuoZiPang();
            ZuoZiPang.Width = this.Width;
            ZuoZiPang.Height = this.Height;
            ZuoZiPang.WindowState = this.WindowState;
            ZuoZiPang.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PianPangBuShou.YouZiPang YouZiPang = new PianPangBuShou.YouZiPang();
            YouZiPang.Width = this.Width;
            YouZiPang.Height = this.Height;
            YouZiPang.WindowState = this.WindowState;
            YouZiPang.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string haarXmlPath = @"localsql\帮助文档.doc";
            string fileName = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\"));
            fileName = fileName.Substring(0, fileName.LastIndexOf("\\")) + "\\" + haarXmlPath;
            Process.Start(fileName);
        }
    }
}
