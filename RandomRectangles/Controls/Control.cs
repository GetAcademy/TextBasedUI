namespace RandomRectangles.Controls
{
    public abstract class Control
    {
        public int X { get; protected set; }
        public int Y { get; protected set; }
        public int Width { get; protected set; }
        public int Height { get; protected set; }
        public int TopRowY => Y;
        public int BottomRowY => Y + Height;

        protected Control() : this(1, 1, 10, 2)
        {
        }

        protected Control(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public abstract void AddToVirtualScreen(VirtualScreen screen, int dx = 0, int dy = 0);
    }
}
