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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.comboBoxPriorite = new System.Windows.Forms.ComboBox();
            this.lblPriorite = new System.Windows.Forms.Label();
            this.btnUrgente = new System.Windows.Forms.Button();
            this.btnHaute = new System.Windows.Forms.Button();
            this.btnMoyenne = new System.Windows.Forms.Button();
            this.btnFaible = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(268, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(565, 176);
            this.dataGridView1.TabIndex = 12;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label.Location = new System.Drawing.Point(29, 79);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(115, 20);
            this.label.TabIndex = 11;
            this.label.Text = "Sélectionnez priorité";
            // 
            // comboBoxPriorite
            // 
            this.comboBoxPriorite.FormattingEnabled = true;
            this.comboBoxPriorite.Location = new System.Drawing.Point(31, 102);
            this.comboBoxPriorite.Name = "comboBoxPriorite";
            this.comboBoxPriorite.Size = new System.Drawing.Size(146, 21);
            this.comboBoxPriorite.TabIndex = 10;
            // 
            // lblPriorite
            // 
            this.lblPriorite.AutoSize = true;
            this.lblPriorite.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorite.ForeColor = System.Drawing.Color.Navy;
            this.lblPriorite.Location = new System.Drawing.Point(26, 18);
            this.lblPriorite.Name = "lblPriorite";
            this.lblPriorite.Size = new System.Drawing.Size(167, 34);
            this.lblPriorite.TabIndex = 9;
            this.lblPriorite.Text = "Priorité de Ticket";
            // 
            // btnUrgente
            // 
            this.btnUrgente.BackColor = System.Drawing.Color.OrangeRed;
            this.btnUrgente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrgente.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrgente.ForeColor = System.Drawing.Color.White;
            this.btnUrgente.Location = new System.Drawing.Point(714, 51);
            this.btnUrgente.Name = "btnUrgente";
            this.btnUrgente.Size = new System.Drawing.Size(119, 37);
            this.btnUrgente.TabIndex = 5;
            this.btnUrgente.Text = "Urgente";
            this.btnUrgente.UseVisualStyleBackColor = false;
            // 
            // btnHaute
            // 
            this.btnHaute.BackColor = System.Drawing.Color.DarkOrange;
            this.btnHaute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHaute.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHaute.ForeColor = System.Drawing.Color.White;
            this.btnHaute.Location = new System.Drawing.Point(567, 51);
            this.btnHaute.Name = "btnHaute";
            this.btnHaute.Size = new System.Drawing.Size(119, 37);
            this.btnHaute.TabIndex = 6;
            this.btnHaute.Text = "Haute";
            this.btnHaute.UseVisualStyleBackColor = false;
            // 
            // btnMoyenne
            // 
            this.btnMoyenne.BackColor = System.Drawing.Color.Gold;
            this.btnMoyenne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoyenne.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoyenne.ForeColor = System.Drawing.Color.White;
            this.btnMoyenne.Location = new System.Drawing.Point(421, 51);
            this.btnMoyenne.Name = "btnMoyenne";
            this.btnMoyenne.Size = new System.Drawing.Size(119, 37);
            this.btnMoyenne.TabIndex = 7;
            this.btnMoyenne.Text = "Moyenne";
            this.btnMoyenne.UseVisualStyleBackColor = false;
            // 
            // btnFaible
            // 
            this.btnFaible.BackColor = System.Drawing.Color.GreenYellow;
            this.btnFaible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaible.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaible.ForeColor = System.Drawing.Color.White;
            this.btnFaible.Location = new System.Drawing.Point(268, 51);
            this.btnFaible.Name = "btnFaible";
            this.btnFaible.Size = new System.Drawing.Size(119, 37);
            this.btnFaible.TabIndex = 8;
            this.btnFaible.Text = "Faible";
            this.btnFaible.UseVisualStyleBackColor = false;
            // 
            // formPriorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 411);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox comboBoxPriorite;
        private System.Windows.Forms.Label lblPriorite;
        private System.Windows.Forms.Button btnUrgente;
        private System.Windows.Forms.Button btnHaute;
        private System.Windows.Forms.Button btnMoyenne;
        private System.Windows.Forms.Button btnFaible;
    }
}