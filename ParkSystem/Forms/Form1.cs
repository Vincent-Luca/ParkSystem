using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ParkSystem.Forms;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkSystem.Klassen;

namespace ParkSystem
{
    public partial class Form1 : Form
    {
        private DBVerbindung Databank;
        private Parkplatz[] plaetze = new Parkplatz[100];

        public Form1()
        {
            InitializeComponent();
            Fillplaetze();
            setNUP_frei_und_belegt();
            Databank = new DBVerbindung("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\gaimn\\Documents\\ParkSystem\\ParkSystem\\Parkhaus.mdb");
            uhrzeit_cmb.SelectedIndex = 0;
        }

        private void setNUP_frei_und_belegt()
        {
            freie_park_NUD.Value = Convert.ToDecimal(plaetze.Where(x => !x.belegt).Count());
            belegte_park_NUD.Value = Convert.ToDecimal(plaetze.Where(x => x.belegt).Count());
        }


        private void Fillplaetze()
        {
            for (int i = 0; i < plaetze.Length; i++)
            {
                plaetze[i] = new Parkplatz(i);
            }
        }

        private void bezahlen_btn_Click(object sender, EventArgs e)
        {
            if (ticket_nr_NUD.Value == -1)
            {
                MessageBox.Show("Bitte eine richtige ticket nummer eingeben");
                return;
            }
            if (!plaetze[Convert.ToInt32(ticket_nr_NUD.Value)].belegt)
            {
                MessageBox.Show("Sie haben die falsche ticket nummer eingegeben");
                return;
            }
            if (new TimeSpan(Convert.ToInt32(uhrzeit_cmb.SelectedItem.ToString().Split(':')[0]), Convert.ToInt32(uhrzeit_cmb.SelectedItem.ToString().Split(':')[1]), 0) < plaetze[Convert.ToInt32(ticket_nr_NUD.Value)].beleget_seit || new TimeSpan(Convert.ToInt32(uhrzeit_cmb.SelectedItem.ToString().Split(':')[0]), Convert.ToInt32(uhrzeit_cmb.SelectedItem.ToString().Split(':')[1]), 0) == plaetze[Convert.ToInt32(ticket_nr_NUD.Value)].beleget_seit)
            {
                MessageBox.Show("Error, selected time is earlier or the same then the booking time");
                return;
            }

            TimeSpan ts = new TimeSpan(Convert.ToInt32(uhrzeit_cmb.SelectedItem.ToString().Split(':')[0]), Convert.ToInt32(uhrzeit_cmb.SelectedItem.ToString().Split(':')[1]), 0) - plaetze[Convert.ToInt32(ticket_nr_NUD.Value)].beleget_seit;
            int mins = Convert.ToInt32(ts.TotalMinutes) / 30;
            amount_to_pay_lbl.Text = (mins*2).ToString()+"€";
            plaetze[Convert.ToInt32(ticket_nr_NUD.Value)].belegt = false;
            setNUP_frei_und_belegt();
            Dictionary<string,dynamic> dict = new Dictionary<string, dynamic> 
            {
                {"@PD",ts },
                {"@preis",mins*2}
            };
            Databank.executenonquery("Insert into Auto(Parkdauer,Preis) Values(@PD,@preis);",dict);

            bezahlen_btn.Enabled = false;
        }

        private void ticket_ziehen_btn_Click(object sender, EventArgs e)
        {
            Parkplatz ticket = plaetze.FirstOrDefault(x => x.belegt == false);

            ticket.belegt = true;


            ticket.beleget_seit = new TimeSpan(Convert.ToInt32(uhrzeit_cmb.SelectedItem.ToString().Split(':')[0]), Convert.ToInt32(uhrzeit_cmb.SelectedItem.ToString().Split(':')[1]), 0);

            ticket_nr_lbl.Text = ticket.Nr.ToString();
            setNUP_frei_und_belegt();
            timer1.Start();
            ticket_ziehen_btn.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticket_nr_lbl.Text = "";
            amount_to_pay_lbl.Text = "";
            bezahlen_btn.Enabled = true;
            ticket_ziehen_btn.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            statistik s = new statistik(Databank);
            s.Show();
        }
    }
}
