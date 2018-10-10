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
    }
}
