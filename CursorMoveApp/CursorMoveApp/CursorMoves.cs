using System;

namespace CursorMoveApp
{
    /// <summary>
    /// class for making cursor moves
    /// </summary>
    public class CursorMoves
    {
        /// <summary>
        /// cursor left move
        /// </summary>
        public void OnLeft(object sender, EventArgs args)
        {
            if (Console.CursorLeft > 0)
            {
                Console.CursorLeft -= 1;
            }
        }

        /// <summary>
        /// cursor right move
        /// </summary>
        public void OnRight(object sender, EventArgs args)
        {
            if (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.CursorLeft += 1;
            }
        }

        /// <summary>
        /// cursor up move
        /// </summary>
        public void OnUp(object sender, EventArgs args)
        {
            if (Console.CursorTop > 0)
            {
                Console.CursorTop -= 1;
            }
        }

        /// <summary>
        /// cursor down move
        /// </summary>
        public void OnDown(object sender, EventArgs args)
        {
            if (Console.CursorTop < Console.WindowHeight - 1)
            {
                Console.CursorTop += 1;
            }
        }
    }
}
