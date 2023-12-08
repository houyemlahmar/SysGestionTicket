using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SysGestionTicket
{
    public partial class formTicket : Form
    {
        private string Con = "Data Source=dell\\sqlexpress;Initial Catalog=GestionTicket;Integrated Security=True";


        private SqlCommand Cmd = new SqlCommand();
        private DataTable dt = new DataTable();
        private DataTable dtt = new DataTable();
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet();

        int Id_utilisateur = 1;



        public formTicket()
        {
            InitializeComponent();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formTicket_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionTicketDataSet.TicketTbl'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.ticketTblTableAdapter1.Fill(this.gestionTicketDataSet.TicketTbl);

            ListerTicket();
            LoadComboBoxOptions();
            ClearFormFields();

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            string NumTicket = txtNumTicket.Text;
            string Titre = txtTitre.Text;
            string Priorite = comboBoxPrio.Text;
            string Description = txtDescri.Text;
            DateTime Date_Creation = DateTime.Today;

            SqlDataAdapter da = new SqlDataAdapter("SELECT NumTicket from TicketTbl where NumTicket='" + txtNumTicket.Text + "' ", Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (txtNumTicket.Text.Trim().Length == 0)
            {
                MessageBox.Show("Champs NumTicket est vide!", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtTitre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Champs Titre est vide!", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtDescri.Text.Trim().Length == 0)
            {
                MessageBox.Show("Champs Description est vide!", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (comboBoxPrio.Text == "")
            {
                MessageBox.Show("Choisit une priorité!", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Ticket déjà exist!", "Crér un nouveau Ticket", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(Con))
                {
                    con.Open();

                    string query = "INSERT INTO TicketTbl (Numticket, Titre, Priorite, Statut, Description,Date_Creation, Id_utilisateur)" + " VALUES (@NumTicket, @Titre, @Priorite, @Statut, @Description,GETDATE(), @Id_utilisateur)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NumTicket", NumTicket);
                        cmd.Parameters.AddWithValue("@Titre", Titre);
                        cmd.Parameters.AddWithValue("@Priorite", Priorite);
                        cmd.Parameters.AddWithValue("@Description", Description);
                        cmd.Parameters.AddWithValue("@Statut", "Nouveau");
                        cmd.Parameters.AddWithValue("@Id_utilisateur", Id_utilisateur);
                        cmd.Parameters.AddWithValue("@Date_Creation", Date_Creation);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Ticket créé avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        var button1 = new DataGridViewButtonColumn();
                        var button2 = new DataGridViewButtonColumn();
                        button1.Name = "ModifierButton";
                        button1.HeaderText = button2.HeaderText = "Action";
                        button1.Text = "Modifier";
                        button1.UseColumnTextForButtonValue = true;
                        this.ListeTicket.Columns.Add(button1);

                        button2.Name = "supprimerButton";
                        button2.Text = "Supprimer";
                        button2.UseColumnTextForButtonValue = true;
                        this.ListeTicket.Columns.Add(button2);

                        ListerTicket();
                        ClearFormFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la création du ticket : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        ListeTicket.DataSource = dt;

                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des tickets : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {


        }
        private void ListeTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ListeTicket.Columns[e.ColumnIndex].Name == "SupprimerButton ")
            {
                if (ListeTicket.Rows.Count < 2)
                {
                    MessageBox.Show(" La base de donnée ne peut pas être vide! Ajouter un ticket pour que vous puisse le supprimer");
                    return;
                }
                else
                {
                    if (MessageBox.Show("Voulez_vous le supprimer ? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int i = ListeTicket.CurrentRow.Index;
                        ds = new DataSet();
                        da = new SqlDataAdapter("DELETE FROM TicketTbl where Id =  '" + ListeTicket[0, i].Value.ToString() + "'", Con);

                        ListerTicket();
                    }
                }
            }
        }


        private void LoadComboBoxOptions()
        {
            comboBoxPrio.Items.Add("Faible");
            comboBoxPrio.Items.Add("Moyenne");
            comboBoxPrio.Items.Add("Haute");
            comboBoxPrio.Items.Add("Urgente");

        }
        private void ClearFormFields()
        {
            txtNumTicket.Text = "";
            txtTitre.Text = "";
            comboBoxPrio.SelectedIndex = -1;
            txtDescri.Text = "";
        }

        private void ModifierTicket(int TicketId)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateCreation_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            ListeTicket.Columns.Clear();
            dtt = new DataTable();
            // ds = new DataSetO;
            //adapter = new MySqlDataAdapter("select from tickets", con)
            //adapter.Fill(ds, "tickets");
            //datagridTickets.DataSource = ds;
            //datagridTickets.DataMember = "tickets";
            da = new SqlDataAdapter("select * from TicketTbl", Con);

            ListeTicket.DataSource = dtt;
            DataView dv = dtt.DefaultView;
            dv.RowFilter = string.Format("NumTicket like txtRecherche.Text");
            ListeTicket.DataSource = dv.ToTable();
        }
    }
}
