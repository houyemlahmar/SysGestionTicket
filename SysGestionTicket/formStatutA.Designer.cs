namespace SysGestionTicket
{
    partial class formStatutA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTousTickets = new System.Windows.Forms.Label();
            this.btnFerme = new System.Windows.Forms.Button();
            this.btnResolue = new System.Windows.Forms.Button();
            this.btnEnCours = new System.Windows.Forms.Button();
            this.btnOuverte = new System.Windows.Forms.Button();
            this.guna2DataGridViewStatut = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbl = new System.Windows.Forms.Label();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.comboBoxStatut = new System.Windows.Forms.ComboBox();
            this.gestionTicketDataSet4 = new SysGestionTicket.GestionTicketDataSet4();
            this.gestionTicketDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewStatut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTousTickets
            // 
            this.lblTousTickets.AutoSize = true;
            this.lblTousTickets.Font = new System.Drawing.Font("Nirmala UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTousTickets.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTousTickets.Location = new System.Drawing.Point(213, 98);
            this.lblTousTickets.Name = "lblTousTickets";
            this.lblTousTickets.Size = new System.Drawing.Size(91, 15);
            this.lblTousTickets.TabIndex = 43;
            this.lblTousTickets.Text = "Tous les tickets";
            // 
            // btnFerme
            // 
            this.btnFerme.BackColor = System.Drawing.Color.OrangeRed;
            this.btnFerme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFerme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFerme.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFerme.ForeColor = System.Drawing.Color.White;
            this.btnFerme.Location = new System.Drawing.Point(695, 45);
            this.btnFerme.Name = "btnFerme";
            this.btnFerme.Size = new System.Drawing.Size(119, 37);
            this.btnFerme.TabIndex = 39;
            this.btnFerme.Text = "Nouveau";
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
            this.btnResolue.Location = new System.Drawing.Point(548, 45);
            this.btnResolue.Name = "btnResolue";
            this.btnResolue.Size = new System.Drawing.Size(119, 37);
            this.btnResolue.TabIndex = 40;
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
            this.btnEnCours.Location = new System.Drawing.Point(402, 45);
            this.btnEnCours.Name = "btnEnCours";
            this.btnEnCours.Size = new System.Drawing.Size(119, 37);
            this.btnEnCours.TabIndex = 41;
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
            this.btnOuverte.Location = new System.Drawing.Point(249, 45);
            this.btnOuverte.Name = "btnOuverte";
            this.btnOuverte.Size = new System.Drawing.Size(119, 37);
            this.btnOuverte.TabIndex = 42;
            this.btnOuverte.Text = "Ouverte";
            this.btnOuverte.UseVisualStyleBackColor = false;
            this.btnOuverte.Click += new System.EventHandler(this.btnOuverte_Click);
            // 
            // guna2DataGridViewStatut
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.guna2DataGridViewStatut.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridViewStatut.AutoGenerateColumns = false;
            this.guna2DataGridViewStatut.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewStatut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridViewStatut.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridViewStatut.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(177)))));
            this.guna2DataGridViewStatut.Location = new System.Drawing.Point(216, 122);
            this.guna2DataGridViewStatut.Name = "guna2DataGridViewStatut";
            this.guna2DataGridViewStatut.RowHeadersVisible = false;
            this.guna2DataGridViewStatut.Size = new System.Drawing.Size(625, 325);
            this.guna2DataGridViewStatut.TabIndex = 38;
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
            this.guna2DataGridViewStatut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridViewStatut_CellContentClick);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Navy;
            this.lbl.Location = new System.Drawing.Point(23, 35);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(128, 34);
            this.lbl.TabIndex = 37;
            this.lbl.Text = "Statut ticket ";
            // 
            // buttonModifier
            // 
            this.buttonModifier.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifier.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifier.ForeColor = System.Drawing.Color.White;
            this.buttonModifier.Location = new System.Drawing.Point(27, 160);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(157, 30);
            this.buttonModifier.TabIndex = 46;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = false;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label.Location = new System.Drawing.Point(25, 98);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(107, 20);
            this.label.TabIndex = 45;
            this.label.Text = "Sélectionnez statut";
            // 
            // comboBoxStatut
            // 
            this.comboBoxStatut.FormattingEnabled = true;
            this.comboBoxStatut.Location = new System.Drawing.Point(27, 121);
            this.comboBoxStatut.Name = "comboBoxStatut";
            this.comboBoxStatut.Size = new System.Drawing.Size(157, 21);
            this.comboBoxStatut.TabIndex = 44;
            // 
            // gestionTicketDataSet4
            // 
            this.gestionTicketDataSet4.DataSetName = "GestionTicketDataSet4";
            this.gestionTicketDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestionTicketDataSet4BindingSource
            // 
            this.gestionTicketDataSet4BindingSource.DataSource = this.gestionTicketDataSet4;
            this.gestionTicketDataSet4BindingSource.Position = 0;
            // 
            // ticketTblBindingSource
            // 
            this.ticketTblBindingSource.DataMember = "TicketTbl";
            this.ticketTblBindingSource.DataSource = this.gestionTicketDataSet4BindingSource;
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
            // formStatutA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(872, 482);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.label);
            this.Controls.Add(this.comboBoxStatut);
            this.Controls.Add(this.lblTousTickets);
            this.Controls.Add(this.btnFerme);
            this.Controls.Add(this.btnResolue);
            this.Controls.Add(this.btnEnCours);
            this.Controls.Add(this.btnOuverte);
            this.Controls.Add(this.guna2DataGridViewStatut);
            this.Controls.Add(this.lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formStatutA";
            this.Text = "formStatutA";
            this.Load += new System.EventHandler(this.formStatutA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewStatut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTousTickets;
        private System.Windows.Forms.Button btnFerme;
        private System.Windows.Forms.Button btnResolue;
        private System.Windows.Forms.Button btnEnCours;
        private System.Windows.Forms.Button btnOuverte;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewStatut;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox comboBoxStatut;
        private System.Windows.Forms.BindingSource gestionTicketDataSet4BindingSource;
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