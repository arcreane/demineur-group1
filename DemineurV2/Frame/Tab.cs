using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demineur
{
    public abstract class Tab : Box
    {
        static Random rand = new Random();

        protected string m_Map;
        protected int m_xPosition;
        protected int m_yPosition;

        internal void CreeTableau(object hauteurmax, object largeur)
        {
         
            object hauteurmax.m_Map = [];
            object largeur.m_Map = [];
            object hauteurmax.m_xPosition = 50;
            object largeur.m_yPosition = 50;

            //create the tab 

        public void Grille (object self) 
        {
           for ( i in range(self.m_Map)) 
           {
                self.m_Map.Append([0]*self.m_Map);

                // Appel de la fonction placer bombe
                self.m_Map = self.putBomb();
                self.m_Map = self.putBomb();
           }
        }

        public void PutBomb (self) 
        {
            self.nbBomb += 1;

            self.hauteurmax, self.largeur, self.Bomb = Random.randrange(0,self.hauteurmax), Random.randrage(0, self.hauteurmax), 9;
        }
            
                
            
            
            

                

            //Si case vide = > tab.valeur = nbBombAdjacent (tab)

            //fonction nbBombAdjacent(tab) // renvoie un entier
        }

        
    }
}
