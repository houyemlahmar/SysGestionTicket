using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace SysGestionTicket
{
    public partial class formStatue : Form
    {
        private string Con = "Data Source=dell\\sqlexpress;Initial Catalog=GestionTicket;Integrated Security=True";
        private SqlCommand Cmd = new SqlCommand();
        private DataTable dt = new DataTable();
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet();
        public formStatue()
        {
            InitializeComponent();
            getStatueTicket();
            //loadChart1();
        }


        private void getStatueTicket()
        {

                guna2DataGridViewStatue.Columns.Clear();
                ds = new DataSet();
                da = new SqlDataAdapter("SELECT * FROM TicketTbl", Con);
                da.Fill(ds, "TicketTbl");
                guna2DataGridViewStatue.DataSource = ds;
                guna2DataGridViewStatue.DataMember = "TicketTbl";
                lblTousTickets.Text = "Tous les Tickets";
        }

        private void guna2DataGridViewStatue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOuverte_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            DataTable dtr = new DataTable("reports");
            //this.dtr.Clear(0;
            da = new SqlDataAdapter("select * from TicketTbl where Statue='" +" Ouverte" + "'", Con);
            da.Fill(dtr);
            guna2DataGridViewStatue.DataSource = dtr;
            DataView SortedDataView = new DataView();
            SortedDataView = dtr.DefaultView;
            SortedDataView.Sort = "id DESC";
            dtr = SortedDataView.ToTable();
            guna2DataGridViewStatue.DataSource = dtr;
            lblTousTickets.Text = "Tickets ouvertes";
        }

        private void btnEncours_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            DataTable dtr = new DataTable("reports");
            //this.dtr.Clear(0;
            da = new SqlDataAdapter("select * from TicketTbl where Statue='" + "En cours"+"'", Con);
            da.Fill(dtr);
            guna2DataGridViewStatue.DataSource = dtr;
            DataView SortedDataView = new DataView();
            SortedDataView = dtr.DefaultView;
            SortedDataView.Sort = "id DESC";
            dtr = SortedDataView.ToTable();
            guna2DataGridViewStatue.DataSource = dtr;
            lblTousTickets.Text = "Tickets en cours";
        }

        private void btnResolue_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            DataTable dtr = new DataTable("reports");
            //this.dtr.Clear(0;
            da = new SqlDataAdapter("select * from TicketTbl where Statue='" + "Résolue"+"'", Con);
            da.Fill(dtr);
            guna2DataGridViewStatue.DataSource = dtr;
            DataView SortedDataView = new DataView();
            SortedDataView = dtr.DefaultView;
            SortedDataView.Sort = "id DESC";
            dtr = SortedDataView.ToTable();
            guna2DataGridViewStatue.DataSource = dtr;
            lblTousTickets.Text = "Tickets résolues";
        }

        private void btnFerme_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            DataTable dtr = new DataTable("reports");
            //this.dtr.Clear(0;
            da = new SqlDataAdapter("select * from TicketTbl where Statue='" + "Fermée" + "'", Con);
            da.Fill(dtr);
            guna2DataGridViewStatue.DataSource = dtr;
            DataView SortedDataView = new DataView();
            SortedDataView = dtr.DefaultView;
            SortedDataView.Sort = "id DESC";
            dtr = SortedDataView.ToTable();
            guna2DataGridViewStatue.DataSource = dtr;
            lblTousTickets.Text = "Tickets fermées";
        }
       

    }






}
