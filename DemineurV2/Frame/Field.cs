using System;
namespace Démineur
{
    public class Field
    {
        private const int NB_BOXES = 100;
        private const int NB_BOMBS = 40;

        private FieldBoxes[] m_FieldArray;
        //0,0, is defined as being upper left corner

        private int m_iWidth;
        private int m_iHeight;

        static Field s_FieldInstance;
        String[][] m_DrawString;
       
        public static Field getInstance()
        {
            if (s_FieldInstance == null)
                s_FieldInstance = new Field();

            return s_FieldInstance;
        }

        internal void Draw()
        {
            foreach (var elemt in m_FieldArray)
            {
                elemt.Draw(m_DrawString);
            }
            System.Text.StringBuilder toDisplay = new System.Text.StringBuilder("");
            for (int i = 0; i < m_iHeight; i++)
            {

                var line = m_DrawString[i];
                var linejoined = String.Join("", line);
                toDisplay.Append(linejoined).Append("\n");

            }
            Console.WriteLine(toDisplay.ToString());
        }

        private Field()
        {

        }

        public void init(int p_iWidth = 10, int p_iHeight = 10)
        {
            m_iWidth = p_iWidth;
            m_iHeight = p_iHeight;

            if (m_FieldArray ==  null)
            {
                m_FieldArray = new FieldBoxes[NB_BOXES];

                for (int i = 0; i < NB_BOXES - 1; i++)
                {
                    m_FieldArray[i] = new Box();
                }

                m_DrawString = new string[m_iHeight][];
                for (int i = 0; i < m_iHeight; i++)
                {
                    m_DrawString[i] = new string[m_iWidth];
                    for (int j = 0; j < m_iWidth; j++)
                    {
                        m_DrawString[i][j] = ".";
                    }
                }
            }
        }

        public int getWidth()
        {
            return m_iWidth;
        }

        public int getHeight()
        {
            return m_iHeight;
        }
    }
}
