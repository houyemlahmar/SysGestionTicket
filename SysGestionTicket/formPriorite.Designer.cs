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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPriorite));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label = new System.Windows.Forms.Label();
            this.comboBoxPriorite = new System.Windows.Forms.ComboBox();
            this.lblPriorite = new System.Windows.Forms.Label();
            this.btnUrgente = new System.Windows.Forms.Button();
            this.btnHaute = new System.Windows.Forms.Button();
            this.btnMoyenne = new System.Windows.Forms.Button();
            this.btnFaible = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DataGridViewPrio = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTicketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioriteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionTicketDataSet3 = new SysGestionTicket.GestionTicketDataSet3();
            this.ticketTblTableAdapter = new SysGestionTicket.GestionTicketDataSet3TableAdapters.TicketTblTableAdapter();
            this.lblTousTickets1 = new System.Windows.Forms.Label();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewPrio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label.Location = new System.Drawing.Point(35, 188);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(115, 20);
            this.label.TabIndex = 11;
            this.label.Text = "Sélectionnez priorité";
            // 
            // comboBoxPriorite
            // 
            this.comboBoxPriorite.FormattingEnabled = true;
            this.comboBoxPriorite.Location = new System.Drawing.Point(37, 211);
            this.comboBoxPriorite.Name = "comboBoxPriorite";
            this.comboBoxPriorite.Size = new System.Drawing.Size(157, 21);
            this.comboBoxPriorite.TabIndex = 10;
            // 
            // lblPriorite
            // 
            this.lblPriorite.AutoSize = true;
            this.lblPriorite.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorite.ForeColor = System.Drawing.Color.Navy;
            this.lblPriorite.Location = new System.Drawing.Point(32, 127);
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
            this.btnUrgente.Location = new System.Drawing.Point(710, 160);
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
            this.btnHaute.Location = new System.Drawing.Point(563, 160);
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
            this.btnMoyenne.Location = new System.Drawing.Point(417, 160);
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
            this.btnFaible.Location = new System.Drawing.Point(264, 160);
            this.btnFaible.Name = "btnFaible";
            this.btnFaible.Size = new System.Drawing.Size(119, 37);
            this.btnFaible.TabIndex = 8;
            this.btnFaible.Text = "Faible";
            this.btnFaible.UseVisualStyleBackColor = false;
            this.btnFaible.Click += new System.EventHandler(this.btnFaible_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.panel2.Location = new System.Drawing.Point(244, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 60);
            this.panel2.TabIndex = 18;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SysGestionTicket.Properties.Resources.notification1;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(53, 60);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(64, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Notification";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.panel4.Location = new System.Drawing.Point(689, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 60);
            this.panel4.TabIndex = 19;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Goldenrod;
            this.label8.Location = new System.Drawing.Point(64, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Statut";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.panel5.Location = new System.Drawing.Point(38, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(156, 60);
            this.panel5.TabIndex = 20;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(59, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Priorité";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.panel3.Location = new System.Drawing.Point(489, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 60);
            this.panel3.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(59, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tickets";
            // 
            // guna2DataGridViewPrio
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.guna2DataGridViewPrio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridViewPrio.AutoGenerateColumns = false;
            this.guna2DataGridViewPrio.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.guna2DataGridViewPrio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewPrio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridViewPrio.ColumnHeadersHeight = 4;
            this.guna2DataGridViewPrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridViewPrio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numTicketDataGridViewTextBoxColumn,
            this.titreDataGridViewTextBoxColumn,
            this.prioriteDataGridViewTextBoxColumn,
            this.statueDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.dateCreationDataGridViewTextBoxColumn});
            this.guna2DataGridViewPrio.DataSource = this.ticketTblBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridViewPrio.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridViewPrio.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(177)))));
            this.guna2DataGridViewPrio.Location = new System.Drawing.Point(246, 235);
            this.guna2DataGridViewPrio.Name = "guna2DataGridViewPrio";
            this.guna2DataGridViewPrio.RowHeadersVisible = false;
            this.guna2DataGridViewPrio.Size = new System.Drawing.Size(603, 260);
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
            // statueDataGridViewTextBoxColumn
            // 
            this.statueDataGridViewTextBoxColumn.DataPropertyName = "Statue";
            this.statueDataGridViewTextBoxColumn.HeaderText = "Statue";
            this.statueDataGridViewTextBoxColumn.Name = "statueDataGridViewTextBoxColumn";
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
            this.lblTousTickets1.Location = new System.Drawing.Point(243, 213);
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
            this.buttonModifier.Location = new System.Drawing.Point(37, 250);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(157, 30);
            this.buttonModifier.TabIndex = 32;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = false;
            this.buttonModifier.Click += new System.EventHandler(this.button1_Click);
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
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewPrio)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewPrio;
        private GestionTicketDataSet3 gestionTicketDataSet3;
        private System.Windows.Forms.BindingSource ticketTblBindingSource;
        private GestionTicketDataSet3TableAdapters.TicketTblTableAdapter ticketTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTicketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioriteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTousTickets1;
        private System.Windows.Forms.Button buttonModifier;
    }
}