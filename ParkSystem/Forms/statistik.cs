using ParkSystem.Klassen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ParkSystem.Forms
{
    public partial class statistik : Form
    {
        public statistik(DBVerbindung datenbank)
        {
            InitializeComponent();
            DataTable data = datenbank.SQLSelect("Select * from Auto;");

            TimeSpan ts = new TimeSpan(0,0,0);
            int preis = 0;

            for (int i = 0; i < data.Rows.Count; i++)
            {
                ts = ts + TimeSpan.Parse(DateTime.Parse(data.Rows[i][1].ToString()).ToShortTimeString());
                preis += Convert.ToInt32(data.Rows[i][2].ToString());
                
                dgv_daten.Rows.Add(DateTime.Parse(data.Rows[i][1].ToString()).ToShortTimeString().ToString(), data.Rows[i][2].ToString()+"€");
            }

            lbl_Dparkdauer.Text = (Convert.ToInt32(ts.TotalMinutes)/ data.Rows.Count).ToString()+" mins";
            lbl_Dpreis.Text = (preis / data.Rows.Count).ToString()+"€";
        }
    }
}
