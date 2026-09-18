using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoszerviz.Models
{
    public class Szemelyauto:Jarmu
    {

        public int ajtokszama;

      
        public override void szervizvizsga()
        {
            Console.WriteLine($"Szerviz elvégezve az autón! Ajtók száma: {ajtokszama}");
        }
    }
}
