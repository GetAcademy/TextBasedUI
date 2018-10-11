using System.Collections.Generic;

namespace RandomRectangles.Controls
{
    public abstract class Container : Control
    {
        private readonly List<Control> _controls;

        protected Container() 
            : this(1, 1, 40, 2)
        {           
        }

        protected Container(int x, int y, int width, int height)
            : base(x, y, width, height)
        {
            _controls = new List<Control>();
        }

        public void Add(Control control)
        {
            _controls.Add(control);
        }

        public override void AddToVirtualScreen(VirtualScreen screen, int dx = 0, int dy = 0)
        {
            for(var x = X + dx; x < X + dx + Width; x++)
            for (var y = Y + dy; y < Y + dy + Height; y++)
                screen.GetRow(y).GetCell(x).Character = ' ';
            foreach (var control in _controls)
            {
                control.AddToVirtualScreen(screen, X + dx, Y + dy);
            }
        }
    }
}
