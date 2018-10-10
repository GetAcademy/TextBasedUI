using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomRectangles
{
    public class VirtualScreenBorderCell : VirtualScreenCell
    {
        public bool Up { get; private set; }
        public bool Down { get; private set; }
        public bool Left { get; private set; }
        public bool Right { get; private set; }

        public override char Character
        {
            get => GetCharacter();
            set => throw new InvalidOperationException();
        }

        public void AddHorizontal()
        {
            Left = Right = true;
        }

        public void AddVertical()
        {
            Up = Down = true;
        }

        public void AddLowerLeftCorner()
        {
            Up = Right = true;
        }

        public void AddUpperLeftCorner()
        {
            Down = Right = true;
        }

        public void AddUpperRightCorner()
        {
            Down = Left = true;
        }

        public void AddLowerRightCorner()
        {
            Up = Left = true;
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
