using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    public static class MainManager
    {
        /// <summary>
        /// This holds all of those random things that the game will need throughout the code.
        /// I did it this way to make it a little easier on me
        /// </summary>

        public static bool showCursor = false;
        public static int screenWidth;
        public static int screenHeight;
        public static float deltaTime;

        public static int score;

        public static int firstScene = 2;
    }
}
