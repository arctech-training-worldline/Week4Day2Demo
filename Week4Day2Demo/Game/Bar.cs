using System;
using System.Reflection;
using System.Security.Principal;

namespace Week4Day2Demo.Game
{
    internal class Bar
    {
        private const int Width = 20;
        private const int Height = 1;
        private const int Speed = 5;
        private const ConsoleColor BarColor = ConsoleColor.Cyan;

        private readonly string _barText;
        private readonly Point _point;

        public int Right => _point.X + Width;

        public Bar()
        {
            _point = new Point(Console.WindowWidth / 2 - Width / 2, Console.WindowHeight - Height);
            _barText = new string(' ', Width);
        }

        public void Show()
        {
            Console.SetCursorPosition(_point.X, _point.Y);
            Console.BackgroundColor = BarColor;
            Console.Write(_barText);
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void Hide()
        {
            Console.SetCursorPosition(_point.X, _point.Y);
            Console.Write(_barText);
        }

        public void MoveLeft()
        {
            Hide();

            var newX = _point.X - Speed;
            _point.X = newX < 0 ? 0 : newX;

            Show();
        }

        public void MoveRight()
        {
            Hide();

            var newX = _point.X + Speed;
            _point.X = newX > Console.WindowWidth - Width - 2 ? Console.WindowWidth - Width - 2 : newX;

            Show();
        }

        public bool DoesItIntersect(Point ballPoint)
        {
            return ballPoint.X >= _point.X && ballPoint.X <= Right;
        }
    }
}
