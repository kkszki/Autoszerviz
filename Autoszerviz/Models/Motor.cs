using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoszerviz.Models
{
    public class Motor : Jarmu
    {
        public override void szervizvizsga()
        {
            Console.WriteLine("Motor szervizvizsga: láncfeszesség ellenőrzése.");
        }
    }
}
