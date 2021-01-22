using Demineur;
using System;
namespace Démineur
{
    public class FieldBoxes
    {
        public Coords MyCoords { get; set; }

        public FieldBoxes()
        {
        }

        internal virtual void Draw(String[][] p_DrawString)
        {

        }

        public static implicit operator FieldBoxes(Box v)
        {
            throw new NotImplementedException();
        }
    }
}
