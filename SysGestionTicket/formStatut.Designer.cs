namespace SysGestionTicket
{
    partial class formStatut
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
            this.lbl = new System.Windows.Forms.Label();
            this.guna2DataGridViewStatut = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTicketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioriteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idutilisateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionTicketDataSet2 = new SysGestionTicket.GestionTicketDataSet2();
            this.gestionTicketDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionTicketDataSet3 = new SysGestionTicket.GestionTicketDataSet3();
            this.lblTousTickets = new System.Windows.Forms.Label();
            this.btnFerme = new System.Windows.Forms.Button();
            this.btnResolue = new System.Windows.Forms.Button();
            this.btnEnCours = new System.Windows.Forms.Button();
            this.btnOuverte = new System.Windows.Forms.Button();
            this.ticketTblTableAdapter = new SysGestionTicket.GestionTicketDataSet2TableAdapters.TicketTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewStatut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Navy;
            this.lbl.Location = new System.Drawing.Point(41, 38);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(128, 34);
            this.lbl.TabIndex = 17;
            this.lbl.Text = "Statut ticket ";
            // 
            // guna2DataGridViewStatut
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.guna2DataGridViewStatut.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridViewStatut.AutoGenerateColumns = false;
            this.guna2DataGridViewStatut.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewStatut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridViewStatut.ColumnHeadersHeight = 4;
            this.guna2DataGridViewStatut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridViewStatut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numTicketDataGridViewTextBoxColumn,
            this.titreDataGridViewTextBoxColumn,
            this.prioriteDataGridViewTextBoxColumn,
            this.statutDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.dateCreationDataGridViewTextBoxColumn,
            this.idutilisateurDataGridViewTextBoxColumn});
            this.guna2DataGridViewStatut.DataSource = this.ticketTblBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridViewStatut.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridViewStatut.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(177)))));
            this.guna2DataGridViewStatut.Location = new System.Drawing.Point(81, 163);
            this.guna2DataGridViewStatut.Name = "guna2DataGridViewStatut";
            this.guna2DataGridViewStatut.RowHeadersVisible = false;
            this.guna2DataGridViewStatut.Size = new System.Drawing.Size(727, 328);
            this.guna2DataGridViewStatut.TabIndex = 22;
            this.guna2DataGridViewStatut.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember;
            this.guna2DataGridViewStatut.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.guna2DataGridViewStatut.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridViewStatut.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewStatut.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewStatut.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewStatut.ThemeStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.guna2DataGridViewStatut.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(177)))));
            this.guna2DataGridViewStatut.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            this.guna2DataGridViewStatut.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridViewStatut.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewStatut.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewStatut.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridViewStatut.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridViewStatut.ThemeStyle.ReadOnly = false;
            this.guna2DataGridViewStatut.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            this.guna2DataGridViewStatut.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewStatut.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewStatut.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridViewStatut.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridViewStatut.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.guna2DataGridViewStatut.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            // ticketTblBindingSource
            // 
            this.ticketTblBindingSource.DataMember = "TicketTbl";
            this.ticketTblBindingSource.DataSource = this.gestionTicketDataSet2;
            // 
            // gestionTicketDataSet2
            // 
            this.gestionTicketDataSet2.DataSetName = "GestionTicketDataSet2";
            this.gestionTicketDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestionTicketDataSet3BindingSource
            // 
            this.gestionTicketDataSet3BindingSource.DataSource = this.gestionTicketDataSet3;
            this.gestionTicketDataSet3BindingSource.Position = 0;
            // 
            // gestionTicketDataSet3
            // 
            this.gestionTicketDataSet3.DataSetName = "GestionTicketDataSet3";
            this.gestionTicketDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTousTickets
            // 
            this.lblTousTickets.AutoSize = true;
            this.lblTousTickets.Font = new System.Drawing.Font("Nirmala UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTousTickets.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTousTickets.Location = new System.Drawing.Point(78, 145);
            this.lblTousTickets.Name = "lblTousTickets";
            this.lblTousTickets.Size = new System.Drawing.Size(91, 15);
            this.lblTousTickets.TabIndex = 36;
            this.lblTousTickets.Text = "Tous les tickets";
            // 
            // btnFerme
            // 
            this.btnFerme.BackColor = System.Drawing.Color.OrangeRed;
            this.btnFerme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFerme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFerme.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFerme.ForeColor = System.Drawing.Color.White;
            this.btnFerme.Location = new System.Drawing.Point(681, 83);
            this.btnFerme.Name = "btnFerme";
            this.btnFerme.Size = new System.Drawing.Size(119, 37);
            this.btnFerme.TabIndex = 32;
            this.btnFerme.Text = "Fermée";
            this.btnFerme.UseVisualStyleBackColor = false;
            this.btnFerme.Click += new System.EventHandler(this.btnFerme_Click);
            // 
            // btnResolue
            // 
            this.btnResolue.BackColor = System.Drawing.Color.DarkOrange;
            this.btnResolue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResolue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolue.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolue.ForeColor = System.Drawing.Color.White;
            this.btnResolue.Location = new System.Drawing.Point(534, 83);
            this.btnResolue.Name = "btnResolue";
            this.btnResolue.Size = new System.Drawing.Size(119, 37);
            this.btnResolue.TabIndex = 33;
            this.btnResolue.Text = "Résolue";
            this.btnResolue.UseVisualStyleBackColor = false;
            this.btnResolue.Click += new System.EventHandler(this.btnResolue_Click);
            // 
            // btnEnCours
            // 
            this.btnEnCours.BackColor = System.Drawing.Color.Gold;
            this.btnEnCours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnCours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnCours.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnCours.ForeColor = System.Drawing.Color.White;
            this.btnEnCours.Location = new System.Drawing.Point(388, 83);
            this.btnEnCours.Name = "btnEnCours";
            this.btnEnCours.Size = new System.Drawing.Size(119, 37);
            this.btnEnCours.TabIndex = 34;
            this.btnEnCours.Text = "En cours";
            this.btnEnCours.UseVisualStyleBackColor = false;
            this.btnEnCours.Click += new System.EventHandler(this.btnEnCours_Click);
            // 
            // btnOuverte
            // 
            this.btnOuverte.BackColor = System.Drawing.Color.GreenYellow;
            this.btnOuverte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOuverte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOuverte.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOuverte.ForeColor = System.Drawing.Color.White;
            this.btnOuverte.Location = new System.Drawing.Point(235, 83);
            this.btnOuverte.Name = "btnOuverte";
            this.btnOuverte.Size = new System.Drawing.Size(119, 37);
            this.btnOuverte.TabIndex = 35;
            this.btnOuverte.Text = "Ouverte";
            this.btnOuverte.UseVisualStyleBackColor = false;
            this.btnOuverte.Click += new System.EventHandler(this.btnOuverte_Click_1);
            // 
            // ticketTblTableAdapter
            // 
            this.ticketTblTableAdapter.ClearBeforeFill = true;
            // 
            // formStatut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 521);
            this.Controls.Add(this.lblTousTickets);
            this.Controls.Add(this.btnFerme);
            this.Controls.Add(this.btnResolue);
            this.Controls.Add(this.btnEnCours);
            this.Controls.Add(this.btnOuverte);
            this.Controls.Add(this.guna2DataGridViewStatut);
            this.Controls.Add(this.lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formStatut";
            this.Text = "formStatut";
            this.Load += new System.EventHandler(this.formStatut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewStatut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewStatut;
        private System.Windows.Forms.BindingSource gestionTicketDataSet3BindingSource;
        private GestionTicketDataSet3 gestionTicketDataSet3;
        private System.Windows.Forms.Label lblTousTickets;
        private System.Windows.Forms.Button btnFerme;
        private System.Windows.Forms.Button btnResolue;
        private System.Windows.Forms.Button btnEnCours;
        private System.Windows.Forms.Button btnOuverte;
        private GestionTicketDataSet2 gestionTicketDataSet2;
        private System.Windows.Forms.BindingSource ticketTblBindingSource;
        private GestionTicketDataSet2TableAdapters.TicketTblTableAdapter ticketTblTableAdapter;
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