

using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    class Color
    {
        private string foregrcolor;

        public void SetForgrcolor(string foregrcolor)
        {
            this.foregrcolor = foregrcolor;
        }

        public void SetConsoleColor()
        {
            string[] names = Enum.GetNames(typeof(ConsoleColor));

            int num = 0;
            foreach (string color in names)
            {
                if (color == foregrcolor)
                {
                    ConsoleColor consCol = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);
                    Console.ForegroundColor = consCol;
                    num++;
                }
            }
            if (num == 0)
            {
                Console.WriteLine("You can not do that...You have the following options: Black, Blue, " +
                "Cyan, Gray, Green, Magenta, Red, White, YellowDarkBlue, DarkCyan, DarkGray, " +
                "DarkGreen, DarkMagenta, DarkRed, DarkYellow");
            }
        }
    }
}