using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SysGestionTicket
{
    public partial class FormSign_up : Form
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
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


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void EnregistrerBtn_Click_1(object sender, EventArgs e)
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
            new formLogin().Show();
            this.Hide();
        }

        private void textConfPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
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

        private void label7_Click_1(object sender, EventArgs e)
        {
            new formLogin().Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textNom_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormSign_up_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
