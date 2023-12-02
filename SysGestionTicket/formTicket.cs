using Guna.UI2.WinForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SysGestionTicket
{
    public partial class formTicket : Form
    {
        private string ConString = "Data Source=dell\\sqlexpress;Initial Catalog=GestionTicket;Integrated Security=True";
        private int ticketIdEnCoursDeModification = -1; 

        public formTicket()
        {
            InitializeComponent();
            
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formTicket_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionTicketDataSet3.TicketTbl'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.ticketTblTableAdapter.Fill(this.gestionTicketDataSet3.TicketTbl);
            

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
            string Num = txtNumTicket.Text;
            string Titre = txtTitre.Text;
            string Priorite = comboBoxPrio.Text;
            string Description = txtDescri.Text;




            if (string.IsNullOrWhiteSpace(Num) || string.IsNullOrWhiteSpace(Titre) || string.IsNullOrWhiteSpace(Priorite) || string.IsNullOrWhiteSpace(Description))
            {
                MessageBox.Show("Veuillez remplir tous les champs du formulaire.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    con.Open();

                    string query = "INSERT INTO TicketTbl (Numticket, Titre,Priorite,Statue, Description) VALUES (@NumTicket, @Titre,@Priorite,@statue, @Description)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NumTicket", Num);
                        cmd.Parameters.AddWithValue("@Titre", Titre);
                        cmd.Parameters.AddWithValue("@Priorite", Priorite);
                        cmd.Parameters.AddWithValue("@Description", Description);
                        cmd.Parameters.AddWithValue("@Statue", "Nouveau");

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Ticket créé avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListerTicket();
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
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    con.Open();

                    string query = "SELECT * FROM TicketTbl";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        ListeTicket.DataSource = dataTable;
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
            
            if (ticketIdEnCoursDeModification == -1)
            {
                MessageBox.Show("Ticket créé avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ticket modifié avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ticketIdEnCoursDeModification = -1;
            }
            ClearFormFields();
            ListerTicket();
        }
        private void ListeTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ticketIdEnCoursDeModification = Convert.ToInt32(ListeTicket.Rows[e.RowIndex].Cells["Id"].Value);

                ModifierTicket(ticketIdEnCoursDeModification);
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
            comboBoxPrio.SelectedIndex=-1;
            txtDescri.Text = "";
        }

        private void ModifierTicket(int ticketId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Tickets WHERE ID = @TicketID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TicketID", ticketId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNumTicket.Text = reader["NumTicket"].ToString();
                                txtTitre.Text = reader["Titre"].ToString();
                                txtDescri.Text = reader["Description"].ToString();
                                comboBoxPrio.Text = reader["Priorite"].ToString();

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des détails du ticket pour modification : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateCreation_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    
}
