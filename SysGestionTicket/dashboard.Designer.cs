﻿namespace SysGestionTicket
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunabtnTicket = new Guna.UI2.WinForms.Guna2Button();
            this.gunabtnStatut = new Guna.UI2.WinForms.Guna2Button();
            this.gunabtnPriorite = new Guna.UI2.WinForms.Guna2Button();
            this.gunabtnNotif = new Guna.UI2.WinForms.Guna2Button();
            this.gunabtnDecnx = new Guna.UI2.WinForms.Guna2Button();
            this.ticketTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionTicketDataSet1 = new SysGestionTicket.GestionTicketDataSet1();
            this.ticketTblTableAdapter = new SysGestionTicket.GestionTicketDataSet1TableAdapters.TicketTblTableAdapter();
            this.panelForm = new System.Windows.Forms.Panel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
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
            this.label4.Location = new System.Drawing.Point(32, 69);
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
            this.flowLayoutPanel1.Controls.Add(this.gunabtnStatut);
            this.flowLayoutPanel1.Controls.Add(this.gunabtnPriorite);
            this.flowLayoutPanel1.Controls.Add(this.gunabtnNotif);
            this.flowLayoutPanel1.Controls.Add(this.gunabtnDecnx);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(146, 521);
            this.flowLayoutPanel1.TabIndex = 1;
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
            // gunabtnStatut
            // 
            this.gunabtnStatut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunabtnStatut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunabtnStatut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunabtnStatut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunabtnStatut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunabtnStatut.FillColor = System.Drawing.Color.LightCyan;
            this.gunabtnStatut.Font = new System.Drawing.Font("Lucida Fax", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunabtnStatut.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gunabtnStatut.Image = global::SysGestionTicket.Properties.Resources.rules;
            this.gunabtnStatut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunabtnStatut.Location = new System.Drawing.Point(3, 150);
            this.gunabtnStatut.Name = "gunabtnStatut";
            this.gunabtnStatut.Size = new System.Drawing.Size(135, 37);
            this.gunabtnStatut.TabIndex = 23;
            this.gunabtnStatut.Text = "Statut";
            this.gunabtnStatut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunabtnStatut.Click += new System.EventHandler(this.guna2Button2_Click);
            this.gunabtnStatut.Leave += new System.EventHandler(this.gunabtnStatue_leave);
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
            this.panelForm.Location = new System.Drawing.Point(146, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(888, 521);
            this.panelForm.TabIndex = 7;
            this.panelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1034, 521);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceuil";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ticketTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionTicketDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private GestionTicketDataSet1 gestionTicketDataSet1;
        private System.Windows.Forms.BindingSource ticketTblBindingSource;
        private GestionTicketDataSet1TableAdapters.TicketTblTableAdapter ticketTblTableAdapter;
        private System.Windows.Forms.Panel panelForm;
        private Guna.UI2.WinForms.Guna2Button gunabtnNotif;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button gunabtnTicket;
        private Guna.UI2.WinForms.Guna2Button gunabtnStatut;
        private Guna.UI2.WinForms.Guna2Button gunabtnPriorite;
        private Guna.UI2.WinForms.Guna2Button gunabtnDecnx;
    }
}