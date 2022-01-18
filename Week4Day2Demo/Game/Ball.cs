using System;
using System.Threading;

namespace Week4Day2Demo.Game
{
    internal class Ball
    {
        public event EventHandler BottomHit;

        private static int _xFactor = 3;
        private static int _yFactor = 1;

        private const int SpeedBrake = 50;

        public readonly Point Point;

        public Ball(int x, int y)
        {
            Point = new Point(x, y);
        }

        public void Show()
        {
            Console.SetCursorPosition(Point.X, Point.Y);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write('@');
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void Hide()
        {
            Console.SetCursorPosition(Point.X, Point.Y);
            Console.Write(' ');
        }

        public void Move()
        {
            Hide();

            var newX = Point.X + _xFactor;
            var newY = Point.Y + _yFactor;

            if (newX < 0)
                _xFactor = -_xFactor;

            if (newX >= Console.WindowWidth)
                _xFactor = -_xFactor;

            if (newY < 0)
                _yFactor = -_yFactor;

            if (newY >= Console.WindowHeight)
            {
                _yFactor = -_yFactor;

                if(BottomHit != null)
                    BottomHit.Invoke(this, EventArgs.Empty);
            }

            Point.X += _xFactor;
            Point.Y += _yFactor;

            Show();
            Thread.Sleep(SpeedBrake);
        }
    }
}
