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
    public partial class Search : Form
    {
        public Search()
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
            this.Hide();
            Home.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string Textname = this.textBox1.Text.Trim();


            string haarXmlPath = @"localsql\LocalSql.db";
            string fullName = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\"));
            fullName = fullName.Substring(0, fullName.LastIndexOf("\\")) + "\\" + haarXmlPath;
            Sqlhelp sql = new Sqlhelp();
            string Url = sql.QueryWhere(fullName, Textname);//获取文件路径Url
            if (Url != "0")
            {
                string FName = "Search";
                PlayMovie.Play play = new PlayMovie.Play(Textname, FName);
                play.Width = this.Width;
                play.Height = this.Height;
                play.WindowState = this.WindowState;
                play.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("未找到此独体字!");
            }

            
          
        }

        private void Search_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pictureBox2_Click(null,null);
            }
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
