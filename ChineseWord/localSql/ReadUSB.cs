using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChineseWord.localSql
{
     public class ReadUSB
    {
        public string Read()
        {
            string Url = ""; //U盘在电脑中的盘符
            DriveInfo[] s = DriveInfo.GetDrives();
            for (int i = 0; i < s.Length; i++)
            {
                //DriveInfo type = s[i];
                if (s[i].DriveType == DriveType.Removable)
                {
                    Url = s[i].Name;
                    
                }
            }
            if (Url == "")
            {
                Url = "0";//0代表没有U盘和移动硬盘
            }

            return Url;
        }
    }
}
