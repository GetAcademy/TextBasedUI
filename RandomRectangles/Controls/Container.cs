using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RandomRectangles.Controls
{
    public abstract class Container : Control
    {
        private readonly List<Control> _controls;
        protected int _margin = 0;

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
            CleanupCode(screen, dx, dy);
            foreach (var control in _controls)
            {
                control.AddToVirtualScreen(screen, X + dx, Y + dy);
            }
        }

        protected virtual void CleanupCode(VirtualScreen screen, int dx, int dy)
        {
            CleanUpImpl(screen, dx, dy, 0);
        }

         protected virtual void CleanUpImpl(VirtualScreen screen, int dx, int dy, int margin)
        {
            for (var x = X + dx + margin; x < X + dx + Width - margin; x++)
            for (var y = Y + dy + margin; y < Y + dy + Height - margin; y++)
                screen.GetRow(y).GetCell(x).Character = ' ';
        }
    }
}
