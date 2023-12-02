namespace SysGestionTicket
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ticketTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionTicketDataSet1 = new SysGestionTicket.GestionTicketDataSet1();
            this.ticketTblTableAdapter = new SysGestionTicket.GestionTicketDataSet1TableAdapters.TicketTblTableAdapter();
            this.panelForm = new System.Windows.Forms.Panel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunabtnTicket = new Guna.UI2.WinForms.Guna2Button();
            this.gunabtnStatue = new Guna.UI2.WinForms.Guna2Button();
            this.gunabtnPriorite = new Guna.UI2.WinForms.Guna2Button();
            this.gunabtnNotif = new Guna.UI2.WinForms.Guna2Button();
            this.gunabtnDecnx = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 98);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("CentSchbkCyrill BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(33, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "User name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightCyan;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.gunabtnTicket);
            this.flowLayoutPanel1.Controls.Add(this.gunabtnStatue);
            this.flowLayoutPanel1.Controls.Add(this.gunabtnPriorite);
            this.flowLayoutPanel1.Controls.Add(this.gunabtnNotif);
            this.flowLayoutPanel1.Controls.Add(this.gunabtnDecnx);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(146, 521);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.panel3.Location = new System.Drawing.Point(181, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 60);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.panel4.Location = new System.Drawing.Point(381, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 60);
            this.panel4.TabIndex = 6;
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.panel5.Location = new System.Drawing.Point(591, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(156, 60);
            this.panel5.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.panel2.Location = new System.Drawing.Point(795, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 60);
            this.panel2.TabIndex = 6;
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
            // ticketTblBindingSource
            // 
            this.ticketTblBindingSource.DataMember = "TicketTbl";
            this.ticketTblBindingSource.DataSource = this.gestionTicketDataSet1;
            // 
            // gestionTicketDataSet1
            // 
            this.gestionTicketDataSet1.DataSetName = "GestionTicketDataSet1";
            this.gestionTicketDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketTblTableAdapter
            // 
            this.ticketTblTableAdapter.ClearBeforeFill = true;
            // 
            // panelForm
            // 
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelForm.Location = new System.Drawing.Point(146, 110);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(888, 411);
            this.panelForm.TabIndex = 7;
            this.panelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gunabtnTicket
            // 
            this.gunabtnTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunabtnTicket.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunabtnTicket.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunabtnTicket.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunabtnTicket.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunabtnTicket.FillColor = System.Drawing.Color.LightCyan;
            this.gunabtnTicket.Font = new System.Drawing.Font("Lucida Fax", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunabtnTicket.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gunabtnTicket.Image = global::SysGestionTicket.Properties.Resources.cinema;
            this.gunabtnTicket.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunabtnTicket.Location = new System.Drawing.Point(3, 107);
            this.gunabtnTicket.Name = "gunabtnTicket";
            this.gunabtnTicket.Size = new System.Drawing.Size(135, 37);
            this.gunabtnTicket.TabIndex = 23;
            this.gunabtnTicket.Text = "Ticket";
            this.gunabtnTicket.Click += new System.EventHandler(this.guna2Button3_Click);
            this.gunabtnTicket.Leave += new System.EventHandler(this.gunabtnTicket_leave);
            // 
            // gunabtnStatue
            // 
            this.gunabtnStatue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunabtnStatue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunabtnStatue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunabtnStatue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunabtnStatue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunabtnStatue.FillColor = System.Drawing.Color.LightCyan;
            this.gunabtnStatue.Font = new System.Drawing.Font("Lucida Fax", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunabtnStatue.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gunabtnStatue.Image = global::SysGestionTicket.Properties.Resources.rules;
            this.gunabtnStatue.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunabtnStatue.Location = new System.Drawing.Point(3, 150);
            this.gunabtnStatue.Name = "gunabtnStatue";
            this.gunabtnStatue.Size = new System.Drawing.Size(135, 37);
            this.gunabtnStatue.TabIndex = 23;
            this.gunabtnStatue.Text = "Statue";
            this.gunabtnStatue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunabtnStatue.Click += new System.EventHandler(this.guna2Button2_Click);
            this.gunabtnStatue.Leave += new System.EventHandler(this.gunabtnStatue_leave);
            // 
            // gunabtnPriorite
            // 
            this.gunabtnPriorite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunabtnPriorite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunabtnPriorite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunabtnPriorite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunabtnPriorite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunabtnPriorite.FillColor = System.Drawing.Color.LightCyan;
            this.gunabtnPriorite.Font = new System.Drawing.Font("Lucida Fax", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gunabtnPriorite.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gunabtnPriorite.Image = global::SysGestionTicket.Properties.Resources.prioritize;
            this.gunabtnPriorite.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunabtnPriorite.Location = new System.Drawing.Point(3, 193);
            this.gunabtnPriorite.Name = "gunabtnPriorite";
            this.gunabtnPriorite.Size = new System.Drawing.Size(132, 37);
            this.gunabtnPriorite.TabIndex = 23;
            this.gunabtnPriorite.Text = "Priorité";
            this.gunabtnPriorite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunabtnPriorite.Click += new System.EventHandler(this.gunabtnPriorite_Click);
            this.gunabtnPriorite.Leave += new System.EventHandler(this.gunabtnPriorite_leave);
            // 
            // gunabtnNotif
            // 
            this.gunabtnNotif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunabtnNotif.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunabtnNotif.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunabtnNotif.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunabtnNotif.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunabtnNotif.FillColor = System.Drawing.Color.LightCyan;
            this.gunabtnNotif.Font = new System.Drawing.Font("Lucida Fax", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunabtnNotif.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gunabtnNotif.Image = global::SysGestionTicket.Properties.Resources.notifications;
            this.gunabtnNotif.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunabtnNotif.Location = new System.Drawing.Point(3, 236);
            this.gunabtnNotif.Name = "gunabtnNotif";
            this.gunabtnNotif.Size = new System.Drawing.Size(135, 37);
            this.gunabtnNotif.TabIndex = 23;
            this.gunabtnNotif.Text = "Notification";
            this.gunabtnNotif.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunabtnNotif.Click += new System.EventHandler(this.gunabtnStat_Click);
            this.gunabtnNotif.Leave += new System.EventHandler(this.gunabtnStat_leave);
            // 
            // gunabtnDecnx
            // 
            this.gunabtnDecnx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunabtnDecnx.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunabtnDecnx.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunabtnDecnx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunabtnDecnx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunabtnDecnx.FillColor = System.Drawing.Color.LightCyan;
            this.gunabtnDecnx.Font = new System.Drawing.Font("Lucida Fax", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunabtnDecnx.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gunabtnDecnx.Image = global::SysGestionTicket.Properties.Resources.lodout;
            this.gunabtnDecnx.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunabtnDecnx.Location = new System.Drawing.Point(3, 279);
            this.gunabtnDecnx.Name = "gunabtnDecnx";
            this.gunabtnDecnx.Size = new System.Drawing.Size(135, 37);
            this.gunabtnDecnx.TabIndex = 24;
            this.gunabtnDecnx.Text = "Déconnexion";
            this.gunabtnDecnx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunabtnDecnx.Click += new System.EventHandler(this.gunabtnDecnx_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1034, 521);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceuil";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private GestionTicketDataSet1 gestionTicketDataSet1;
        private System.Windows.Forms.BindingSource ticketTblBindingSource;
        private GestionTicketDataSet1TableAdapters.TicketTblTableAdapter ticketTblTableAdapter;
        private System.Windows.Forms.Panel panelForm;
        private Guna.UI2.WinForms.Guna2Button gunabtnNotif;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button gunabtnTicket;
        private Guna.UI2.WinForms.Guna2Button gunabtnStatue;
        private Guna.UI2.WinForms.Guna2Button gunabtnPriorite;
        private Guna.UI2.WinForms.Guna2Button gunabtnDecnx;
    }
}