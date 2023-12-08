using System;
using System.Data;
using System.Data.SqlClient;

namespace SysGestionTicket
{
    internal class functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string ConString;
        public functions()
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
            cnt = Cmd.ExecuteNonQuery();
            return cnt;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}
