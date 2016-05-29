using System;

namespace CursorMoveApp
{
    public class EventLoop
    {
        /// <summary>
        /// left arrow key handler
        /// </summary>
        public event EventHandler<EventArgs> LeftHandler = (sender, args) => { };

        /// <summary>
        /// right arrow key handler
        /// </summary>
        public event EventHandler<EventArgs> RightHandler = (sender, args) => { };

        /// <summary>
        /// up arrow key handler
        /// </summary>
        public event EventHandler<EventArgs> UpHandler = (sender, args) => { };

        /// <summary>
        /// down arrow key handler
        /// </summary>
        public event EventHandler<EventArgs> DownHandler = (sender, args) => { };

        /// <summary>
        /// event loop method
        /// </summary>
        public void Run()
        {
            while (true)
            {
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        LeftHandler(this, EventArgs.Empty);
                        break;
                    case ConsoleKey.RightArrow:
                        RightHandler(this, EventArgs.Empty);
                        break;
                    case ConsoleKey.UpArrow:
                        UpHandler(this, EventArgs.Empty);
                        break;
                    case ConsoleKey.DownArrow:
                        DownHandler(this, EventArgs.Empty);
                        break;
                }
            }
        }
    }
}
