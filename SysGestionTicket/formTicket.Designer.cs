namespace SysGestionTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTicket));
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
            this.ticketTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionTicketDataSet3 = new SysGestionTicket.GestionTicketDataSet3();
            this.gestionTicketDataSet1 = new SysGestionTicket.GestionTicketDataSet1();
            this.gestionTicketDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketTblTableAdapter = new SysGestionTicket.GestionTicketDataSet3TableAdapters.TicketTblTableAdapter();
            this.dateCreation = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ListeTicket = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeTicket)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRecherche
            // 
            this.txtRecherche.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRecherche.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.ForeColor = System.Drawing.Color.Black;
            this.txtRecherche.Location = new System.Drawing.Point(527, 139);
            this.txtRecherche.Multiline = true;
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(205, 25);
            this.txtRecherche.TabIndex = 1;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Navy;
            this.lbl.Location = new System.Drawing.Point(31, 110);
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
            this.lblTitre.Location = new System.Drawing.Point(19, 159);
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
            this.txtNumTicket.Location = new System.Drawing.Point(22, 178);
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
            this.lblDep.Location = new System.Drawing.Point(19, 216);
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
            this.txtTitre.Location = new System.Drawing.Point(22, 235);
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
            this.lblPriorite.Location = new System.Drawing.Point(19, 270);
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
            this.lblDescri.Location = new System.Drawing.Point(19, 319);
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
            this.txtDescri.Location = new System.Drawing.Point(22, 338);
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
            this.btnCreer.Location = new System.Drawing.Point(22, 466);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(106, 34);
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
            this.comboBoxPrio.Location = new System.Drawing.Point(22, 289);
            this.comboBoxPrio.Name = "comboBoxPrio";
            this.comboBoxPrio.Size = new System.Drawing.Size(184, 32);
            this.comboBoxPrio.TabIndex = 7;
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
            // gestionTicketDataSet1
            // 
            this.gestionTicketDataSet1.DataSetName = "GestionTicketDataSet1";
            this.gestionTicketDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestionTicketDataSet1BindingSource
            // 
            this.gestionTicketDataSet1BindingSource.DataSource = this.gestionTicketDataSet1;
            this.gestionTicketDataSet1BindingSource.Position = 0;
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
            this.dateCreation.Location = new System.Drawing.Point(22, 417);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListeTicket.DefaultCellStyle = dataGridViewCellStyle3;
            this.ListeTicket.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(177)))));
            this.ListeTicket.Location = new System.Drawing.Point(237, 190);
            this.ListeTicket.Name = "ListeTicket";
            this.ListeTicket.RowHeadersVisible = false;
            this.ListeTicket.Size = new System.Drawing.Size(639, 310);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.panel2.Location = new System.Drawing.Point(651, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 60);
            this.panel2.TabIndex = 14;
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
            this.panel4.Location = new System.Drawing.Point(237, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 60);
            this.panel4.TabIndex = 15;
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
            this.label8.Size = new System.Drawing.Size(84, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Statues";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.panel3.Location = new System.Drawing.Point(37, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 60);
            this.panel3.TabIndex = 13;
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.panel5.Location = new System.Drawing.Point(447, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(156, 60);
            this.panel5.TabIndex = 16;
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
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::SysGestionTicket.Properties.Resources.search1;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(60, 60);
            this.guna2ImageButton1.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.guna2ImageButton1.Location = new System.Drawing.Point(738, 129);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(35, 35);
            this.guna2ImageButton1.TabIndex = 17;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CirclePictureBox2.Image = global::SysGestionTicket.Properties.Resources.rename;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(142, 466);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(29, 34);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 12;
            this.guna2CirclePictureBox2.TabStop = false;
            this.guna2CirclePictureBox2.Click += new System.EventHandler(this.guna2CirclePictureBox2_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CirclePictureBox1.Image = global::SysGestionTicket.Properties.Resources.delete;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(177, 466);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(29, 34);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 11;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // formTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(888, 521);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.guna2CirclePictureBox2);
            this.Controls.Add(this.guna2CirclePictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.ticketTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeTicket)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
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
        private GestionTicketDataSet1 gestionTicketDataSet1;
        private System.Windows.Forms.BindingSource gestionTicketDataSet1BindingSource;
        private GestionTicketDataSet3 gestionTicketDataSet3;
        private System.Windows.Forms.BindingSource ticketTblBindingSource;
        private GestionTicketDataSet3TableAdapters.TicketTblTableAdapter ticketTblTableAdapter;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateCreation;
        private Guna.UI2.WinForms.Guna2DataGridView ListeTicket;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}