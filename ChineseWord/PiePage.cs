﻿using System;
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
    public partial class PiePage : Form
    {
        public PiePage()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string Name = "横撇3又";
            string FName = "PiePage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
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
            string Name = "短斜撇生";
            string FName = "PiePage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string Name = "短斜撇生";
            string FName = "PiePage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        /// <summary>
        /// 横撇1了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string Name = "横撇1了";
            string FName = "PiePage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "横撇1了";
            string FName = "PiePage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        /// <summary>
        /// 横撇2乏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string Name = "横撇2乏";
            string FName = "PiePage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "横撇2乏";
            string FName = "PiePage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "横撇3又";
            string FName = "PiePage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "平撇千";
            string FName = "PiePage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string Name = "平撇千";
            string FName = "PiePage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "竖撇1月";
            string FName = "PiePage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string Name = "竖撇1月";
            string FName = "PiePage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "竖撇2大";
            string FName = "PiePage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string Name = "竖撇2大";
            string FName = "PiePage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Name = "竖着撇专";
            string FName = "PiePage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string Name = "竖着撇专";
            string FName = "PiePage";
            PlayMovie.Play play = new PlayMovie.Play(Name, FName);
            play.Width = this.Width;
            play.Height = this.Height;
            play.WindowState = this.WindowState;
            play.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            BasePage.PieTwoPage pt = new BasePage.PieTwoPage();
            pt.Width = this.Width;
            pt.Height = this.Height;
            pt.WindowState = this.WindowState;
            pt.Show();
            this.Hide();
        }

        private void PiePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
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
