using System;
using RandomRectangles.Controls;

namespace RandomRectangles
{
    public class Program
    {
        private static int _width = 40;
        private static int _height = 20;

        static void Main(string[] args)
        {
            var window = new Window(1,1, 30, 10);
            var label = new Label(1, 2, 10, "Hei!");
            window.Add(label);           
            var screen = new VirtualScreen(_width, _height, window);
            screen.Show();
        }
    }
}
