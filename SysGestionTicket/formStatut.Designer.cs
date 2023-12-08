namespace SysGestionTicket
{
    partial class formStatue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formStatue));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOuverte = new System.Windows.Forms.Button();
            this.btnEncours = new System.Windows.Forms.Button();
            this.btnResolue = new System.Windows.Forms.Button();
            this.btnFerme = new System.Windows.Forms.Button();
            this.lblStatue = new System.Windows.Forms.Label();
            this.comboBoxStatue = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTousTickets = new System.Windows.Forms.Label();
            this.guna2DataGridViewStatue = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gestionTicketDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionTicketDataSet3 = new SysGestionTicket.GestionTicketDataSet3();
            this.ticketTblTableAdapter = new SysGestionTicket.GestionTicketDataSet3TableAdapters.TicketTblTableAdapter();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewStatue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOuverte
            // 
            this.btnOuverte.BackColor = System.Drawing.Color.YellowGreen;
            this.btnOuverte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOuverte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOuverte.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOuverte.ForeColor = System.Drawing.Color.White;
            this.btnOuverte.Location = new System.Drawing.Point(262, 156);
            this.btnOuverte.Name = "btnOuverte";
            this.btnOuverte.Size = new System.Drawing.Size(119, 37);
            this.btnOuverte.TabIndex = 0;
            this.btnOuverte.Text = "Ouverte";
            this.btnOuverte.UseVisualStyleBackColor = false;
            this.btnOuverte.Click += new System.EventHandler(this.btnOuverte_Click);
            // 
            // btnEncours
            // 
            this.btnEncours.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnEncours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncours.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncours.ForeColor = System.Drawing.Color.White;
            this.btnEncours.Location = new System.Drawing.Point(415, 156);
            this.btnEncours.Name = "btnEncours";
            this.btnEncours.Size = new System.Drawing.Size(119, 37);
            this.btnEncours.TabIndex = 0;
            this.btnEncours.Text = "En cours";
            this.btnEncours.UseVisualStyleBackColor = false;
            this.btnEncours.Click += new System.EventHandler(this.btnEncours_Click);
            // 
            // btnResolue
            // 
            this.btnResolue.BackColor = System.Drawing.Color.DarkCyan;
            this.btnResolue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResolue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolue.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolue.ForeColor = System.Drawing.Color.White;
            this.btnResolue.Location = new System.Drawing.Point(561, 156);
            this.btnResolue.Name = "btnResolue";
            this.btnResolue.Size = new System.Drawing.Size(119, 37);
            this.btnResolue.TabIndex = 0;
            this.btnResolue.Text = "Résolue";
            this.btnResolue.UseVisualStyleBackColor = false;
            this.btnResolue.Click += new System.EventHandler(this.btnResolue_Click);
            // 
            // btnFerme
            // 
            this.btnFerme.BackColor = System.Drawing.Color.DarkRed;
            this.btnFerme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFerme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFerme.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFerme.ForeColor = System.Drawing.Color.White;
            this.btnFerme.Location = new System.Drawing.Point(708, 156);
            this.btnFerme.Name = "btnFerme";
            this.btnFerme.Size = new System.Drawing.Size(119, 37);
            this.btnFerme.TabIndex = 0;
            this.btnFerme.Text = "Fermée";
            this.btnFerme.UseVisualStyleBackColor = false;
            this.btnFerme.Click += new System.EventHandler(this.btnFerme_Click);
            // 
            // lblStatue
            // 
            this.lblStatue.AutoSize = true;
            this.lblStatue.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatue.ForeColor = System.Drawing.Color.Navy;
            this.lblStatue.Location = new System.Drawing.Point(31, 123);
            this.lblStatue.Name = "lblStatue";
            this.lblStatue.Size = new System.Drawing.Size(157, 34);
            this.lblStatue.TabIndex = 1;
            this.lblStatue.Text = "Statue de Ticket";
            // 
            // comboBoxStatue
            // 
            this.comboBoxStatue.FormattingEnabled = true;
            this.comboBoxStatue.Location = new System.Drawing.Point(36, 207);
            this.comboBoxStatue.Name = "comboBoxStatue";
            this.comboBoxStatue.Size = new System.Drawing.Size(160, 21);
            this.comboBoxStatue.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(34, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sélectionnez statue";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.panel3.Location = new System.Drawing.Point(696, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 60);
            this.panel3.TabIndex = 25;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(59, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tickets";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.panel2.Location = new System.Drawing.Point(451, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 60);
            this.panel2.TabIndex = 22;
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.panel5.Location = new System.Drawing.Point(245, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(156, 60);
            this.panel5.TabIndex = 24;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(59, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Priorité";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.panel4.Location = new System.Drawing.Point(36, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 60);
            this.panel4.TabIndex = 26;
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
            // lblTousTickets
            // 
            this.lblTousTickets.AutoSize = true;
            this.lblTousTickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTousTickets.Font = new System.Drawing.Font("Nirmala UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTousTickets.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTousTickets.Location = new System.Drawing.Point(242, 213);
            this.lblTousTickets.Name = "lblTousTickets";
            this.lblTousTickets.Size = new System.Drawing.Size(91, 15);
            this.lblTousTickets.TabIndex = 30;
            this.lblTousTickets.Text = "Tous les tickets";
            // 
            // guna2DataGridViewStatue
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.guna2DataGridViewStatue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridViewStatue.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.guna2DataGridViewStatue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewStatue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridViewStatue.ColumnHeadersHeight = 4;
            this.guna2DataGridViewStatue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridViewStatue.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridViewStatue.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(177)))));
            this.guna2DataGridViewStatue.Location = new System.Drawing.Point(245, 243);
            this.guna2DataGridViewStatue.Name = "guna2DataGridViewStatue";
            this.guna2DataGridViewStatue.RowHeadersVisible = false;
            this.guna2DataGridViewStatue.Size = new System.Drawing.Size(603, 237);
            this.guna2DataGridViewStatue.TabIndex = 31;
            this.guna2DataGridViewStatue.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember;
            this.guna2DataGridViewStatue.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.guna2DataGridViewStatue.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridViewStatue.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewStatue.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewStatue.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewStatue.ThemeStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.guna2DataGridViewStatue.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(177)))));
            this.guna2DataGridViewStatue.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            this.guna2DataGridViewStatue.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridViewStatue.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewStatue.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewStatue.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridViewStatue.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridViewStatue.ThemeStyle.ReadOnly = false;
            this.guna2DataGridViewStatue.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            this.guna2DataGridViewStatue.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewStatue.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewStatue.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridViewStatue.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridViewStatue.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.guna2DataGridViewStatue.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridViewStatue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridViewStatue_CellContentClick);
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
            // ticketTblTableAdapter
            // 
            this.ticketTblTableAdapter.ClearBeforeFill = true;
            // 
            // formStatue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 521);
            this.Controls.Add(this.guna2DataGridViewStatue);
            this.Controls.Add(this.lblTousTickets);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxStatue);
            this.Controls.Add(this.lblStatue);
            this.Controls.Add(this.btnFerme);
            this.Controls.Add(this.btnResolue);
            this.Controls.Add(this.btnEncours);
            this.Controls.Add(this.btnOuverte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formStatue";
            this.Text = "formStatue";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewStatue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOuverte;
        private System.Windows.Forms.Button btnEncours;
        private System.Windows.Forms.Button btnResolue;
        private System.Windows.Forms.Button btnFerme;
        private System.Windows.Forms.Label lblStatue;
        private System.Windows.Forms.ComboBox comboBoxStatue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTousTickets;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewStatue;
        private System.Windows.Forms.BindingSource gestionTicketDataSet3BindingSource;
        private GestionTicketDataSet3 gestionTicketDataSet3;
        private GestionTicketDataSet3TableAdapters.TicketTblTableAdapter ticketTblTableAdapter;
    }
}