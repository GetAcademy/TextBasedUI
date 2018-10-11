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

        public override void AddToVirtualScreen(VirtualScreen screen, int dx = 0, int dy = 0)
        {
            base.AddToVirtualScreen(screen, dx, dy);
            MakeBorder(screen);
        }

        private void MakeBorder(VirtualScreen screen)
        {
            AddTopBorder(X, Width, screen.GetRow(TopRowY));
            for (var y = TopRowY + 1; y < BottomRowY; y++)
            {
                AddMiddleBorder(X, Width, screen.GetRow(y));
            }

            AddBottomBorder(X, Width, screen.GetRow(BottomRowY));
        }

        public void AddTopBorder(int boxX, int boxWidth, VirtualScreenRow row)
        {
            row.GetCell(boxX).AddUpperLeftCorner();
            for (int i = boxX + 1; i < boxX + boxWidth - 1; i++)
            {
                row.GetCell(i).AddHorizontal();
            }
            row.GetCell(boxX + boxWidth - 1).AddUpperRightCorner();
        }

        public void AddBottomBorder(int boxX, int boxWidth, VirtualScreenRow row)
        {
            row.GetCell(boxX).AddLowerLeftCorner();
            for (int i = boxX + 1; i < boxX + boxWidth - 1; i++)
            {
                row.GetCell(i).AddHorizontal();
            }
            row.GetCell(boxX + boxWidth - 1).AddLowerRightCorner();
        }

        public void AddMiddleBorder(int boxX, int boxWidth, VirtualScreenRow row)
        {
            row.GetCell(boxX).AddVertical();
            row.GetCell(boxX + boxWidth - 1).AddVertical();

        }
    }
}
