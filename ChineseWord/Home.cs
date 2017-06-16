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
    public partial class Home : Form
    {
        DataSet ds = new DataSet();
        public Home()
        {
            InitializeComponent();
            this.panel1.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //for (int i = 0; i < ds.Tables[0].Rows.Count / 2; i++)
            //{
            //    Button lb = new Button();
            //    lb.Top = 220 + i * 50;
            //    lb.Left = 200;
            //    lb.Text = ds.Tables[0].Rows[i]["name"].ToString();
            //    this.panel1.Controls.Add(lb);

            //}
            //int s = 0;
            //for (int j = ds.Tables[0].Rows.Count / 2; j < ds.Tables[0].Rows.Count; j++)
            //{
            //    Button bt = new Button();
            //    bt.Top = 220 + s * 50;
            //    bt.Left = 450;
            //    bt.Text = ds.Tables[0].Rows[j]["name"].ToString();
            //    this.panel1.Controls.Add(bt);
            //    s = s + 1;

            //}
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
            System.Environment.Exit(0);
        }
        //基本笔画
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int Width = this.Width;

            int Height = this.Height;
            BasicStrokes bs = new BasicStrokes();
            bs.Height = Height;
            bs.Width = Width;
            bs.WindowState = this.WindowState;
            this.Hide();
            bs.Show();
            GC.Collect();
            GC.WaitForPendingFinalizers();

        }

        //基本笔画
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int Width = this.Width;

            int Height = this.Height;
            BasicStrokes bs = new BasicStrokes();
            bs.Height = Height;
            bs.Width = Width;
            bs.WindowState = this.WindowState;
            this.Hide();
            bs.Show();
            GC.Collect();
            GC.WaitForPendingFinalizers();

        }

        private void T_Back_Click(object sender, EventArgs e)
        {
            //this.T_Panel.Hide();
            //this.panel1.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
            //test4 t = new test4();
            //this.T_Panel.Controls.Add(t);
        }
        //搜索图片事件
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int Width = this.Width;

            int Height = this.Height;
            Search Search = new Search();
            Search.Height = Height;
            Search.Width = Width;
            Search.WindowState = this.WindowState;
            this.Hide();
            Search.Show();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        //搜索事件
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int Width = this.Width;

            int Height = this.Height;
            Search Search = new Search();
            Search.Height = Height;
            Search.Width = Width;
            Search.WindowState = this.WindowState;
            this.Hide();
            Search.Show();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        //偏旁部首
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            int Width = this.Width;

            int Height = this.Height;
            PianPangBushou PianPangBushou = new PianPangBushou();
            PianPangBushou.Height = Height;
            PianPangBushou.Width = Width;
            PianPangBushou.WindowState = this.WindowState;
            this.Hide();
            PianPangBushou.Show();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        //偏旁部首
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int Width = this.Width;

            int Height = this.Height;
            PianPangBushou PianPangBushou = new PianPangBushou();
            PianPangBushou.Height = Height;
            PianPangBushou.Width = Width;
            PianPangBushou.WindowState = this.WindowState;
            this.Hide();
            PianPangBushou.Show();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        /// <summary>
        /// 独体字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int Width = this.Width;

            int Height = this.Height;
            DutiziPage.DuTiZiPage dutizi = new DutiziPage.DuTiZiPage();
            dutizi.Height = Height;
            dutizi.Width = Width;
            dutizi.WindowState = this.WindowState;
            this.Hide();
            dutizi.Show();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int Width = this.Width;

            int Height = this.Height;
            DutiziPage.DuTiZiPage dutizi = new DutiziPage.DuTiZiPage();
            dutizi.Height = Height;
            dutizi.Width = Width;
            dutizi.WindowState = this.WindowState;
            this.Hide();
            dutizi.Show();
            GC.Collect();
            GC.WaitForPendingFinalizers();
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
