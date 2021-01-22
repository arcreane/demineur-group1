using System;
using System.Timers;

namespace DemineurV2
{
    public class MineSweeper
    {
        static Field deadlyGround;
        static Timer gameTimer;

        static void Main(string[] args)
        {
            deadlyGround = Field.getInstance();
            deadlyGround.init();
            deadlyGround.Draw();

            gameTimer = new Timer();
            gameTimer.Elapsed += MineSweeperLoop;
            gameTimer.Start();
        }

        private static void MineSweeperLoop(object sender, ElapsedEventArgs e)
        {
            //If Box selected is a Bomb
            //GameOver();
        }

        private static void GameOver()
        {
            gameTimer.Stop();
            Console.WriteLine("Vous avez Perdu !");
        }
    }
}
