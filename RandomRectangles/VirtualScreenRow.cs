using System;

namespace RandomRectangles
{
    public class VirtualScreenRow
    {
        private VirtualScreenCell[] _cells;
        private int _screenWidth;

        public VirtualScreenRow(int screenWidth)
        {
            _cells = new VirtualScreenCell[screenWidth];
            for (int i = 0; i < _cells.Length; i++)
            {
                _cells[i] = new VirtualScreenCell();
            }
        }

        public void AddBoxTopRow(int boxX, int boxWidth)
        {
            _cells[boxX].AddUpperLeftCorner();
            for (int i = boxX + 1; i < boxX + boxWidth - 1; i++)
            {
                _cells[i].AddHorizontal();
            }
            _cells[boxX + boxWidth - 1].AddUpperRightCorner();
        }

        public void AddBoxBottomRow(int boxX, int boxWidth)
        {
            _cells[boxX].AddLowerLeftCorner();
            for (int i = boxX + 1; i < boxX + boxWidth - 1; i++)
            {
                _cells[i].AddHorizontal();
            }
            _cells[boxX + boxWidth - 1].AddLowerRightCorner();
        }

        public void AddBoxMiddleRow(int boxX, int boxWidth)
        {
            _cells[boxX].AddVertical();
            _cells[boxX + boxWidth - 1].AddVertical();

        }

        public void Show()
        {
            foreach (var cell in _cells)
            {
                Console.Write(cell.GetCharacter());
            }
            Console.WriteLine();
        }
    }
}
