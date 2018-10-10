namespace RandomRectangles.Controls
{
    public class Window : Container
    {
        public Window() : base()
        {
        }

        public Window(int x, int y, int width, int height)
            : base(x, y, width, height)
        {
        }

        public void AddToVirtualScreen(VirtualScreen screen)
        {
            var rows = screen.Rows;
            rows[TopRowY].AddBoxTopRow(X, Width);
            for (var y = TopRowY + 1; y < BottomRowY; y++)
            {
                rows[y].AddBoxMiddleRow(X, Width);
            }
            rows[BottomRowY].AddBoxBottomRow(X, Width);
        }
    }
}
