using MSG_BoxCustom;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;

namespace Lumino_worm
{
    public partial class Couriel : Form
    {
        public Couriel()
        {
            InitializeComponent();
        }

        private void Couriel_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                var fromAddress = new MailAddress("lumino110908@gmail.com", "Ransom");
                var toAddress = new MailAddress("ware.ransom@yahoo.com", "Ransom");
                const string fromPassword = "Lumino1109";
                const string subject = "Lumino WORM HELPER";
                this.progressBar1.Value = 20;
                var smtp = new SmtpClient
                {
                    Host = "smtp-mail.outlook.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("lumino110908@gmail.com", fromPassword)

                };
                this.progressBar1.Value = 65;
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = textBox1.Text
            })
            {
                smtp.Send(message);
            }
            this.progressBar1.Value = 82;
            System.Threading.Thread.Sleep(2500);
            this.progressBar1.Value = 96;
            System.Threading.Thread.Sleep(2500);
            this.progressBar1.Value = 100;
            System.Threading.Thread.Sleep(850);
            MessageBox.Show("Mail Sended !\r\n If you see any mail Error, i'm sorry !", "Lumino Worm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("https://youtube.com/@Lumino2.0");
            this.Close();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        Font printFont;
        StreamReader streamToPrint;
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            // Print each line of the file.
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }
        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
       

            try
            {
                streamToPrint = new StreamReader
                   ("C:\\My Documents\\MyFile.txt");
                try
                {
                    printFont = new Font("Arial", 10);
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler
                       (this.pd_PrintPage);
                    pd.Print();
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       


    }

}
