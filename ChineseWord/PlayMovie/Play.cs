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

namespace ChineseWord.PlayMovie
{
    public partial class Play : Form
    {
        DataSet ds = new DataSet();
        public string Name; //视频名称 如：长平横二
        public string FMName;//页面名称，如：HengPage
        public string PlayS;

        public Play(string MovieName, string FName)
        {
            InitializeComponent();

            this.Name = MovieName;
            this.FMName = FName;
            label2.Text = "";
            label2.Text = "<" + MovieName+">";
            if(MovieName == null || MovieName == "")
            {
                label2.Text = "";
            }


            localSql.ReadUSB Rusb = new localSql.ReadUSB();
            string Pan = Rusb.Read();
            if (Pan == "0")
            {
                MessageBox.Show("未发现U盘!");
                return;
            }

            string haarXmlPath = @"localsql\LocalSql.db";
            string fullName = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\"));
            fullName = fullName.Substring(0, fullName.LastIndexOf("\\")) + "\\" + haarXmlPath;

            Sqlhelp sql = new Sqlhelp();
            string Url = sql.QueryWhere(fullName, Name);//获取文件路径Url
            if(Url =="0")
            {
                MessageBox.Show("未发现视频文件!");
                return;
            }

          

            axWindowsMediaPlayer1.URL = Pan + Url;

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            localSql.ReadUSB Rusb = new localSql.ReadUSB();
            string Pan = Rusb.Read();
            if (Pan == "0")
            {
                MessageBox.Show("未发现U盘!");
                return;
            }
            string haarXmlPath = @"localsql\LocalSql.db";
            string fullName = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\"));
            fullName = fullName.Substring(0, fullName.LastIndexOf("\\")) + "\\" + haarXmlPath;

            Sqlhelp sql = new Sqlhelp();
            string Url = sql.QueryWhere(fullName, Name);//获取文件路径Url

            if (Url == null || Url == "")
            {
                MessageBox.Show("未发现视频文件!");
                return;
            }


            axWindowsMediaPlayer1.URL = Pan + Url;
        }

        private void Play_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void T_Back_Click(object sender, EventArgs e)
        {
            if (FMName == "HengPage")//横页面
            {
                HengPage heng = new HengPage();
                heng.Width = this.Width;
                heng.Height = this.Height;
                heng.WindowState = this.WindowState;
                heng.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
                
            }
            if (FMName == "Search")//搜索
            {
                Search search = new Search();
                search.Width = this.Width;
                search.Height = this.Height;
                search.WindowState = this.WindowState;
                search.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "ShuPage")//竖
            {
                ShuPage shu = new ShuPage();
                shu.Width = this.Width;
                shu.Height = this.Height;
                shu.WindowState = this.WindowState;
                shu.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "PiePage")//撇
            {
                PiePage Pie = new PiePage();
                Pie.Width = this.Width;
                Pie.Height = this.Height;
                Pie.WindowState = this.WindowState;
                Pie.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "PieTwoPage")//撇
            {
                BasePage.PieTwoPage Pie = new BasePage.PieTwoPage();
                Pie.Width = this.Width;
                Pie.Height = this.Height;
                Pie.WindowState = this.WindowState;
                Pie.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "LaPage")//捺
            {
                LaPage La = new LaPage();
                La.Width = this.Width;
                La.Height = this.Height;
                La.WindowState = this.WindowState;
                La.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "DianPage")//点
            {
                dianPage La = new dianPage();
                La.Width = this.Width;
                La.Height = this.Height;
                La.WindowState = this.WindowState;
                La.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "DianTwoPage")//点
            {
                BasePage.DianTwoPage La = new BasePage.DianTwoPage();
                La.Width = this.Width;
                La.Height = this.Height;
                La.WindowState = this.WindowState;
                La.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "TiPage")//提
            {
                TiPage La = new TiPage();
                La.Width = this.Width;
                La.Height = this.Height;
                La.WindowState = this.WindowState;
                La.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "ZhePage")//折
            {
                BasePage.ZhePage La = new BasePage.ZhePage();
                La.Width = this.Width;
                La.Height = this.Height;
                La.WindowState = this.WindowState;
                La.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "ZheTwoPage")//折
            {
                BasePage.ZheTwoPage La = new BasePage.ZheTwoPage();
                La.Width = this.Width;
                La.Height = this.Height;
                La.WindowState = this.WindowState;
                La.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "GouPage")//钩
            {
                BasePage.GouPage La = new BasePage.GouPage();
                La.Width = this.Width;
                La.Height = this.Height;
                La.WindowState = this.WindowState;
                La.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }

            if (FMName == "BaoWei")//包围
            {
                ChineseWord.PianPangBuShou.BaoWei BaoWei = new PianPangBuShou.BaoWei();
                BaoWei.Width = this.Width;
                BaoWei.Height = this.Height;
                BaoWei.WindowState = this.WindowState;
                BaoWei.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "BaoWeiTwo")//包围
            {
                ChineseWord.PianPangBuShou.BaoWeiTwo BaoWei = new PianPangBuShou.BaoWeiTwo();
                BaoWei.Width = this.Width;
                BaoWei.Height = this.Height;
                BaoWei.WindowState = this.WindowState;
                BaoWei.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "ZiTou")//字头
            {
                ChineseWord.PianPangBuShou.ZiTou ZiTou = new PianPangBuShou.ZiTou();
                ZiTou.Width = this.Width;
                ZiTou.Height = this.Height;
                ZiTou.WindowState = this.WindowState;
                ZiTou.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "ZiTouTwo")//字头2
            {
                ChineseWord.PianPangBuShou.ZiTouTwo ZiTou = new PianPangBuShou.ZiTouTwo();
                ZiTou.Width = this.Width;
                ZiTou.Height = this.Height;
                ZiTou.WindowState = this.WindowState;
                ZiTou.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "ZiTouThree")//字头3
            {
                ChineseWord.PianPangBuShou.ZiTouThree ZiTou = new PianPangBuShou.ZiTouThree();
                ZiTou.Width = this.Width;
                ZiTou.Height = this.Height;
                ZiTou.WindowState = this.WindowState;
                ZiTou.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "ZiDi")//字底
            {
                ChineseWord.PianPangBuShou.ZiDi ZiDi = new PianPangBuShou.ZiDi();
                ZiDi.Width = this.Width;
                ZiDi.Height = this.Height;
                ZiDi.WindowState = this.WindowState;
                ZiDi.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "ZiDiTwo")//字底2
            {
                ChineseWord.PianPangBuShou.ZiDiTwo ZiDiTwo = new PianPangBuShou.ZiDiTwo();
                ZiDiTwo.Width = this.Width;
                ZiDiTwo.Height = this.Height;
                ZiDiTwo.WindowState = this.WindowState;
                ZiDiTwo.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "ZuoZiPang")//左字旁
            {
                ChineseWord.PianPangBuShou.ZuoZiPang ZuoZiPang = new PianPangBuShou.ZuoZiPang();
                ZuoZiPang.Width = this.Width;
                ZuoZiPang.Height = this.Height;
                ZuoZiPang.WindowState = this.WindowState;
                ZuoZiPang.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "ZuoZiPangTwo")//左字旁2
            {
                ChineseWord.PianPangBuShou.ZuoZiPangTwo ZuoZiPangTwo = new PianPangBuShou.ZuoZiPangTwo();
                ZuoZiPangTwo.Width = this.Width;
                ZuoZiPangTwo.Height = this.Height;
                ZuoZiPangTwo.WindowState = this.WindowState;
                ZuoZiPangTwo.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "ZuoZiPangThree")//左字旁3
            {
                ChineseWord.PianPangBuShou.ZuoZiPangThree ZuoZiPangThree = new PianPangBuShou.ZuoZiPangThree();
                ZuoZiPangThree.Width = this.Width;
                ZuoZiPangThree.Height = this.Height;
                ZuoZiPangThree.WindowState = this.WindowState;
                ZuoZiPangThree.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "YouZiPang")//右字旁
            {
                ChineseWord.PianPangBuShou.YouZiPang YouZiPang = new PianPangBuShou.YouZiPang();
                YouZiPang.Width = this.Width;
                YouZiPang.Height = this.Height;
                YouZiPang.WindowState = this.WindowState;
                YouZiPang.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "YouZiPangTwo")//右字旁2
            {
                ChineseWord.PianPangBuShou.YouZiPangTwo YouZiPangTwo = new PianPangBuShou.YouZiPangTwo();
                YouZiPangTwo.Width = this.Width;
                YouZiPangTwo.Height = this.Height;
                YouZiPangTwo.WindowState = this.WindowState;
                YouZiPangTwo.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }

            if (FMName == "GouTwoPage")//钩
            {
                BasePage.GouTwoPage goutwo = new BasePage.GouTwoPage();
                goutwo.Width = this.Width;
                goutwo.Height = this.Height;
                goutwo.WindowState = this.WindowState;
                goutwo.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "GouThreePage")//钩
            {
                BasePage.GouThreePage goutwo = new BasePage.GouThreePage();
                goutwo.Width = this.Width;
                goutwo.Height = this.Height;
                goutwo.WindowState = this.WindowState;
                goutwo.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "GouFourPage")//钩
            {
                BasePage.GouFourPage goutwo = new BasePage.GouFourPage();
                goutwo.Width = this.Width;
                goutwo.Height = this.Height;
                goutwo.WindowState = this.WindowState;
                goutwo.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "DuTiZiPage")//独体字
            {
                DutiziPage.DuTiZiPage dtp = new DutiziPage.DuTiZiPage();
                dtp.Width = this.Width;
                dtp.Height = this.Height;
                dtp.WindowState = this.WindowState;
                dtp.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "DuTiZiTwoPage")//独体字
            {
                DutiziPage.DuTiZiTwoPage dtp = new DutiziPage.DuTiZiTwoPage();
                dtp.Width = this.Width;
                dtp.Height = this.Height;
                dtp.WindowState = this.WindowState;
                dtp.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "DuTiZiThreePage")//独体字
            {
                DutiziPage.DuTiZiThreePage dtp = new DutiziPage.DuTiZiThreePage();
                dtp.Width = this.Width;
                dtp.Height = this.Height;
                dtp.WindowState = this.WindowState;
                dtp.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }

            if (FMName == "DuTiZiFourPage")//独体字
            {
                DutiziPage.DuTiZipFourPage dtp = new DutiziPage.DuTiZipFourPage();
                dtp.Width = this.Width;
                dtp.Height = this.Height;
                dtp.WindowState = this.WindowState;
                dtp.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "DuTiZiFivePage")//独体字
            {
                DutiziPage.DuTiZiFivePage dtp = new DutiziPage.DuTiZiFivePage();
                dtp.Width = this.Width;
                dtp.Height = this.Height;
                dtp.WindowState = this.WindowState;
                dtp.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "DuTiZiSixPage")//独体字
            {
                DutiziPage.DuTiZiSixPage dtp = new DutiziPage.DuTiZiSixPage();
                dtp.Width = this.Width;
                dtp.Height = this.Height;
                dtp.WindowState = this.WindowState;
                dtp.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "DuTiZiSevenPage")//独体字
            {
                DutiziPage.DuTiZiSevenPage dtp = new DutiziPage.DuTiZiSevenPage();
                dtp.Width = this.Width;
                dtp.Height = this.Height;
                dtp.WindowState = this.WindowState;
                dtp.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "DuTiZiEightPage")//独体字
            {
                DutiziPage.DuTiZiEightPage dtp = new DutiziPage.DuTiZiEightPage();
                dtp.Width = this.Width;
                dtp.Height = this.Height;
                dtp.WindowState = this.WindowState;
                dtp.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            if (FMName == "ZiDiThree")//字底
            {
                PianPangBuShou.ZiDiThree dtp = new PianPangBuShou.ZiDiThree();
                dtp.Width = this.Width;
                dtp.Height = this.Height;
                dtp.WindowState = this.WindowState;
                dtp.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Dispose();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
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

        private void Play_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(axWindowsMediaPlayer1.fullScreen)
            {
                axWindowsMediaPlayer1.fullScreen = false;
            }
            else
            {
                axWindowsMediaPlayer1.fullScreen = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(axWindowsMediaPlayer1_PlayStateChange);
            if (axWindowsMediaPlayer1.fullScreen)
            {
                
                axWindowsMediaPlayer1.fullScreen = false;
            }
            else
            {
               if( PlayS != "Playing")
                {
                    MessageBox.Show("请先播放视频");
                    return;
                }
                axWindowsMediaPlayer1.fullScreen = true;
            }
        }

        

       private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            
           
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            switch (e.newState)
            {
                case 0:    // Undefined
                    PlayS = "Undefined";
                    break;

                case 1:    // Stopped
                    PlayS = "Stopped";
                    break;

                case 2:    // Paused
                    PlayS = "Paused";
                    break;

                case 3:    // Playing
                    PlayS = "Playing";
                    break;

                case 4:    // ScanForward
                    PlayS = "ScanForward";
                    break;

                case 5:    // ScanReverse
                    PlayS = "ScanReverse";
                    break;

                case 6:    // Buffering
                    PlayS = "Buffering";
                    break;

                case 7:    // Waiting
                    PlayS = "Waiting";
                    break;

                case 8:    // MediaEnded
                    PlayS = "MediaEnded";
                    break;

                case 9:    // Transitioning
                    PlayS = "Transitioning";
                    break;

                case 10:   // Ready
                    PlayS = "Ready";
                    break;

                case 11:   // Reconnecting
                    PlayS = "Reconnecting";
                    break;

                case 12:   // Last
                    PlayS = "Last";
                    break;

                default:
                    PlayS = ("Unknown State: " + e.newState.ToString());
                    break;
            }
        }
    }


}
