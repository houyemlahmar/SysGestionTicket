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
using TheArtOfDevHtmlRenderer.Adapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

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
            // TODO: cette ligne de code charge les données dans la table 'gestionTicketDataSet3.TicketTbl'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.ticketTblTableAdapter.Fill(this.gestionTicketDataSet3.TicketTbl);

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

        private void button1_Click(object sender, EventArgs e)
        {
            int i = guna2DataGridViewPrio.CurrentRow.Index;
            ds = new DataSet();
            da = new SqlDataAdapter("UPDATE TicketTbl set Priorite ='" + comboBoxPriorite.Text + "' WHERE Id ='" + guna2DataGridViewPrio[0, i].Value.ToString() + "'", Con);
            da.Fill(ds, "TicketTbl");
            comboBoxPriorite.Text = "";
            ListerTicket();
            getPrioriteTicket();
            LoadComboBoxOptions();
            MessageBox.Show("Priorité modifiée avec succées");

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

        }

        private void btnFaible_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dtr = new DataTable("reports");
           //this.dtr.Clear0)
            da = new SqlDataAdapter("SELECT * FROM TicketTbl WHERE Priorite='" + "Failble"+"'" ,Con);
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
            da = new SqlDataAdapter("SELECT * FROM TicketTbl where Priorite='" + "Moyenne"+"'", Con);
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
