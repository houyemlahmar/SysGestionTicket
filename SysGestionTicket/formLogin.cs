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
        private DataTable dt;
        private SqlDataAdapter sda;
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

        private void ConnecterBtn_Click(object sender, EventArgs e)
        {
          
            Con.Open();
            // string connecter = "INSERT INTO SignUpTbl VALUES ('" + textEmail.Text + "','" + textPassword.Text + "')";
            string t = "SELECT * FROM SignUpTbl where e_mail like'" + textEmail.Text.ToString() +"' and MotDePasse like '"+textPassword.Text.ToString()+"'";
                 Cmd = new SqlCommand(t, Con);
          int x=Cmd.ExecuteNonQuery();
            MessageBox.Show(" dfgfd"+x);
            if (x>=0)
            {
                new dashboard().Show();
                this.Hide();
            }
            else { 
                MessageBox.Show("E-mail ou mot de passe invalide", "Reéssayer", MessageBoxButtons.OK,MessageBoxIcon.Error);
                textEmail.Text = "";
                textPassword.Text = "";

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
            new formSign_up().Show();
            this.Hide();
        }
    }
}
