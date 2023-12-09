using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestionTicket
{
    public partial class formTicketA : Form
    {
        public formTicketA()
        {
            InitializeComponent();
        }

        private void formTicketA_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionTicketDataSet4.TicketTbl'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.ticketTblTableAdapter.Fill(this.gestionTicketDataSet4.TicketTbl);

        }
    }
}
