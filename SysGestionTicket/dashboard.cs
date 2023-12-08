using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace SysGestionTicket
{
    public partial class dashboard : Form
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
        public dashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            flowLayoutPanel1.Height = gunabtnTicket.Height;
            flowLayoutPanel1.Top = gunabtnTicket.Top;
            flowLayoutPanel1.Left = gunabtnTicket.Left;
            gunabtnTicket.BackColor = Color.FromArgb(46, 51, 73);

            this.panelForm.Controls.Clear();
            formTicket formTicket_vrb = new formTicket() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formTicket_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelForm.Controls.Add(formTicket_vrb);
            formTicket_vrb.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
           
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticketTblTableAdapter.FillBy(this.gestionTicketDataSet1.TicketTbl);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        

        private void btnDecnx_Click(object sender, EventArgs e)
        {
            new formLogin().Show();
            this.Hide();
        }

       


        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = gunabtnTicket.Height;
            flowLayoutPanel1.Top = gunabtnTicket.Top;
            flowLayoutPanel1.Left = gunabtnTicket.Left;
            gunabtnTicket.BackColor = Color.FromArgb(46, 51, 73);

            this.panelForm.Controls.Clear();
            formTicket formTicket_vrb = new formTicket() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formTicket_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelForm.Controls.Add(formTicket_vrb);
            formTicket_vrb.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
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

        private void gunabtnPriorite_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = gunabtnPriorite.Height;
            flowLayoutPanel1.Top = gunabtnPriorite.Top;
            gunabtnPriorite.BackColor = Color.FromArgb(46, 51, 73);

            this.panelForm.Controls.Clear();
            formPriorite formTicket_vrb = new formPriorite() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formTicket_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelForm.Controls.Add(formTicket_vrb);
            formTicket_vrb.Show();
        }

        private void gunabtnStat_Click(object sender, EventArgs e)
        {
            
            flowLayoutPanel1.Height = gunabtnNotif.Height;
            flowLayoutPanel1.Top = gunabtnNotif.Top;
            gunabtnNotif.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void gunabtnTicket_leave(object sender, EventArgs e)
        {
            gunabtnTicket.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void gunabtnStatue_leave(object sender, EventArgs e)
        {
            gunabtnStatut.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void gunabtnPriorite_leave(object sender, EventArgs e)
        {
            gunabtnPriorite.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void gunabtnStat_leave(object sender, EventArgs e)
        {
            gunabtnNotif.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void gunabtnDecnx_Click(object sender, EventArgs e)
        {
            new formLogin().Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
