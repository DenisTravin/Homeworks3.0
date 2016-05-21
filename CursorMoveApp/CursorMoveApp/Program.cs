namespace CursorMoveApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventLoop = new EventLoop();
            var cursorManager = new CursorMoves();
            eventLoop.RightHandler += cursorManager.OnRight;
            eventLoop.LeftHandler += cursorManager.OnLeft;
            eventLoop.UpHandler += cursorManager.OnUp;
            eventLoop.DownHandler += cursorManager.OnDown;
            eventLoop.Run();
        }
    }
}
