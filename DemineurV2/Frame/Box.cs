using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demineur
{  
    class Box
    {
        public bool Visible = false;
        string Box_Type = "Error";
        string Sprite = "E";
        string Sprite_Show = "E";
        public string Show
        {
            get
            {
                if (this.Visible == true || this.Sprite == "[!]")
                {
                    return this.Sprite;
                }
                else
                {
                    return "[#]";
                }
            }
            set
            {
                Console.WriteLine("Erreur tu ne peux pas changer cette valeur");
            }
        }


        public Box(string m_Box_Type,int Number = 0)//" Box Boite = new Box("Flag");
        {
            this.Box_Type = m_Box_Type;
            switch (m_Box_Type)
            {
                
                case "Flag":
                    this.Sprite = "[!]";
                    
                    break;
                case "Bomb":
                    this.Sprite = "[O]";
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
            }
            this.Sprite_Show = this.Sprite;
        }
        public void Flagged()
        {
            
            if (this.Sprite != "[!]" && this.Visible == false && Flag.Flags_available > 0)
            {
                this.Sprite_Show = "[!]";
                Flag.Flags_available -= 1;
            }
            else if (Flag.Flags_available < Flag.Flags_available_max && this.Visible == false && this.Sprite == "[!]")
            {
                Flag.Flags_available += 1;
                this.Sprite_Show = this.Sprite;
            }
        }
        public void Digged()
        {
            if(Visible == false && this.Sprite != "[!]")
            {
                this.Visible = true;
                if (this.Sprite == "[0]")
                {
                    Bomb.Triggered();
                }
            }
        }
    }
}
