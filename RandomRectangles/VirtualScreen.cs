using System;
using RandomRectangles.Controls;

namespace RandomRectangles
{
    public class VirtualScreen
    {
        public VirtualScreenRow[] Rows { get; }

        public VirtualScreen(int width, int height, params Window[] windows)
        {
            Rows = new VirtualScreenRow[height];
            for (var i = 0; i < height; i++)
            {
                Rows[i] = new VirtualScreenRow(width);
            }
            foreach (var window in windows)
            {
                window.AddToVirtualScreen(this);
            }
        }

        public void Show()
        {
            Console.Clear();
            foreach (var row in Rows)
            {
                row.Show();
            }
        }
    }
}
