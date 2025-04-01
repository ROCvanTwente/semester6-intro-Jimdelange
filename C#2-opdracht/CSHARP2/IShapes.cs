using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP2
{
    public interface IShapes
    {
        int Oppervlakte { get; }
        int BerekenOmtrek();  // Methode voor het berekenen van de omtrek
        void VeranderGrootte(int factor);  // Verander de grootte van de vorm
        void VeranderKleiner(int factor);  // Maak de vorm kleiner
        string OppervlakteWeergeven();  // Toon de oppervlakte
    }
}
