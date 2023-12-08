using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestionTicket
{
    public partial class formAgent : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
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
        public formAgent()
        {
            InitializeComponent();
        }

        private void gunabtnTicket_Click(object sender, EventArgs e)
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

        private void gunabtnDecnx_Click(object sender, EventArgs e)
        {
            new formLogin().Show();
            this.Hide();
        }

        private void gunabtnStatut_Click(object sender, EventArgs e)
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
                    labelUserName.Text = nom;
                }
            }
        }

        private void formAgent_Load(object sender, EventArgs e)
        {

        }
    }
}
