using System;

namespace Week4Day2Demo.Game
{
    internal static class BannerHelper
    {
        public static void ShowStartGameBanner()
        {
            var bannerText = new string[]
            {
                @" __      __       .__                                  __          ",
                @"/  \    /  \ ____ |  |   ____  ____   _____   ____   _/  |_  ____  ",
                @"\   \/\/   // __ \|  | _/ ___\/  _ \ /     \_/ __ \  \   __\/  _ \ ",
                @" \        /\  ___/|  |_\  \__(  <_> )  Y Y  \  ___/   |  | (  <_> )",
                @"  \__/\  /  \___  >____/\___  >____/|__|_|  /\___  >  |__|  \____/ ",
                @"       \/       \/          \/            \/     \/                ",
                @"  __  .__               ________                       ",
                @"_/  |_|  |__   ____    /  _____/_____    _____   ____  ",
                @"\   __\  |  \_/ __ \  /   \  ___\__  \  /     \_/ __ \ ",
                @" |  | |   Y  \  ___/  \    \_\  \/ __ \|  Y Y  \  ___/ ",
                @" |__| |___|  /\___  >  \______  (____  /__|_|  /\___  >",
                @"           \/     \/          \/     \/      \/     \/ "
            };

            DrawBanner(bannerText);
        }

        public static void ShowEndGameBanner()
        {
            var endGameBannerText = new string[]
            {
                @"  ________                        .__                   ",
                @" /  _____/_____    _____   ____   |  |__ _____    ______",
                @"/   \  ___\__  \  /     \_/ __ \  |  |  \\__  \  /  ___/",
                @"\    \_\  \/ __ \|  Y Y  \  ___/  |   Y  \/ __ \_\___ \ ",
                @" \______  (____  /__|_|  /\___  > |___|  (____  /____  >",
                @"        \/     \/      \/     \/       \/     \/     \/ ",
                @"                   .___         .___",
                @"  ____   ____    __| _/____   __| _/",
                @"_/ __ \ /    \  / __ |/ __ \ / __ | ",
                @"\  ___/|   |  \/ /_/ \  ___// /_/ | ",
                @" \___  >___|  /\____ |\___  >____ | ",
                @"     \/     \/      \/    \/     \/ "
            };

            DrawBanner(endGameBannerText);
        }

        private static void DrawBanner(string[] bannerText)
        {
            Console.Clear();

            var point = new Point(0, (Console.WindowHeight - bannerText.Length) / 2);

            Console.ForegroundColor = ConsoleColor.Cyan;

            foreach (var text in bannerText)
            {
                point.X = (Console.WindowWidth - text.Length) / 2;
                Console.SetCursorPosition(point.X, point.Y);
                Console.Write(text);
                point.Y++;
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
            Console.Clear();
        }
    }
}
