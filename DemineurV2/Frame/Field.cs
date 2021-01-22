using System;
namespace DemineurV2
{
    public class Field
    {
        private const int NB_BOXES = 100;
        private const int NB_BOMBS = 40;

        private Box[][] m_FieldArray;
        //0,0, is defined as being upper left corner

        private int m_iWidth;
        private int m_iHeight;

        static Field s_FieldInstance;
       
        public static Field getInstance()
        {
            if (s_FieldInstance == null)
                s_FieldInstance = new Field();

            return s_FieldInstance;
        }

        internal void Draw()
        {
            System.Text.StringBuilder toDisplay = new System.Text.StringBuilder("");

            foreach (var line in m_FieldArray)
            {
                foreach (var element in line)
                {
                    toDisplay.Append(element.Show); ;
                }
                toDisplay.Append("\n");
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
                m_FieldArray = new Box[m_iWidth][];

                for (int i = 0; i < m_iWidth; i++)
                {
                    m_FieldArray[i] = new Box[m_iHeight];
                    for (int j = 0; j < m_FieldArray[i].Length; j++)
                    {
                        m_FieldArray[i][j] = new Box();
                        //MaListe.Add(Tuple(i,j)
                        //for (i, nb bombes)
                        //V->reccup.size(maliste)
                        //reccup(maliste)
                        //remove dans ma liste les coords à l'index v -> liste perds un élément
                        //calcul des valeurs des cases adjacentes
                        m_FieldArray[i][j].MyBomb = new Bomb();
                    }
                }

                /*m_DrawString = new string[m_iHeight][];
                for (int i = 0; i < m_iHeight; i++)
                {
                    m_DrawString[i] = new string[m_iWidth];
                    for (int j = 0; j < m_iWidth; j++)
                    {
                        m_DrawString[i][j] = ".";
                    }
                }*/
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
