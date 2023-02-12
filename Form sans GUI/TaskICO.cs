using System;
using System.Drawing.Text;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Forms;
using MSG_BoxCustom;



namespace TaskICO_all
{
    public partial class TaskICO : Form
    {
        public TaskICO()
        {
            InitializeComponent();
        }

        private void TaskICO_Load(object sender, EventArgs e)
        {

        }

        private void hELPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EN: \rSend me a mail at : keyluminer@gmail.com\r \rFR:\rEnvoyez-moi un mail a : keyluminer@gmail.com", "Lumino Worm", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MSG_BoxCustom1 Menu1 = new MSG_BoxCustom1();
            Menu1.Show();
        }

    }


}
