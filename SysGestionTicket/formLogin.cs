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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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


            // string connecter = "INSERT INTO SignUpTbl VALUES ('" + textEmail.Text + "','" + textPassword.Text + "')";
            string connecter = "SELECT * FROM SignUpTbl where e_mail= '" + textEmail.Text +"' and MotDePasse= '"+textPassword.Text+"'";
                 Cmd = new SqlCommand(connecter, Con);
            SqlDataReader reader = await Cmd.ExecuteReaderAsync();
            if (reader.Read()== true) {
                new dashboard().Show();
                this.Hide();

            } 

            else { 
                MessageBox.Show("E-mail ou mot de passe invalide", "Reéssayer", MessageBoxButtons.OK,MessageBoxIcon.Error);
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
