﻿namespace SysGestionTicket
{
    partial class formTicket
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
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.txtNumTicket = new System.Windows.Forms.TextBox();
            this.lblDep = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.lblPriorite = new System.Windows.Forms.Label();
            this.lblDescri = new System.Windows.Forms.Label();
            this.txtDescri = new System.Windows.Forms.TextBox();
            this.btnCreer = new System.Windows.Forms.Button();
            this.comboBoxPrio = new System.Windows.Forms.ComboBox();
            this.ticketTblTableAdapter = new SysGestionTicket.GestionTicketDataSet3TableAdapters.TicketTblTableAdapter();
            this.dateCreation = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ListeTicket = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTicketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioriteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idutilisateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionTicketDataSet = new SysGestionTicket.GestionTicketDataSet();
            this.ticketTblTableAdapter1 = new SysGestionTicket.GestionTicketDataSetTableAdapters.TicketTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ListeTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRecherche
            // 
            this.txtRecherche.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRecherche.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.ForeColor = System.Drawing.Color.Black;
            this.txtRecherche.Location = new System.Drawing.Point(650, 74);
            this.txtRecherche.Multiline = true;
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(224, 25);
            this.txtRecherche.TabIndex = 1;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Navy;
            this.lbl.Location = new System.Drawing.Point(29, 42);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(161, 34);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Créer une ticket ";
            this.lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitre.Location = new System.Drawing.Point(17, 91);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(81, 24);
            this.lblTitre.TabIndex = 3;
            this.lblTitre.Text = "Num Ticket";
            this.lblTitre.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNumTicket
            // 
            this.txtNumTicket.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNumTicket.ForeColor = System.Drawing.Color.Black;
            this.txtNumTicket.Location = new System.Drawing.Point(20, 110);
            this.txtNumTicket.Name = "txtNumTicket";
            this.txtNumTicket.Size = new System.Drawing.Size(184, 32);
            this.txtNumTicket.TabIndex = 4;
            this.txtNumTicket.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDep.Location = new System.Drawing.Point(17, 148);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(39, 24);
            this.lblDep.TabIndex = 3;
            this.lblDep.Text = "Titre";
            this.lblDep.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTitre
            // 
            this.txtTitre.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtTitre.ForeColor = System.Drawing.Color.Black;
            this.txtTitre.Location = new System.Drawing.Point(20, 167);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(184, 32);
            this.txtTitre.TabIndex = 4;
            this.txtTitre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPriorite
            // 
            this.lblPriorite.AutoSize = true;
            this.lblPriorite.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorite.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPriorite.Location = new System.Drawing.Point(17, 202);
            this.lblPriorite.Name = "lblPriorite";
            this.lblPriorite.Size = new System.Drawing.Size(56, 24);
            this.lblPriorite.TabIndex = 3;
            this.lblPriorite.Text = "Priorité";
            this.lblPriorite.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDescri
            // 
            this.lblDescri.AutoSize = true;
            this.lblDescri.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescri.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDescri.Location = new System.Drawing.Point(17, 251);
            this.lblDescri.Name = "lblDescri";
            this.lblDescri.Size = new System.Drawing.Size(81, 24);
            this.lblDescri.TabIndex = 3;
            this.lblDescri.Text = "Déscription";
            this.lblDescri.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDescri
            // 
            this.txtDescri.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtDescri.ForeColor = System.Drawing.Color.Black;
            this.txtDescri.Location = new System.Drawing.Point(20, 270);
            this.txtDescri.Multiline = true;
            this.txtDescri.Name = "txtDescri";
            this.txtDescri.Size = new System.Drawing.Size(184, 73);
            this.txtDescri.TabIndex = 4;
            this.txtDescri.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCreer
            // 
            this.btnCreer.BackColor = System.Drawing.Color.Tomato;
            this.btnCreer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreer.FlatAppearance.BorderSize = 0;
            this.btnCreer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreer.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreer.ForeColor = System.Drawing.Color.White;
            this.btnCreer.Location = new System.Drawing.Point(20, 398);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(184, 34);
            this.btnCreer.TabIndex = 6;
            this.btnCreer.Text = "Créer ticket";
            this.btnCreer.UseVisualStyleBackColor = false;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // comboBoxPrio
            // 
            this.comboBoxPrio.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxPrio.ForeColor = System.Drawing.Color.Black;
            this.comboBoxPrio.FormattingEnabled = true;
            this.comboBoxPrio.Location = new System.Drawing.Point(20, 221);
            this.comboBoxPrio.Name = "comboBoxPrio";
            this.comboBoxPrio.Size = new System.Drawing.Size(184, 32);
            this.comboBoxPrio.TabIndex = 7;
            // 
            // ticketTblTableAdapter
            // 
            this.ticketTblTableAdapter.ClearBeforeFill = true;
            // 
            // dateCreation
            // 
            this.dateCreation.Checked = true;
            this.dateCreation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dateCreation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateCreation.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateCreation.Location = new System.Drawing.Point(20, 349);
            this.dateCreation.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateCreation.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateCreation.Name = "dateCreation";
            this.dateCreation.Size = new System.Drawing.Size(184, 30);
            this.dateCreation.TabIndex = 9;
            this.dateCreation.Value = new System.DateTime(2023, 12, 1, 15, 26, 45, 187);
            this.dateCreation.ValueChanged += new System.EventHandler(this.dateCreation_ValueChanged);
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
            this.ListeTicket.Location = new System.Drawing.Point(235, 122);
            this.ListeTicket.Name = "ListeTicket";
            this.ListeTicket.RowHeadersVisible = false;
            this.ListeTicket.Size = new System.Drawing.Size(639, 375);
            this.ListeTicket.TabIndex = 10;
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
            this.ListeTicket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListeTicket_CellContentClick);
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
            this.ticketTblBindingSource.DataSource = this.gestionTicketDataSet;
            // 
            // gestionTicketDataSet
            // 
            this.gestionTicketDataSet.DataSetName = "GestionTicketDataSet";
            this.gestionTicketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketTblTableAdapter1
            // 
            this.ticketTblTableAdapter1.ClearBeforeFill = true;
            // 
            // formTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(888, 521);
            this.Controls.Add(this.ListeTicket);
            this.Controls.Add(this.dateCreation);
            this.Controls.Add(this.comboBoxPrio);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.txtDescri);
            this.Controls.Add(this.lblDescri);
            this.Controls.Add(this.lblPriorite);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.txtNumTicket);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtRecherche);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formTicket";
            this.Text = "formTicket";
            this.Load += new System.EventHandler(this.formTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListeTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox txtNumTicket;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Label lblPriorite;
        private System.Windows.Forms.Label lblDescri;
        private System.Windows.Forms.TextBox txtDescri;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.ComboBox comboBoxPrio;
        private GestionTicketDataSet3TableAdapters.TicketTblTableAdapter ticketTblTableAdapter;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateCreation;
        private Guna.UI2.WinForms.Guna2DataGridView ListeTicket;
        private GestionTicketDataSet gestionTicketDataSet;
        private System.Windows.Forms.BindingSource ticketTblBindingSource;
        private GestionTicketDataSetTableAdapters.TicketTblTableAdapter ticketTblTableAdapter1;
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