namespace SysGestionTicket
{
    partial class formPriorite
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
            this.label = new System.Windows.Forms.Label();
            this.comboBoxPriorite = new System.Windows.Forms.ComboBox();
            this.lblPriorite = new System.Windows.Forms.Label();
            this.btnUrgente = new System.Windows.Forms.Button();
            this.btnHaute = new System.Windows.Forms.Button();
            this.btnMoyenne = new System.Windows.Forms.Button();
            this.btnFaible = new System.Windows.Forms.Button();
            this.guna2DataGridViewPrio = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTicketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioriteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gestionTicketDataSet4 = new SysGestionTicket.GestionTicketDataSet4();
            this.ticketTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionTicketDataSet3 = new SysGestionTicket.GestionTicketDataSet3();
            this.ticketTblTableAdapter = new SysGestionTicket.GestionTicketDataSet3TableAdapters.TicketTblTableAdapter();
            this.lblTousTickets1 = new System.Windows.Forms.Label();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.ticketTblTableAdapter1 = new SysGestionTicket.GestionTicketDataSet4TableAdapters.TicketTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewPrio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label.Location = new System.Drawing.Point(35, 108);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(115, 20);
            this.label.TabIndex = 11;
            this.label.Text = "Sélectionnez priorité";
            // 
            // comboBoxPriorite
            // 
            this.comboBoxPriorite.FormattingEnabled = true;
            this.comboBoxPriorite.Location = new System.Drawing.Point(37, 131);
            this.comboBoxPriorite.Name = "comboBoxPriorite";
            this.comboBoxPriorite.Size = new System.Drawing.Size(157, 21);
            this.comboBoxPriorite.TabIndex = 10;
            // 
            // lblPriorite
            // 
            this.lblPriorite.AutoSize = true;
            this.lblPriorite.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorite.ForeColor = System.Drawing.Color.Navy;
            this.lblPriorite.Location = new System.Drawing.Point(32, 47);
            this.lblPriorite.Name = "lblPriorite";
            this.lblPriorite.Size = new System.Drawing.Size(167, 34);
            this.lblPriorite.TabIndex = 9;
            this.lblPriorite.Text = "Priorité de Ticket";
            // 
            // btnUrgente
            // 
            this.btnUrgente.BackColor = System.Drawing.Color.OrangeRed;
            this.btnUrgente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrgente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrgente.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrgente.ForeColor = System.Drawing.Color.White;
            this.btnUrgente.Location = new System.Drawing.Point(710, 80);
            this.btnUrgente.Name = "btnUrgente";
            this.btnUrgente.Size = new System.Drawing.Size(119, 37);
            this.btnUrgente.TabIndex = 5;
            this.btnUrgente.Text = "Urgente";
            this.btnUrgente.UseVisualStyleBackColor = false;
            this.btnUrgente.Click += new System.EventHandler(this.btnUrgente_Click);
            // 
            // btnHaute
            // 
            this.btnHaute.BackColor = System.Drawing.Color.DarkOrange;
            this.btnHaute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHaute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHaute.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHaute.ForeColor = System.Drawing.Color.White;
            this.btnHaute.Location = new System.Drawing.Point(563, 80);
            this.btnHaute.Name = "btnHaute";
            this.btnHaute.Size = new System.Drawing.Size(119, 37);
            this.btnHaute.TabIndex = 6;
            this.btnHaute.Text = "Haute";
            this.btnHaute.UseVisualStyleBackColor = false;
            this.btnHaute.Click += new System.EventHandler(this.btnHaute_Click);
            // 
            // btnMoyenne
            // 
            this.btnMoyenne.BackColor = System.Drawing.Color.Gold;
            this.btnMoyenne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoyenne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoyenne.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoyenne.ForeColor = System.Drawing.Color.White;
            this.btnMoyenne.Location = new System.Drawing.Point(417, 80);
            this.btnMoyenne.Name = "btnMoyenne";
            this.btnMoyenne.Size = new System.Drawing.Size(119, 37);
            this.btnMoyenne.TabIndex = 7;
            this.btnMoyenne.Text = "Moyenne";
            this.btnMoyenne.UseVisualStyleBackColor = false;
            this.btnMoyenne.Click += new System.EventHandler(this.btnMoyenne_Click);
            // 
            // btnFaible
            // 
            this.btnFaible.BackColor = System.Drawing.Color.GreenYellow;
            this.btnFaible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaible.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaible.ForeColor = System.Drawing.Color.White;
            this.btnFaible.Location = new System.Drawing.Point(264, 80);
            this.btnFaible.Name = "btnFaible";
            this.btnFaible.Size = new System.Drawing.Size(119, 37);
            this.btnFaible.TabIndex = 8;
            this.btnFaible.Text = "Faible";
            this.btnFaible.UseVisualStyleBackColor = false;
            this.btnFaible.Click += new System.EventHandler(this.btnFaible_Click);
            // 
            // guna2DataGridViewPrio
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.guna2DataGridViewPrio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridViewPrio.AutoGenerateColumns = false;
            this.guna2DataGridViewPrio.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.guna2DataGridViewPrio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewPrio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridViewPrio.ColumnHeadersHeight = 4;
            this.guna2DataGridViewPrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridViewPrio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numTicketDataGridViewTextBoxColumn,
            this.titreDataGridViewTextBoxColumn,
            this.prioriteDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.dateCreationDataGridViewTextBoxColumn});
            this.guna2DataGridViewPrio.DataSource = this.ticketTblBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridViewPrio.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridViewPrio.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(177)))));
            this.guna2DataGridViewPrio.Location = new System.Drawing.Point(246, 155);
            this.guna2DataGridViewPrio.Name = "guna2DataGridViewPrio";
            this.guna2DataGridViewPrio.RowHeadersVisible = false;
            this.guna2DataGridViewPrio.Size = new System.Drawing.Size(611, 342);
            this.guna2DataGridViewPrio.TabIndex = 28;
            this.guna2DataGridViewPrio.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember;
            this.guna2DataGridViewPrio.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.guna2DataGridViewPrio.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridViewPrio.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewPrio.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewPrio.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewPrio.ThemeStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.guna2DataGridViewPrio.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(177)))));
            this.guna2DataGridViewPrio.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            this.guna2DataGridViewPrio.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridViewPrio.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewPrio.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewPrio.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridViewPrio.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridViewPrio.ThemeStyle.ReadOnly = false;
            this.guna2DataGridViewPrio.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            this.guna2DataGridViewPrio.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewPrio.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewPrio.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridViewPrio.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridViewPrio.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.guna2DataGridViewPrio.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridViewPrio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridViewPrio_CellContentClick);
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
            // ticketTblBindingSource1
            // 
            this.ticketTblBindingSource1.DataMember = "TicketTbl";
            this.ticketTblBindingSource1.DataSource = this.gestionTicketDataSet4;
            // 
            // gestionTicketDataSet4
            // 
            this.gestionTicketDataSet4.DataSetName = "GestionTicketDataSet4";
            this.gestionTicketDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketTblBindingSource
            // 
            this.ticketTblBindingSource.DataMember = "TicketTbl";
            this.ticketTblBindingSource.DataSource = this.gestionTicketDataSet3;
            // 
            // gestionTicketDataSet3
            // 
            this.gestionTicketDataSet3.DataSetName = "GestionTicketDataSet3";
            this.gestionTicketDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketTblTableAdapter
            // 
            this.ticketTblTableAdapter.ClearBeforeFill = true;
            // 
            // lblTousTickets1
            // 
            this.lblTousTickets1.AutoSize = true;
            this.lblTousTickets1.Font = new System.Drawing.Font("Nirmala UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTousTickets1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTousTickets1.Location = new System.Drawing.Point(243, 133);
            this.lblTousTickets1.Name = "lblTousTickets1";
            this.lblTousTickets1.Size = new System.Drawing.Size(91, 15);
            this.lblTousTickets1.TabIndex = 31;
            this.lblTousTickets1.Text = "Tous les tickets";
            this.lblTousTickets1.Click += new System.EventHandler(this.lblTousTickets_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifier.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifier.ForeColor = System.Drawing.Color.White;
            this.buttonModifier.Location = new System.Drawing.Point(37, 170);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(157, 30);
            this.buttonModifier.TabIndex = 32;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = false;
            this.buttonModifier.Click += new System.EventHandler(this.button1_Click);
            // 
            // ticketTblTableAdapter1
            // 
            this.ticketTblTableAdapter1.ClearBeforeFill = true;
            // 
            // formPriorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 521);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.lblTousTickets1);
            this.Controls.Add(this.guna2DataGridViewPrio);
            this.Controls.Add(this.label);
            this.Controls.Add(this.comboBoxPriorite);
            this.Controls.Add(this.lblPriorite);
            this.Controls.Add(this.btnUrgente);
            this.Controls.Add(this.btnHaute);
            this.Controls.Add(this.btnMoyenne);
            this.Controls.Add(this.btnFaible);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPriorite";
            this.Text = "formPriorite";
            this.Load += new System.EventHandler(this.formPriorite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewPrio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox comboBoxPriorite;
        private System.Windows.Forms.Label lblPriorite;
        private System.Windows.Forms.Button btnUrgente;
        private System.Windows.Forms.Button btnHaute;
        private System.Windows.Forms.Button btnMoyenne;
        private System.Windows.Forms.Button btnFaible;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewPrio;
        private GestionTicketDataSet3 gestionTicketDataSet3;
        private System.Windows.Forms.BindingSource ticketTblBindingSource;
        private GestionTicketDataSet3TableAdapters.TicketTblTableAdapter ticketTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTicketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioriteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTousTickets1;
        private System.Windows.Forms.Button buttonModifier;
        private GestionTicketDataSet4 gestionTicketDataSet4;
        private System.Windows.Forms.BindingSource ticketTblBindingSource1;
        private GestionTicketDataSet4TableAdapters.TicketTblTableAdapter ticketTblTableAdapter1;
    }
}