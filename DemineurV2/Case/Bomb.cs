using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemineurV2
{
    public class Bomb 
    {
        public static int BombFound { get; internal set; }
        public string Sprite { get => "[#]"; }

        internal void Triggered()
        {
            throw new NotImplementedException();
        }

        // Si case = mine => bomb

        // Si nb mines autour = nb bomb posées par le joueur = > faire case "x" et ouvrir_case(x)
    }
}
