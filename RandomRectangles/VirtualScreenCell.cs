using System;

namespace RandomRectangles
{
    public class VirtualScreenCell
    {
        private char? _character;
        public bool Up { get; private set; }
        public bool Down { get; private set; }
        public bool Left { get; private set; }
        public bool Right { get; private set; }

        public char Character
        {
            get => _character ?? GetCharacter();
            set
            {
                _character = value;
                Up = Down = Left = Right = false;                
            }
        }

        public void AddHorizontal()
        {
            Left = Right = true;
            _character = null;
        }

        public void AddVertical()
        {
            Up = Down = true;
            _character = null;
        }

        public void AddLowerLeftCorner()
        {
            Up = Right = true;
            _character = null;
        }

        public void AddUpperLeftCorner()
        {
            Down = Right = true;
            _character = null;
        }

        public void AddUpperRightCorner()
        {
            Down = Left = true;
            _character = null;
        }

        public void AddLowerRightCorner()
        {
            Up = Left = true;
            _character = null;
        }

        private char GetCharacter()
        {
            if (!Left && !Up && Right && Down) return '┌';
            if (!Left && Up && Right && !Down) return '└';
            if (Left && !Up && Right && !Down) return '─';
            if (Left && !Up && !Right && Down) return '┐';
            if (Left && Up && !Right && !Down) return '┘';
            if (!Left && Up && !Right && Down) return '│';
            if (Left && Up && Right && Down) return '┼';
            if (Left && Up && !Right && Down) return '┤';
            if (!Left && Up && Right && Down) return '├';
            if (Left && Up && Right && !Down) return '┴';
            if (Left && !Up && Right && Down) return '┬';

            if (Left && !Up && !Right && !Down) return '╴';
            if (!Left && !Up && Right && !Down) return '╶';
            if (!Left && !Up && !Right && Down) return '╷';
            if (!Left && Up && !Right && !Down) return '╵';
            return ' ';
        }
    }

}
