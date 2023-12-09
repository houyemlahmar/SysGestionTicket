namespace SysGestionTicket
{
    partial class formAgent
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.gunabtnTicket = new Guna.UI2.WinForms.Guna2Button();
            this.gunabtnStatut = new Guna.UI2.WinForms.Guna2Button();
            this.gunabtnDecnx = new Guna.UI2.WinForms.Guna2Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightCyan;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.gunabtnTicket);
            this.flowLayoutPanel1.Controls.Add(this.gunabtnStatut);
            this.flowLayoutPanel1.Controls.Add(this.gunabtnDecnx);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(146, 521);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.labelUserName);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 98);
            this.panel1.TabIndex = 0;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("CentSchbkCyrill BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserName.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelUserName.Location = new System.Drawing.Point(33, 69);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(78, 16);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "User name";
            this.labelUserName.Click += new System.EventHandler(this.label4_Click);
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
            this.gunabtnTicket.Click += new System.EventHandler(this.gunabtnTicket_Click);
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
            this.gunabtnStatut.Click += new System.EventHandler(this.gunabtnStatut_Click);
            this.gunabtnStatut.Leave += new System.EventHandler(this.gunabtnStatut_leave);
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
            this.gunabtnDecnx.Location = new System.Drawing.Point(3, 193);
            this.gunabtnDecnx.Name = "gunabtnDecnx";
            this.gunabtnDecnx.Size = new System.Drawing.Size(135, 37);
            this.gunabtnDecnx.TabIndex = 24;
            this.gunabtnDecnx.Text = "Déconnexion";
            this.gunabtnDecnx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunabtnDecnx.Click += new System.EventHandler(this.gunabtnDecnx_Click);
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelForm.Location = new System.Drawing.Point(146, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(888, 521);
            this.panelForm.TabIndex = 8;
            // 
            // formAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 521);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "formAgent";
            this.Text = "Acceuil Agent";
            this.Load += new System.EventHandler(this.formAgent_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUserName;
        private Guna.UI2.WinForms.Guna2Button gunabtnTicket;
        private Guna.UI2.WinForms.Guna2Button gunabtnStatut;
        private Guna.UI2.WinForms.Guna2Button gunabtnDecnx;
        private System.Windows.Forms.Panel panelForm;
    }
}