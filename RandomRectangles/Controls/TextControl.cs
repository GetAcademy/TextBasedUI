namespace RandomRectangles.Controls
{
    public abstract class TextControl : Control
    {
        public string Content { get; set; }

        protected TextControl()
        {
            Height = 1;
        }
    }
}
