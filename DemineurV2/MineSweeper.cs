﻿using System;
using System.Timers;

namespace Démineur
{
    public class MineSweeper
    {
        static Field deadlyGround;
        static Timer gameTimer;

        static void Main(string[] args)
        {
            deadlyGround = Field.getInstance();
            deadlyGround.init();

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
