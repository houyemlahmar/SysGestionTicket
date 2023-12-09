using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestionTicket
{
    public partial class formStatutA : Form
    {
        private string Con = "Data Source=dell\\sqlexpress;Initial Catalog=GestionTicket;Integrated Security=True";
        private SqlCommand Cmd = new SqlCommand();
        private DataTable dt = new DataTable();
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet();
        public formStatutA()
        {
            InitializeComponent();
            getStatueTicket();
            LoadComboBoxOptions();
        }
        private void getStatueTicket()
        {

            guna2DataGridViewStatut.Columns.Clear();
            ds = new DataSet();
            da = new SqlDataAdapter("SELECT * FROM TicketTbl", Con);
            da.Fill(ds, "TicketTbl");
            guna2DataGridViewStatut.DataSource = ds;
            guna2DataGridViewStatut.DataMember = "TicketTbl";
            lblTousTickets.Text = "Tous les Tickets";
        }
        private void formStatutA_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionTicketDataSet4.TicketTbl'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.ticketTblTableAdapter.Fill(this.gestionTicketDataSet4.TicketTbl);

        }

        private void btnOuverte_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            DataTable dtr = new DataTable("reports");
            //this.dtr.Clear(0;
            da = new SqlDataAdapter("select * from TicketTbl where Statut='" + " Ouverte" + "'", Con);
            da.Fill(dtr);
            guna2DataGridViewStatut.DataSource = dtr;
            DataView SortedDataView = new DataView();
            SortedDataView = dtr.DefaultView;
            SortedDataView.Sort = "id DESC";
            dtr = SortedDataView.ToTable();
            guna2DataGridViewStatut.DataSource = dtr;
            lblTousTickets.Text = "Tickets ouvertes";
        }

        private void btnEnCours_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            DataTable dtr = new DataTable("reports");
            //this.dtr.Clear(0;
            da = new SqlDataAdapter("select * from TicketTbl where Statut='" + "En cours" + "'", Con);
            da.Fill(dtr);
            guna2DataGridViewStatut.DataSource = dtr;
            DataView SortedDataView = new DataView();
            SortedDataView = dtr.DefaultView;
            SortedDataView.Sort = "id DESC";
            dtr = SortedDataView.ToTable();
            guna2DataGridViewStatut.DataSource = dtr;
            lblTousTickets.Text = "Tickets en cours";
        }

        private void btnResolue_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            DataTable dtr = new DataTable("reports");
            //this.dtr.Clear(0;
            da = new SqlDataAdapter("select * from TicketTbl where Statut='" + "Résolue" + "'", Con);
            da.Fill(dtr);
            guna2DataGridViewStatut.DataSource = dtr;
            DataView SortedDataView = new DataView();
            SortedDataView = dtr.DefaultView;
            SortedDataView.Sort = "id DESC";
            dtr = SortedDataView.ToTable();
            guna2DataGridViewStatut.DataSource = dtr;
            lblTousTickets.Text = "Tickets résolues";
        }

        private void btnFerme_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            DataTable dtr = new DataTable("reports");
            //this.dtr.Clear(0;
            da = new SqlDataAdapter("select * from TicketTbl where Statut='" + "Nouveau" + "'", Con);
            da.Fill(dtr);
            guna2DataGridViewStatut.DataSource = dtr;
            DataView SortedDataView = new DataView();
            SortedDataView = dtr.DefaultView;
            SortedDataView.Sort = "id DESC";
            dtr = SortedDataView.ToTable();
            guna2DataGridViewStatut.DataSource = dtr;
            lblTousTickets.Text = "Nouveaux tickets";
        }

        private void guna2DataGridViewStatut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridViewStatut.SelectedRows.Count > 0)
            {
                // Récupérer l'ID du ticket sélectionné
                int selectedId = Convert.ToInt32(guna2DataGridViewStatut.SelectedRows[0].Cells["Id"].Value);

                // Afficher l'ID du ticket dans le ComboBox
                comboBoxStatut.SelectedValue = selectedId.ToString();
            }
        }
        private void LoadComboBoxOptions()
        {
            comboBoxStatut.Items.Add("Ouverte");
            comboBoxStatut.Items.Add("En cours");
            comboBoxStatut.Items.Add("Résolue");
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (guna2DataGridViewStatut.SelectedRows.Count > 0)
            {
                // Récupérer l'ID du ticket sélectionné
                int selectedTicketID = Convert.ToInt32(guna2DataGridViewStatut.SelectedRows[0].Cells["id"].Value);

                // Récupérer le nouveau statut à partir du ComboBox
                string newStatut = comboBoxStatut.SelectedItem.ToString();

                // Mettre à jour le statut dans la base de données
                UpdateStatut(selectedTicketID, newStatut);

                // Rafraîchir le tableau après la mise à jour
                getStatueTicket();
            }
        }
        private void UpdateStatut(int Id, string newStatut)
        {
            using (SqlConnection connection = new SqlConnection(Con))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UPDATE TicketTbl SET Statut = @Statut WHERE Id = @Id", connection))
                {
                    command.Parameters.AddWithValue("@Statut", newStatut);
                    command.Parameters.AddWithValue("@Id", Id);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
