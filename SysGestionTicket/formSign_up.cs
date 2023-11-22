using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.SqlClient;

namespace SysGestionTicket
{
    public partial class FormSign_up : Form
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string ConString;
        public FormSign_up()
        {
            InitializeComponent();
            ConString = "Data Source=dell\\sqlexpress;Initial Catalog=GestionTicket;Integrated Security=True";
            Con = new SqlConnection(ConString);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void textNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EnregistrerBtn_Click(object sender, EventArgs e)
        {
            if (textNom.Text == "" && textEmail.Text == "" && textPassword.Text == "" && textConfPassword.Text == "")
            {
                MessageBox.Show("les champs sont vides", "Registration échoué", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textNom.Text == "" || textEmail.Text == "" || textPassword.Text == "" || textConfPassword.Text == "")
            {
                MessageBox.Show("Veuillez compléter le formulaire", "Registration échoué", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textPassword.Text == textConfPassword.Text)
            {
                Con.Open();
                string enregistrer = "INSERT INTO SignUpTbl VALUES ('" + textNom.Text + "','" + textEmail.Text + "','" + textPassword.Text + "')";
                Cmd = new SqlCommand(enregistrer, Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Félicitation! Votre compte est crée", "Registration avec succée", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Le mot de passe ne correspond pas, veuillez le saisir à nouveau", "Registration échoué", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textPassword.Text = "";
            textConfPassword.Text = "";
            textPassword.Focus();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textPassword.PasswordChar = '\0';
                textConfPassword.PasswordChar = '\0';
            }
            else
            {
                textPassword.PasswordChar = '*';
                textConfPassword.PasswordChar = '*';
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new formLogin().Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
