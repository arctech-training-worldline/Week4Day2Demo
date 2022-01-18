using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Week4Day2Demo.Game;


namespace Week4Day2Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestScore();
            //TestBar();
            //TestBall();

            var game = new BouncyBallGame();
            game.Start();
        }

        private static void TestBall()
        {
            var bouncyBallGame = new BouncyBallGame();
            bouncyBallGame.ShowStartGameBanner();

            var ball = new Ball(10, 5);

            do
            {
                ball.Move();
            } while (true);
        }

        private static void TestBar()
        {
            var bouncyBallGame = new BouncyBallGame();
            bouncyBallGame.ShowStartGameBanner();

            var bar = new Bar();

            bar.Show();

            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        bar.MoveLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        bar.MoveRight();
                        break;
                    case ConsoleKey.S:
                        bar.Show();
                        break;
                    case ConsoleKey.H:
                        bar.Hide();
                        break;
                }

            } while (keyInfo.Key != ConsoleKey.Escape);
        }

        private static void TestScore()
        {
            var score = new Score();

            score.Show();

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();

            score++;

            score--;

            score.Show();

            Console.WriteLine("\nPress any key to continue.");
        }
    }
}

