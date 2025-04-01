using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP2
{
    public class Rectangle : IShapes
    {
        public int Oppervlakte { get; set; }
        public int Lengte { get; set; }
        public int Breedte { get; set; }

        public Rectangle(int lengte, int breedte)
        {
            Lengte = lengte;
            Breedte = breedte;
            Oppervlakte = lengte * breedte;  // Oppervlakte berekenen
        }

        public int BerekenOmtrek()
        {
            return 2 * (Lengte + Breedte);  // Omtrek van een rechthoek
        }

        public string OppervlakteWeergeven()
        {
            return $"De huidige oppervlakte is {Oppervlakte}";
        }

        public void VeranderGrootte(int factor)
        {
            Lengte += factor;
            Breedte += factor;
            Oppervlakte = Lengte * Breedte;  // Oppervlakte opnieuw berekenen
        }

        public void VeranderKleiner(int factor)
        {
            Lengte -= factor;
            Breedte -= factor;
            Oppervlakte = Lengte * Breedte;  // Oppervlakte opnieuw berekenen
        }
    }

}
