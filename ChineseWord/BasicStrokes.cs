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
    public partial class BasicStrokes : Form
    {
        public BasicStrokes()
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

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            int Width = this.Width;

            int Height = this.Height;
            HengPage Heng = new HengPage();
            Heng.Height = Height;
            Heng.Width = Width;
            Heng.WindowState = this.WindowState;
            this.Hide();
            Heng.ShowDialog();
        }

        private void BasicStrokes_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            int Width = this.Width;

            int Height = this.Height;
            ShuPage shu = new ShuPage();
            shu.Height = Height;
            shu.Width = Width;
            shu.WindowState = this.WindowState;
            this.Hide();
            shu.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            int Width = this.Width;

            int Height = this.Height;
            PiePage Pie = new PiePage();
            Pie.Height = Height;
            Pie.Width = Width;
            Pie.WindowState = this.WindowState;
            this.Hide();
            Pie.ShowDialog();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            int Width = this.Width;

            int Height = this.Height;
            LaPage la = new LaPage();
            la.Height = Height;
            la.Width = Width;
            la.WindowState = this.WindowState;
            this.Hide();
            la.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            int Width = this.Width;

            int Height = this.Height;
            dianPage dian = new dianPage();
            dian.Height = Height;
            dian.Width = Width;
            dian.WindowState = this.WindowState;
            this.Hide();
            dian.ShowDialog();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            int Width = this.Width;

            int Height = this.Height;
            TiPage ti = new TiPage();
            ti.Height = Height;
            ti.Width = Width;
            ti.WindowState = this.WindowState;
            this.Hide();
            ti.ShowDialog();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            int Width = this.Width;

            int Height = this.Height;
            BasePage.ZhePage zhe = new BasePage.ZhePage();
            zhe.Height = Height;
            zhe.Width = Width;
            zhe.WindowState = this.WindowState;
            this.Hide();
            zhe.ShowDialog();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            int Width = this.Width;

            int Height = this.Height;
            BasePage.GouPage gou = new BasePage.GouPage();
            gou.Height = Height;
            gou.Width = Width;
            gou.WindowState = this.WindowState;
            this.Hide();
            gou.ShowDialog();
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
