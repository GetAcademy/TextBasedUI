using System.Collections.Generic;

namespace RandomRectangles.Controls
{
    public abstract class Container : Control
    {
        private List<Control> _controls;

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
    }
}
