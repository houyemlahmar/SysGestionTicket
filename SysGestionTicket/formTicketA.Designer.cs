namespace SysGestionTicket
{
    partial class formTicketA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ListeTicket = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.gestionTicketDataSet4 = new SysGestionTicket.GestionTicketDataSet4();
            this.ticketTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketTblTableAdapter = new SysGestionTicket.GestionTicketDataSet4TableAdapters.TicketTblTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTicketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioriteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idutilisateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListeTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ListeTicket
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.ListeTicket.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListeTicket.AutoGenerateColumns = false;
            this.ListeTicket.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ListeTicket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListeTicket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListeTicket.ColumnHeadersHeight = 4;
            this.ListeTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ListeTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numTicketDataGridViewTextBoxColumn,
            this.titreDataGridViewTextBoxColumn,
            this.prioriteDataGridViewTextBoxColumn,
            this.statutDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.dateCreationDataGridViewTextBoxColumn,
            this.idutilisateurDataGridViewTextBoxColumn});
            this.ListeTicket.DataSource = this.ticketTblBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListeTicket.DefaultCellStyle = dataGridViewCellStyle3;
            this.ListeTicket.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(177)))));
            this.ListeTicket.Location = new System.Drawing.Point(56, 111);
            this.ListeTicket.Name = "ListeTicket";
            this.ListeTicket.RowHeadersVisible = false;
            this.ListeTicket.Size = new System.Drawing.Size(763, 345);
            this.ListeTicket.TabIndex = 12;
            this.ListeTicket.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember;
            this.ListeTicket.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.ListeTicket.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ListeTicket.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ListeTicket.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ListeTicket.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ListeTicket.ThemeStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ListeTicket.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(177)))));
            this.ListeTicket.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            this.ListeTicket.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ListeTicket.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListeTicket.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ListeTicket.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ListeTicket.ThemeStyle.HeaderStyle.Height = 4;
            this.ListeTicket.ThemeStyle.ReadOnly = false;
            this.ListeTicket.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            this.ListeTicket.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListeTicket.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListeTicket.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ListeTicket.ThemeStyle.RowsStyle.Height = 22;
            this.ListeTicket.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.ListeTicket.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // txtRecherche
            // 
            this.txtRecherche.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRecherche.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.ForeColor = System.Drawing.Color.Black;
            this.txtRecherche.Location = new System.Drawing.Point(591, 53);
            this.txtRecherche.Multiline = true;
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(228, 25);
            this.txtRecherche.TabIndex = 11;
            // 
            // gestionTicketDataSet4
            // 
            this.gestionTicketDataSet4.DataSetName = "GestionTicketDataSet4";
            this.gestionTicketDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketTblBindingSource
            // 
            this.ticketTblBindingSource.DataMember = "TicketTbl";
            this.ticketTblBindingSource.DataSource = this.gestionTicketDataSet4;
            // 
            // ticketTblTableAdapter
            // 
            this.ticketTblTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numTicketDataGridViewTextBoxColumn
            // 
            this.numTicketDataGridViewTextBoxColumn.DataPropertyName = "NumTicket";
            this.numTicketDataGridViewTextBoxColumn.HeaderText = "NumTicket";
            this.numTicketDataGridViewTextBoxColumn.Name = "numTicketDataGridViewTextBoxColumn";
            // 
            // titreDataGridViewTextBoxColumn
            // 
            this.titreDataGridViewTextBoxColumn.DataPropertyName = "Titre";
            this.titreDataGridViewTextBoxColumn.HeaderText = "Titre";
            this.titreDataGridViewTextBoxColumn.Name = "titreDataGridViewTextBoxColumn";
            // 
            // prioriteDataGridViewTextBoxColumn
            // 
            this.prioriteDataGridViewTextBoxColumn.DataPropertyName = "Priorite";
            this.prioriteDataGridViewTextBoxColumn.HeaderText = "Priorite";
            this.prioriteDataGridViewTextBoxColumn.Name = "prioriteDataGridViewTextBoxColumn";
            // 
            // statutDataGridViewTextBoxColumn
            // 
            this.statutDataGridViewTextBoxColumn.DataPropertyName = "Statut";
            this.statutDataGridViewTextBoxColumn.HeaderText = "Statut";
            this.statutDataGridViewTextBoxColumn.Name = "statutDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // dateCreationDataGridViewTextBoxColumn
            // 
            this.dateCreationDataGridViewTextBoxColumn.DataPropertyName = "Date_Creation";
            this.dateCreationDataGridViewTextBoxColumn.HeaderText = "Date_Creation";
            this.dateCreationDataGridViewTextBoxColumn.Name = "dateCreationDataGridViewTextBoxColumn";
            // 
            // idutilisateurDataGridViewTextBoxColumn
            // 
            this.idutilisateurDataGridViewTextBoxColumn.DataPropertyName = "Id_utilisateur";
            this.idutilisateurDataGridViewTextBoxColumn.HeaderText = "Id_utilisateur";
            this.idutilisateurDataGridViewTextBoxColumn.Name = "idutilisateurDataGridViewTextBoxColumn";
            // 
            // formTicketA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(872, 482);
            this.Controls.Add(this.ListeTicket);
            this.Controls.Add(this.txtRecherche);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formTicketA";
            this.Text = "formTicketA";
            this.Load += new System.EventHandler(this.formTicketA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListeTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView ListeTicket;
        private System.Windows.Forms.TextBox txtRecherche;
        private GestionTicketDataSet4 gestionTicketDataSet4;
        private System.Windows.Forms.BindingSource ticketTblBindingSource;
        private GestionTicketDataSet4TableAdapters.TicketTblTableAdapter ticketTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTicketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioriteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idutilisateurDataGridViewTextBoxColumn;
    }
}