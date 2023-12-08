using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace SysGestionTicket
{
    public partial class dashboard : Form
    {
        private string conString;

        public object Id_utilisateur { get; private set; }

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

        public string username
        {
            get { return label4.Text; } 
            set { label4.Text = value; }
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
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                // 2. Créer une commande SQL pour récupérer le nom de l'utilisateur
                string query = "SELECT nom FROM TicketTbl WHERE Id_utilisateur = @Id_utilisateur"; // Remplacez par votre propre requête SQL et table
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Remplacez "@id" par le paramètre approprié pour identifier l'utilisateur
                    cmd.Parameters.AddWithValue("@Id_utilisateur", Id_utilisateur);

                    // 3. Exécuter la commande et récupérer le nom de l'utilisateur
                    string nom = (string)cmd.ExecuteScalar();

                    // 4. Mettre à jour le label avec le nom de l'utilisateur
                    label4.Text = nom;
                }
            }
        }
    }
}
