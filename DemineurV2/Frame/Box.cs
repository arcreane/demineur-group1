using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemineurV2
{  
    public class Box
    {
        public Bomb MyBomb { get; set; } = null;
        public bool IsVisible { get; set; }
        public bool IsFlagged { get; set; }
        public int NbAdjacentBomb { get; set; }
        string Box_Type = "Error";
        public string Sprite { get => NbAdjacentBomb > 0 ? $"[{NbAdjacentBomb}]" : "[ ]"; }
        string Sprite_Show = "E";
        public string Show
        {
            get
            {
                if (this.IsVisible == true || !IsFlagged )
                {
                    return MyBomb != null ? MyBomb.Sprite : this.Sprite;
                }
                else if(IsFlagged)
                {
                    return "[!]";
                }
                else
                {
                    return "[#]";
                }
            }
            /*set
            {
                Console.WriteLine("Erreur tu ne peux pas changer cette valeur");
            }*/
        }


        public Box(/*string m_Box_Type,int Number = 0*/)//" Box Boite = new Box("Flag");
        {
            /*this.Box_Type = m_Box_Type;
            switch (m_Box_Type)
            {
                
                case "Flag":
                    this.Sprite = "[!]";
                    
                    break;
                case "Bomb":
                    MyBomb = new Bomb();
                    break;
                case "Number":
                    this.Sprite = $"[{Number}]";
                    break;
                case "Empty":
                    this.Sprite = "[ ]";
                    break;
                default:
                    Console.WriteLine("Erreur Box");
                    break;
            }*/
            this.Sprite_Show = this.Sprite;
        }
        public void Flagged()
        {/*
            
            if (this.Sprite_Show != "[!]" && this.Visible == false && Flag.Flags_available > 0)
            {
                this.Sprite_Show = "[!]";
                Flag.Flags_available -= 1;
                if (this.Sprite == "O")
                {
                    Bomb.BombFound += 1;
                }
            }
            else if (Flag.Flags_available < Flag.Flags_available_max && this.Visible == false && this.Sprite_Show == "[!]")
            {
                Flag.Flags_available += 1;
                this.Sprite_Show = this.Sprite;
                if (this.Sprite == "O")
                {
                    Bomb.BombFound -= 1;
                }
            }*/
        }
        public void Digged()
        {
            if(IsVisible == false && this.Sprite_Show != "[!]")
            {
                this.IsVisible = true;
                if (MyBomb != null)
                {
                    MyBomb.Triggered();
                }
            }
        }
    }
}
