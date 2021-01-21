using Demineur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemineurV2
{
    class Jeu
    {
        const int hauteurmax = 10;
        const int largeurmax = 10;
        static void Main(string[] args)
        {
            Lancement_Du_Jeu();
        }
        static void Lancement_Du_Jeu()
        {
            Tab Tableau = new Tab();
            Tableau.CreeTableau(hauteurmax, largeurmax);    
        }
    }
}
