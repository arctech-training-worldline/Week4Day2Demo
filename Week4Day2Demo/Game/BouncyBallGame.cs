using System;

namespace Week4Day2Demo.Game
{
    internal class BouncyBallGame
    {
        private Ball _ball;
        private Bar _bar;
        private Score _score;

        public void Start()
        {
            BannerHelper.ShowStartGameBanner();

            _ball = new Ball(10, 5);
            _ball.BottomHit += _ball_BottomHit;
            _ball.Show();

            _bar = new Bar();
            _bar.Show();

            _score = new Score();
            _score.Show();

            bool escapeHasBeenPressed;
            do
            {
                _ball.Move();
                _score.Show();

                escapeHasBeenPressed = CheckIfKeyPressed();
            } while (!escapeHasBeenPressed && _score.PlayerStillAlive);

            BannerHelper.ShowEndGameBanner();
        }

        private void _ball_BottomHit(object sender, EventArgs e)
        {
            if (_bar.DoesItIntersect(_ball.Point))
                _score++;   // Increase the points
            else
                _score--;   // Decrease the lives
        }

        private bool CheckIfKeyPressed()
        {
            if (!Console.KeyAvailable) return false;

            var keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    _bar.MoveLeft();
                    break;
                case ConsoleKey.RightArrow:
                    _bar.MoveRight();
                    break;
                case ConsoleKey.Escape:
                    return true;
            }

            return false;
        }
    }
}
