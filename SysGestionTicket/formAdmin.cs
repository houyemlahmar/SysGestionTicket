using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SysGestionTicket
{
    public partial class formAdmin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
    (
         int nLeftRect,
         int nTopRect,
         int nRightRect,
         int nBottomRect,
         int nWidthEllipse,
        int nHeightEllipse
     );
        public formAdmin()
        {
            InitializeComponent();
        }

        private void gunabtnTicket_Click(object sender, System.EventArgs e)
        {
            flowLayoutPanel1.Height = gunabtnTicket.Height;
            flowLayoutPanel1.Top = gunabtnTicket.Top;
            flowLayoutPanel1.Left = gunabtnTicket.Left;
            gunabtnTicket.BackColor = Color.FromArgb(46, 51, 73);

            this.panelForm.Controls.Clear();
            formTicketA formTicket_vrb = new formTicketA() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formTicket_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelForm.Controls.Add(formTicket_vrb);
            formTicket_vrb.Show();
        }

        private void gunabtnStatut_Click(object sender, System.EventArgs e)
        {
            flowLayoutPanel1.Height = gunabtnStatut.Height;
            flowLayoutPanel1.Top = gunabtnStatut.Top;
            gunabtnStatut.BackColor = Color.FromArgb(46, 51, 73);

            this.panelForm.Controls.Clear();
            formStatut formTicket_vrb = new formStatut() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formTicket_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelForm.Controls.Add(formTicket_vrb);
            formTicket_vrb.Show();
        }

        private void gunabtnPriorite_Click(object sender, System.EventArgs e)
        {
            flowLayoutPanel1.Height = gunabtnStatut.Height;
            flowLayoutPanel1.Top = gunabtnStatut.Top;
            gunabtnStatut.BackColor = Color.FromArgb(46, 51, 73);

            this.panelForm.Controls.Clear();
            formGererAgent formTicket_vrb = new formGererAgent() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formTicket_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelForm.Controls.Add(formTicket_vrb);
            formTicket_vrb.Show();
        }

        private void gunabtnNotif_Click(object sender, System.EventArgs e)
        {
            flowLayoutPanel1.Height = gunabtnStatut.Height;
            flowLayoutPanel1.Top = gunabtnStatut.Top;
            gunabtnStatut.BackColor = Color.FromArgb(46, 51, 73);

            this.panelForm.Controls.Clear();
            formStat formTicket_vrb = new formStat() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formTicket_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelForm.Controls.Add(formTicket_vrb);
            formTicket_vrb.Show();
        }

        private void gunabtnDecnx_Click(object sender, System.EventArgs e)
        {
            new formLogin().Show();
            this.Hide();
        }
    }
}
