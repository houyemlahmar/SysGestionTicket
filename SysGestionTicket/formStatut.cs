using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SysGestionTicket
{
    public partial class formStatut : Form
    {
        private string Con = "Data Source=dell\\sqlexpress;Initial Catalog=GestionTicket;Integrated Security=True";
        private SqlCommand Cmd = new SqlCommand();
        private DataTable dt = new DataTable();
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet();
        public formStatut()
        {
            InitializeComponent();
            getStatueTicket();
            //loadChart1();
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

        private void guna2DataGridViewStatue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnOuverte_Click_1(object sender, EventArgs e)
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
            da = new SqlDataAdapter("select * from TicketTbl where Statut='" + "Fermée" + "'", Con);
            da.Fill(dtr);
            guna2DataGridViewStatut.DataSource = dtr;
            DataView SortedDataView = new DataView();
            SortedDataView = dtr.DefaultView;
            SortedDataView.Sort = "id DESC";
            dtr = SortedDataView.ToTable();
            guna2DataGridViewStatut.DataSource = dtr;
            lblTousTickets.Text = "Tickets fermées";
        }

        private void formStatut_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionTicketDataSet2.TicketTbl'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.ticketTblTableAdapter.Fill(this.gestionTicketDataSet2.TicketTbl);

        }
    }






}

