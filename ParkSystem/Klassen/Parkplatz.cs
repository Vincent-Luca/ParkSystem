using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ParkSystem.Klassen
{
    
    public class Parkplatz
    {
        public int Nr;
        public bool belegt = false;
        public TimeSpan beleget_seit;
        public Parkplatz(int Nr)
        {
            this.Nr = Nr;
        }
    }
}
