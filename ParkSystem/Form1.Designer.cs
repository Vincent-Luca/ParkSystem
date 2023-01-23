namespace ParkSystem
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ticket_nr_NUD = new System.Windows.Forms.NumericUpDown();
            this.ticket_ziehen_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ticket_nr_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bezahlen_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.amount_to_pay_lbl = new System.Windows.Forms.Label();
            this.uhrzeit_cmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.freie_park_NUD = new System.Windows.Forms.NumericUpDown();
            this.belegte_park_NUD = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticket_nr_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freie_park_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belegte_park_NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.belegte_park_NUD);
            this.panel1.Controls.Add(this.freie_park_NUD);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.uhrzeit_cmb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(444, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 452);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEV Tools";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ticket Nummer:";
            // 
            // ticket_nr_NUD
            // 
            this.ticket_nr_NUD.Location = new System.Drawing.Point(12, 354);
            this.ticket_nr_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ticket_nr_NUD.Name = "ticket_nr_NUD";
            this.ticket_nr_NUD.Size = new System.Drawing.Size(145, 22);
            this.ticket_nr_NUD.TabIndex = 3;
            this.ticket_nr_NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // ticket_ziehen_btn
            // 
            this.ticket_ziehen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket_ziehen_btn.Location = new System.Drawing.Point(11, 60);
            this.ticket_ziehen_btn.Name = "ticket_ziehen_btn";
            this.ticket_ziehen_btn.Size = new System.Drawing.Size(145, 84);
            this.ticket_ziehen_btn.TabIndex = 4;
            this.ticket_ziehen_btn.Text = "Ticket Ziehen";
            this.ticket_ziehen_btn.UseVisualStyleBackColor = true;
            this.ticket_ziehen_btn.Click += new System.EventHandler(this.ticket_ziehen_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dein Ticket ist Nr:";
            // 
            // ticket_nr_lbl
            // 
            this.ticket_nr_lbl.AutoSize = true;
            this.ticket_nr_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket_nr_lbl.Location = new System.Drawing.Point(163, 119);
            this.ticket_nr_lbl.Name = "ticket_nr_lbl";
            this.ticket_nr_lbl.Size = new System.Drawing.Size(0, 25);
            this.ticket_nr_lbl.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preis: 30min -> 2€";
            // 
            // bezahlen_btn
            // 
            this.bezahlen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bezahlen_btn.Location = new System.Drawing.Point(12, 382);
            this.bezahlen_btn.Name = "bezahlen_btn";
            this.bezahlen_btn.Size = new System.Drawing.Size(145, 36);
            this.bezahlen_btn.TabIndex = 8;
            this.bezahlen_btn.Text = "Bezahlen";
            this.bezahlen_btn.UseVisualStyleBackColor = true;
            this.bezahlen_btn.Click += new System.EventHandler(this.bezahlen_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Preis zu zahlen:";
            // 
            // amount_to_pay_lbl
            // 
            this.amount_to_pay_lbl.AutoSize = true;
            this.amount_to_pay_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_to_pay_lbl.Location = new System.Drawing.Point(163, 382);
            this.amount_to_pay_lbl.Name = "amount_to_pay_lbl";
            this.amount_to_pay_lbl.Size = new System.Drawing.Size(0, 25);
            this.amount_to_pay_lbl.TabIndex = 10;
            // 
            // uhrzeit_cmb
            // 
            this.uhrzeit_cmb.FormattingEnabled = true;
            this.uhrzeit_cmb.Location = new System.Drawing.Point(277, 70);
            this.uhrzeit_cmb.Name = "uhrzeit_cmb";
            this.uhrzeit_cmb.Size = new System.Drawing.Size(121, 24);
            this.uhrzeit_cmb.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Uhr Zeit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Freie Parkplätze";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(232, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Belegte Parkplätze";
            // 
            // freie_park_NUD
            // 
            this.freie_park_NUD.Location = new System.Drawing.Point(50, 171);
            this.freie_park_NUD.Name = "freie_park_NUD";
            this.freie_park_NUD.ReadOnly = true;
            this.freie_park_NUD.Size = new System.Drawing.Size(148, 22);
            this.freie_park_NUD.TabIndex = 16;
            // 
            // belegte_park_NUD
            // 
            this.belegte_park_NUD.Location = new System.Drawing.Point(237, 171);
            this.belegte_park_NUD.Name = "belegte_park_NUD";
            this.belegte_park_NUD.ReadOnly = true;
            this.belegte_park_NUD.Size = new System.Drawing.Size(161, 22);
            this.belegte_park_NUD.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.amount_to_pay_lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bezahlen_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ticket_nr_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ticket_ziehen_btn);
            this.Controls.Add(this.ticket_nr_NUD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticket_nr_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freie_park_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belegte_park_NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ticket_nr_NUD;
        private System.Windows.Forms.Button ticket_ziehen_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ticket_nr_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bezahlen_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label amount_to_pay_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox uhrzeit_cmb;
        private System.Windows.Forms.NumericUpDown freie_park_NUD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown belegte_park_NUD;
        private System.Windows.Forms.Timer timer1;
    }
}

