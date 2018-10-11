using System;
using RandomRectangles.Controls;

namespace RandomRectangles
{
    public class VirtualScreen
    {
        private readonly VirtualScreenRow[] _rows;

        public VirtualScreen(int width, int height, params Window[] windows)
        {
            _rows = new VirtualScreenRow[height];
            for (var i = 0; i < height; i++)
            {
                _rows[i] = new VirtualScreenRow(width);
            }
            foreach (var window in windows)
            {
                window.AddToVirtualScreen(this);
            }
        }

        public VirtualScreenRow GetRow(int index)
        {
            return _rows[index];
        }

        public void Show()
        {
            Console.Clear();
            foreach (var row in _rows)
            {
                row.Show();
            }
        }
    }
}
