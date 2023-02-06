namespace ParkSystem.Forms
{
    partial class statistik
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
            this.dgv_daten = new System.Windows.Forms.DataGridView();
            this.parkdauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Dparkdauer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Dpreis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_daten)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_daten
            // 
            this.dgv_daten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_daten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_daten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parkdauer,
            this.preis});
            this.dgv_daten.Location = new System.Drawing.Point(12, 208);
            this.dgv_daten.Name = "dgv_daten";
            this.dgv_daten.Size = new System.Drawing.Size(400, 150);
            this.dgv_daten.TabIndex = 0;
            // 
            // parkdauer
            // 
            this.parkdauer.HeaderText = "Parkdauer";
            this.parkdauer.Name = "parkdauer";
            this.parkdauer.ReadOnly = true;
            // 
            // preis
            // 
            this.preis.HeaderText = "Preis";
            this.preis.Name = "preis";
            this.preis.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Druchschnittliche Parkdauer:";
            // 
            // lbl_Dparkdauer
            // 
            this.lbl_Dparkdauer.AutoSize = true;
            this.lbl_Dparkdauer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dparkdauer.Location = new System.Drawing.Point(13, 66);
            this.lbl_Dparkdauer.Name = "lbl_Dparkdauer";
            this.lbl_Dparkdauer.Size = new System.Drawing.Size(0, 24);
            this.lbl_Dparkdauer.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Druchschnittlicher bezahlte Preis:";
            // 
            // lbl_Dpreis
            // 
            this.lbl_Dpreis.AutoSize = true;
            this.lbl_Dpreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dpreis.Location = new System.Drawing.Point(13, 148);
            this.lbl_Dpreis.Name = "lbl_Dpreis";
            this.lbl_Dpreis.Size = new System.Drawing.Size(0, 24);
            this.lbl_Dpreis.TabIndex = 4;
            // 
            // statistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 373);
            this.Controls.Add(this.lbl_Dpreis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Dparkdauer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_daten);
            this.Name = "statistik";
            this.Text = "statistik";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_daten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_daten;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkdauer;
        private System.Windows.Forms.DataGridViewTextBoxColumn preis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Dparkdauer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Dpreis;
    }
}