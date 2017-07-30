using System;

namespace MineSweeper
{
    public class CellPosition
    {
        public int Row { get; set; }
        public int Col {get;set;}
        public Cell Cell { get; set; }
        public CellPosition(Cell cell, int row, int col)
        {
            Row = row;
            Col = col;
            Cell = cell;
        }

    }
}