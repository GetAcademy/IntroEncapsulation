namespace IntroEncapsulation
{
    class TrafficLightConsole
    {
        public static void Write(bool isRedOn, bool isYellowOn, bool isGreenOn)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("┏━┓");
            DrawLine(isRedOn ? ConsoleColor.Red : ConsoleColor.DarkGray);
            DrawLine(isYellowOn ? ConsoleColor.Yellow : ConsoleColor.DarkGray);
            DrawLine(isGreenOn ? ConsoleColor.Green : ConsoleColor.DarkGray);
            Console.WriteLine("┗━┛");
        }

        private static void DrawLine(ConsoleColor color)
        {
            var foregroundColor = Console.ForegroundColor;
            Console.Write("┃");
            Console.ForegroundColor = color;
            Console.Write("●");
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine("┃");
        }
    }
}
