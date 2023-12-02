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
            this.btnOuverte = new System.Windows.Forms.Button();
            this.btnEncours = new System.Windows.Forms.Button();
            this.btnResolue = new System.Windows.Forms.Button();
            this.btnFerme = new System.Windows.Forms.Button();
            this.lblStatue = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOuverte
            // 
            this.btnOuverte.BackColor = System.Drawing.Color.YellowGreen;
            this.btnOuverte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOuverte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOuverte.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOuverte.ForeColor = System.Drawing.Color.White;
            this.btnOuverte.Location = new System.Drawing.Point(272, 52);
            this.btnOuverte.Name = "btnOuverte";
            this.btnOuverte.Size = new System.Drawing.Size(119, 37);
            this.btnOuverte.TabIndex = 0;
            this.btnOuverte.Text = "Ouverte";
            this.btnOuverte.UseVisualStyleBackColor = false;
            // 
            // btnEncours
            // 
            this.btnEncours.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnEncours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncours.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncours.ForeColor = System.Drawing.Color.White;
            this.btnEncours.Location = new System.Drawing.Point(425, 52);
            this.btnEncours.Name = "btnEncours";
            this.btnEncours.Size = new System.Drawing.Size(119, 37);
            this.btnEncours.TabIndex = 0;
            this.btnEncours.Text = "En cours";
            this.btnEncours.UseVisualStyleBackColor = false;
            // 
            // btnResolue
            // 
            this.btnResolue.BackColor = System.Drawing.Color.DarkCyan;
            this.btnResolue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolue.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolue.ForeColor = System.Drawing.Color.White;
            this.btnResolue.Location = new System.Drawing.Point(571, 52);
            this.btnResolue.Name = "btnResolue";
            this.btnResolue.Size = new System.Drawing.Size(119, 37);
            this.btnResolue.TabIndex = 0;
            this.btnResolue.Text = "Résolue";
            this.btnResolue.UseVisualStyleBackColor = false;
            // 
            // btnFerme
            // 
            this.btnFerme.BackColor = System.Drawing.Color.DarkRed;
            this.btnFerme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFerme.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFerme.ForeColor = System.Drawing.Color.White;
            this.btnFerme.Location = new System.Drawing.Point(718, 52);
            this.btnFerme.Name = "btnFerme";
            this.btnFerme.Size = new System.Drawing.Size(119, 37);
            this.btnFerme.TabIndex = 0;
            this.btnFerme.Text = "Fermée";
            this.btnFerme.UseVisualStyleBackColor = false;
            // 
            // lblStatue
            // 
            this.lblStatue.AutoSize = true;
            this.lblStatue.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatue.ForeColor = System.Drawing.Color.Navy;
            this.lblStatue.Location = new System.Drawing.Point(30, 19);
            this.lblStatue.Name = "lblStatue";
            this.lblStatue.Size = new System.Drawing.Size(157, 34);
            this.lblStatue.TabIndex = 1;
            this.lblStatue.Text = "Statue de Ticket";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(33, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sélectionnez statue";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(272, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(565, 176);
            this.dataGridView1.TabIndex = 4;
            // 
            // formStatue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblStatue);
            this.Controls.Add(this.btnFerme);
            this.Controls.Add(this.btnResolue);
            this.Controls.Add(this.btnEncours);
            this.Controls.Add(this.btnOuverte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formStatue";
            this.Text = "formStatue";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOuverte;
        private System.Windows.Forms.Button btnEncours;
        private System.Windows.Forms.Button btnResolue;
        private System.Windows.Forms.Button btnFerme;
        private System.Windows.Forms.Label lblStatue;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}