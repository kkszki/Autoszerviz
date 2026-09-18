using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoszerviz.Models
{
    public class Teherauto:Jarmu
    {
        public int teherbiras;

        

        public override void szervizvizsga()
        {
            Console.WriteLine($"fékpad és tengelyterhelés mérése! teherbiras: {teherbiras}" );
        }
    }
}
