using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SysGestionTicket
{
    public partial class formPriorite : Form
    {
        private string Con = "Data Source=dell\\sqlexpress;Initial Catalog=GestionTicket;Integrated Security=True";

        int Id_utilisateur = 1;

        private SqlCommand Cmd = new SqlCommand();
        private DataTable dt = new DataTable();
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet();
        public formPriorite()
        {
            InitializeComponent();

        }

        private void formPriorite_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionTicketDataSet4.TicketTbl'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.ticketTblTableAdapter1.Fill(this.gestionTicketDataSet4.TicketTbl);


            getPrioriteTicket();
            ListerTicket();
            LoadComboBoxOptions();

        }
        private void getPrioriteTicket()
        {
            guna2DataGridViewPrio.Columns.Clear();
            ds = new DataSet();
            da = new SqlDataAdapter("SELECT * FROM TicketTbl", Con);

            da.Fill(ds, "TicketTbl");
            guna2DataGridViewPrio.DataSource = ds;
            guna2DataGridViewPrio.DataMember = "TicketTbl";
            lblTousTickets1.Text = "Tous les Tickets";
        }
        private void ListerTicket()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Con))
                {
                    con.Open();

                    string query = "SELECT * FROM TicketTbl WHERE Id_utilisateur = @Id_utilisateur";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id_utilisateur", Id_utilisateur);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        guna2DataGridViewPrio.DataSource = dataTable;


                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des tickets : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void UpdatePriorite(int Id, string newPriorite)
        {
            using (SqlConnection connection = new SqlConnection(Con))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UPDATE TicketTbl SET Priorite = @Priorite WHERE Id = @Id", connection))
                {
                    command.Parameters.AddWithValue("@Priorite", newPriorite);
                    command.Parameters.AddWithValue("@Id", Id);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (guna2DataGridViewPrio.SelectedRows.Count > 0)
            {
                // Récupérer l'ID du ticket sélectionné
                int selectedId = Convert.ToInt32(guna2DataGridViewPrio.SelectedRows[0].Cells["Id"].Value);

                // Récupérer la nouvelle priorité à partir du ComboBox
                string newPriorite = comboBoxPriorite.SelectedItem.ToString();

                // Mettre à jour la priorité dans la base de données
                UpdatePriorite(selectedId, newPriorite);

                // Rafraîchir le tableau après la mise à jour
                getPrioriteTicket();
            }

        }
        private void LoadComboBoxOptions()
        {
            comboBoxPriorite.Items.Add("Faible");
            comboBoxPriorite.Items.Add("Moyenne");
            comboBoxPriorite.Items.Add("Haute");
            comboBoxPriorite.Items.Add("Urgente");

        }

        private void guna2DataGridViewPrio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridViewPrio.SelectedRows.Count > 0)
            {
                // Récupérer l'ID du ticket sélectionné
                int selectedId = Convert.ToInt32(guna2DataGridViewPrio.SelectedRows[0].Cells["Id"].Value);

                // Afficher la priorité du ticket dans le ComboBox
                comboBoxPriorite.SelectedItem = guna2DataGridViewPrio.SelectedRows[0].Cells["Priorite"].Value.ToString();
            }
        }

        private void btnFaible_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dtr = new DataTable("reports");
            //this.dtr.Clear0)
            da = new SqlDataAdapter("SELECT * FROM TicketTbl WHERE Priorite='" + "Failble" + "'", Con);
            dtr.Clear();
            da.Fill(dtr);
            guna2DataGridViewPrio.DataSource = null;
            guna2DataGridViewPrio.DataSource = dtr;
            DataView SortedDataView = new DataView(dtr);
            SortedDataView.Sort = "id DESC";
            dtr = SortedDataView.ToTable();
            guna2DataGridViewPrio.DataSource = dtr;
            lblTousTickets1.Text = "Tickets de faible priorité";
        }

        private void lblTousTickets_Click(object sender, EventArgs e)
        {
            getPrioriteTicket();
        }

        private void btnMoyenne_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dtr = new DataTable("reports");
            //this.dtr.Clear0)
            da = new SqlDataAdapter("SELECT * FROM TicketTbl where Priorite='" + "Moyenne" + "'", Con);
            da.Fill(dtr);
            guna2DataGridViewPrio.DataSource = dtr;
            DataView SortedDataView = new DataView();
            SortedDataView = dtr.DefaultView;
            SortedDataView.Sort = "id DESC";
            dtr = SortedDataView.ToTable();
            guna2DataGridViewPrio.DataSource = dtr;
            lblTousTickets1.Text = "Tickets de moyenne priorité";
        }

        private void btnHaute_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dtr = new DataTable("reports");
            //this.dtr.Clear0)
            da = new SqlDataAdapter("SELECT * FROM TicketTbl where Priorite='" + "Haute" + "'", Con);
            da.Fill(dtr);
            guna2DataGridViewPrio.DataSource = dtr;
            DataView SortedDataView = new DataView();
            SortedDataView = dtr.DefaultView;
            SortedDataView.Sort = "id DESC";
            dtr = SortedDataView.ToTable();
            guna2DataGridViewPrio.DataSource = dtr;
            lblTousTickets1.Text = "Tickets de haute priorité";
        }

        private void btnUrgente_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dtr = new DataTable("reports");
            //this.dtr.Clear0)
            da = new SqlDataAdapter("SELECT * FROM TicketTbl where Priorite='" + "Urgente" + "'", Con);
            da.Fill(dtr);
            guna2DataGridViewPrio.DataSource = dtr;
            DataView SortedDataView = new DataView();
            SortedDataView = dtr.DefaultView;
            SortedDataView.Sort = "id DESC";
            dtr = SortedDataView.ToTable();
            guna2DataGridViewPrio.DataSource = dtr;
            lblTousTickets1.Text = "Tickets urgente";
        }
    }
}
