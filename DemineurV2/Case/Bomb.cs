using Demineur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demineur
{
    public class Bomb 
    {
        public static int BombFound { get; internal set; }

        internal static void Triggered()
        {
            throw new NotImplementedException();
        }

        // Si case = mine => bomb

        // Si nb mines autour = nb bomb posées par le joueur = > faire case "x" et ouvrir_case(x)
    }
}
