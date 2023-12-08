using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void ConnecterBtn_ClickAsync(object sender, EventArgs e)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }


            string connecter = "SELECT * FROM SignUpTbl where e_mail= '" + textEmail.Text + "' and MotDePasse= '" + textPassword.Text + "'";
            Cmd = new SqlCommand(connecter, Con);
            SqlDataReader reader = await Cmd.ExecuteReaderAsync();
            if (reader.Read())
            {
                string userEmail = reader["e_mail"].ToString();

                // Vérifier si l'utilisateur est administrateur
                if (userEmail == "admin@gmail.com" && textPassword.Text == "12345")
                {
                    formAdmin adminForm = new formAdmin();
                    adminForm.Show();
                    this.Hide();
                }
                /*
                 if (userEmail == "houyem@gmail.com" && textPassword.Text == "1234")
                 {

                     AcceuilAgent agentForm = new AcceuilAgent();
                     agentForm.Show();
                     this.Hide();
                 }
                 if (userEmail == "roukaya@gmail.com" && textPassword.Text == "123456")
                 {

                     AcceuilAgent agentForm = new AcceuilAgent();
                     agentForm.Show();
                     this.Hide();
                 }*/

            }


            else
            {
                MessageBox.Show("E-mail ou mot de passe invalide", "Reéssayer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textEmail.Text = "";
                textPassword.Text = "";

            }


            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
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
