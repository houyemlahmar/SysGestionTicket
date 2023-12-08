using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SysGestionTicket
{
    public partial class formLogin : Form
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private string ConString;
        public formLogin()
        {
            InitializeComponent();
            ConString = "Data Source=dell\\sqlexpress;Initial Catalog=GestionTicket;Integrated Security=True";
            Con = new SqlConnection(ConString);
            dashboard_ = new dashboard();

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
        private dashboard dashboard_;

        private async void ConnecterBtn_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                    
                }

                //string connecter = "SELECT * FROM SignUpTbl WHERE e_mail = @e_mail AND MotDePasse = @password";
                //SqlCommand cmd = new SqlCommand(connecter, Con);
                //cmd.Parameters.AddWithValue("@e_mail", textEmail.Text);
                //cmd.Parameters.AddWithValue("@MotDePasse", textPassword.Text);

                //SqlDataReader reader = await cmd.ExecuteReaderAsync();
                //MessageBox.Show(reader["e_mail"].ToString(), "");
                //if (reader.Read())
                //{
                    //string userEmail = reader["e_mail"].ToString();

                    // Vérifier si l'utilisateur est administrateur
                    if (textEmail.Text == "admin@gmail.com" && textPassword.Text == "12345")
                    {
                        //dashboard_.username = reader.GetString(1);
                        formAdmin adminForm = new formAdmin();
                        adminForm.Show();
                        this.Hide();
                    }
                    // Vérifier si l'utilisateur est un agent
                    if(textEmail.Text == "houyem@gmail.com" && textPassword.Text == "1234")
                             //(textPassword.Text == "roukaya@gmail.com" && textPassword.Text == "123456"))
                    {
                    
                    string sql = "SELECT * FROM SignUpTbl WHERE e_mail LIKE '%" + textEmail.Text + "%' AND MotDePasse LIKE '%" + textPassword.Text + "%'"; // Replace YourTableName with your actual table name
                        using (SqlCommand command = new SqlCommand(sql, Con))
                        {
                            using (SqlDataReader readerr = command.ExecuteReader())
                            {

                                while (readerr.Read())
                                {
                                MessageBox.Show(readerr.GetString(1), "test");
                                dashboard_.username = readerr.GetString(1);
                                //formAdmin adminForm = new formAdmin();
                                
                                this.Hide();
                                dashboard_.Show();
                            }
                            }
                        
                        }
                    }
                    else
                    {
                        // Gérer d'autres cas d'utilisateurs ici
                    }
               // }
               // else
               // {
                 //   MessageBox.Show("E-mail ou mot de passe invalide", "Réessayer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 //   textEmail.Text = "";
                 //   textPassword.Text = "";
               // }
            }
            catch (Exception ex)
            {
                // Gérer les exceptions (afficher un message d'erreur, journaliser, etc.)
                //Console.WriteLine("Erreur : " + ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }


        }



        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                textPassword.PasswordChar = '\0';

            }
            else
            {
                textPassword.PasswordChar = '*';

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new FormSign_up().Show();
            this.Hide();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
