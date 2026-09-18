using Autoszerviz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Autoszerviz
{
    public class Program
    {
        static List<Jarmu> jarmuvek= new List<Jarmu>();
        static void Main(string[] args)
        {
            jarmuvek.Add(new Motor() { allapot = "javításra vár", gyartasiev = 2024, rendszam = "asd-123" });
            jarmuvek.Add(new Teherauto() { allapot = "javításra vár", gyartasiev = 2022, rendszam = "asd-121", teherbiras = 24 });
            jarmuvek.Add(new Szemelyauto() { allapot = "javításra vár", gyartasiev = 2022, rendszam = "asd-121", ajtokszama = 5 });


            foreach (Jarmu item in jarmuvek)
            {
                item.szervizvizsga();
                Console.ReadLine();
            }
        }
    }
}
