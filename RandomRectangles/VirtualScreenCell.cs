namespace RandomRectangles
{
    public class VirtualScreenCell
    {
        private char _character;

        public virtual char Character
        {
            get => _character;
            set => _character = value;
        }
    }
}
