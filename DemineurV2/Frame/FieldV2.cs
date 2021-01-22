using System;
namespace DemineurV2
{
    public class FieldV2
    {
        private const int NB_BOXES = 100;
        private const int NB_BOMBS = 40;

        public Coords MyCoords { get; set; }

        static FieldV2 s_FieldInstance;

        private FieldBoxes[] m_FieldArray;

        public static FieldV2 getInstance()
        {
            if (s_FieldInstance == null)
                s_FieldInstance = new FieldV2();

            return s_FieldInstance;
        }

    }
}
