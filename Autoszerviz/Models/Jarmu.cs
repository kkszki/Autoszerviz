using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoszerviz.Models
{
    public abstract class Jarmu
    {
        public string rendszam;
        public int gyartasiev;
        public string allapot;

        public abstract void szervizvizsga();
    }
}
