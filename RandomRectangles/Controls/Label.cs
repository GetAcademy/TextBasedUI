namespace RandomRectangles.Controls
{
    public class Label : TextControl
    {
        public Label(int x, int y, int width, string text)
        {
            X = x;
            Y = y;
            Width = width;
            Content = text;
        }

        public override void AddToVirtualScreen(VirtualScreen screen, int dx = 0, int dy = 0)
        {
            for (int i = 0; i < Content.Length; i++)
            {
                screen.GetRow(Y + dy).GetCell(X + dx + i).Character = Content[i];
            }
        }
    }
}
