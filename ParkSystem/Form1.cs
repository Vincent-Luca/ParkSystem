using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkSystem.Klassen;

namespace ParkSystem
{
    public partial class Form1 : Form
    {

        private Parkplatz[] plaetze = new Parkplatz[100];

        public Form1()
        {
            InitializeComponent();
            Fillplaetze();
        }


        private void Fillplaetze()
        {
            for (int i = 0; i < plaetze.Length; i++)
            {
                plaetze[i] = new Parkplatz();
            }
        }

        private void bezahlen_btn_Click(object sender, EventArgs e)
        {

        }

        private void ticket_ziehen_btn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            ticket_ziehen_btn.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
