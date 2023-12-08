using System.Data;
using System.Data.SqlClient;

namespace SysGestionTicket
{
    internal class fonction
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string ConString;

        public fonction()
        {
            ConString = "Data Source=dell\\sqlexpress;Initial Catalog=GestionTicket;Integrated Security=True";
            Con = new SqlConnection(ConString);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }
        public DataTable RecupererDonnees(string Req)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Req, ConString);
            sda.Fill(dt);
            return dt;

        }

        public int EnvoyerDonnees(string Req)
        {
            int cnt = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = Req;
            Cmd.ExecuteNonQuery();
            return cnt;
        }
    }
}
