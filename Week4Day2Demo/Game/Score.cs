using System;

namespace Week4Day2Demo.Game
{
    internal class Score
    {
        private const int MaxLives = 3;

        public int Points { get; set; }
        public int Lives { get; set; }

        public bool PlayerStillAlive => Lives > 0;

        public Score()
        {
            Points = 0;
            Lives = MaxLives;
        }

        public static Score operator ++(Score score)
        {
            score.Points++;
            return score;
        }

        public static Score operator --(Score score)
        {
            score.Lives--;
            return score;
        }

        public void Show()
        {
            var scoreText = $"Score:{Points:000} | Lives:{Lives}";

            Console.SetCursorPosition(0, 0);
            Console.Write(scoreText);
        }
    }
}
