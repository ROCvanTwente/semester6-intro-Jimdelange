using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP2
{
    public class Circle : IShapes
    {
        public int Oppervlakte { get; set; }
        public int Straal { get; set; }
        public int Omtrek { get; set; }

        // Constructor voor Circle
        public Circle(int oppervlakte)
        {
            // Oppervlakte wordt ingesteld
            Oppervlakte = oppervlakte;

            // Bereken de straal op basis van de oppervlakte
            Straal = (int)Math.Sqrt(Oppervlakte / Math.PI);

            // Bereken de omtrek op basis van de straal
            Omtrek = (int)(2 * Math.PI * Straal);
        }

        // Methode om de omtrek te berekenen
        public int BerekenOmtrek()
        {
            return Omtrek;
        }

        // Methode om de oppervlakte weer te geven
        public string OppervlakteWeergeven()
        {
            return $"De huidige oppervlakte is {Oppervlakte}";
        }

        // Methode om de grootte te veranderen
        public void VeranderGrootte(int factor)
        {
            // Verandert de straal en herberekent de oppervlakte en omtrek
            Straal *= factor;
            Oppervlakte = (int)(Math.PI * Straal * Straal);
            Omtrek = (int)(2 * Math.PI * Straal);
        }

        // Methode om de cirkel kleiner te maken
        public void VeranderKleiner(int factor)
        {
            // Verandert de straal en herberekent de oppervlakte en omtrek
            Straal /= factor;
            Oppervlakte = (int)(Math.PI * Straal * Straal);
            Omtrek = (int)(2 * Math.PI * Straal);
        }
    }
}
