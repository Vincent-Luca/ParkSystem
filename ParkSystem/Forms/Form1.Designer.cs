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
            this.belegte_park_NUD = new System.Windows.Forms.NumericUpDown();
            this.freie_park_NUD = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uhrzeit_cmb = new System.Windows.Forms.ComboBox();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Statistik = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.belegte_park_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freie_park_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticket_nr_NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Statistik);
            this.panel1.Controls.Add(this.belegte_park_NUD);
            this.panel1.Controls.Add(this.freie_park_NUD);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.uhrzeit_cmb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(333, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 368);
            this.panel1.TabIndex = 0;
            // 
            // belegte_park_NUD
            // 
            this.belegte_park_NUD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.belegte_park_NUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.belegte_park_NUD.InterceptArrowKeys = false;
            this.belegte_park_NUD.Location = new System.Drawing.Point(178, 139);
            this.belegte_park_NUD.Margin = new System.Windows.Forms.Padding(2);
            this.belegte_park_NUD.Name = "belegte_park_NUD";
            this.belegte_park_NUD.ReadOnly = true;
            this.belegte_park_NUD.Size = new System.Drawing.Size(121, 20);
            this.belegte_park_NUD.TabIndex = 17;
            // 
            // freie_park_NUD
            // 
            this.freie_park_NUD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.freie_park_NUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.freie_park_NUD.InterceptArrowKeys = false;
            this.freie_park_NUD.Location = new System.Drawing.Point(38, 139);
            this.freie_park_NUD.Margin = new System.Windows.Forms.Padding(2);
            this.freie_park_NUD.Name = "freie_park_NUD";
            this.freie_park_NUD.ReadOnly = true;
            this.freie_park_NUD.Size = new System.Drawing.Size(111, 20);
            this.freie_park_NUD.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(174, 115);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Belegte Parkplätze";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Freie Parkplätze";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(219, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Uhr Zeit";
            // 
            // uhrzeit_cmb
            // 
            this.uhrzeit_cmb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uhrzeit_cmb.FormattingEnabled = true;
            this.uhrzeit_cmb.Items.AddRange(new object[] {
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00"});
            this.uhrzeit_cmb.Location = new System.Drawing.Point(208, 57);
            this.uhrzeit_cmb.Margin = new System.Windows.Forms.Padding(2);
            this.uhrzeit_cmb.Name = "uhrzeit_cmb";
            this.uhrzeit_cmb.Size = new System.Drawing.Size(92, 21);
            this.uhrzeit_cmb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEV Tools";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 265);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ticket Nummer:";
            // 
            // ticket_nr_NUD
            // 
            this.ticket_nr_NUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ticket_nr_NUD.Location = new System.Drawing.Point(9, 288);
            this.ticket_nr_NUD.Margin = new System.Windows.Forms.Padding(2);
            this.ticket_nr_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ticket_nr_NUD.Name = "ticket_nr_NUD";
            this.ticket_nr_NUD.Size = new System.Drawing.Size(109, 20);
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
            this.ticket_ziehen_btn.Location = new System.Drawing.Point(8, 49);
            this.ticket_ziehen_btn.Margin = new System.Windows.Forms.Padding(2);
            this.ticket_ziehen_btn.Name = "ticket_ziehen_btn";
            this.ticket_ziehen_btn.Size = new System.Drawing.Size(109, 68);
            this.ticket_ziehen_btn.TabIndex = 4;
            this.ticket_ziehen_btn.Text = "Ticket Ziehen";
            this.ticket_ziehen_btn.UseVisualStyleBackColor = true;
            this.ticket_ziehen_btn.Click += new System.EventHandler(this.ticket_ziehen_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dein Ticket ist Nr:";
            // 
            // ticket_nr_lbl
            // 
            this.ticket_nr_lbl.AutoSize = true;
            this.ticket_nr_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket_nr_lbl.Location = new System.Drawing.Point(122, 97);
            this.ticket_nr_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ticket_nr_lbl.Name = "ticket_nr_lbl";
            this.ticket_nr_lbl.Size = new System.Drawing.Size(0, 20);
            this.ticket_nr_lbl.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preis: 30min -> 2€";
            // 
            // bezahlen_btn
            // 
            this.bezahlen_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bezahlen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bezahlen_btn.Location = new System.Drawing.Point(9, 310);
            this.bezahlen_btn.Margin = new System.Windows.Forms.Padding(2);
            this.bezahlen_btn.Name = "bezahlen_btn";
            this.bezahlen_btn.Size = new System.Drawing.Size(109, 29);
            this.bezahlen_btn.TabIndex = 8;
            this.bezahlen_btn.Text = "Bezahlen";
            this.bezahlen_btn.UseVisualStyleBackColor = true;
            this.bezahlen_btn.Click += new System.EventHandler(this.bezahlen_btn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Preis zu zahlen:";
            // 
            // amount_to_pay_lbl
            // 
            this.amount_to_pay_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.amount_to_pay_lbl.AutoSize = true;
            this.amount_to_pay_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_to_pay_lbl.Location = new System.Drawing.Point(122, 310);
            this.amount_to_pay_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amount_to_pay_lbl.Name = "amount_to_pay_lbl";
            this.amount_to_pay_lbl.Size = new System.Drawing.Size(0, 20);
            this.amount_to_pay_lbl.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Statistik
            // 
            this.btn_Statistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Statistik.Location = new System.Drawing.Point(178, 238);
            this.btn_Statistik.Name = "btn_Statistik";
            this.btn_Statistik.Size = new System.Drawing.Size(122, 47);
            this.btn_Statistik.TabIndex = 18;
            this.btn_Statistik.Text = "Statistik";
            this.btn_Statistik.UseVisualStyleBackColor = true;
            this.btn_Statistik.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 366);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(657, 405);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.belegte_park_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freie_park_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticket_nr_NUD)).EndInit();
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
        private System.Windows.Forms.Button btn_Statistik;
    }
}

