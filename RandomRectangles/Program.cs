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
            window.Add(new Label(1, 2, 10, "Hei!"));           
            window.Add(new Label(1, 3, 10, "Hei!"));           
            window.Add(new Label(1, 4, 10, "Hei!"));           
            window.Add(new Label(1, 5, 10, "Hei!"));
            var window2 = new Window(5, 5, 30, 10);
            window2.Add(new Label(1, 2, 10, "Hallo!"));
            window2.Add(new Label(1, 3, 10, "Hallo!"));
            window2.Add(new Label(1, 4, 10, "Hallo!"));
            window2.Add(new Label(1, 5, 10, "Hallo!"));

            var screen = new VirtualScreen(_width, _height, window, window2);
            screen.Show();
        }
    }
}
