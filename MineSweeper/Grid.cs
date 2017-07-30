using System;
using System.Collections;
using System.Linq;

namespace MineSweeper
{
    public class Grid
    {
        public Grid(int rows, int cols)
        {
            int count = 0;
            CellPositions = new CellPosition[rows * cols];
            for (int row = 0; row < rows; row++)
            {
                 for (int col = 0; col < cols; col++)
                    {
                        CellPositions[count] = new CellPosition(new Cell(), row, col);
                        count++;
                    }
            }
           
        }
        public CellPosition[] CellPositions { get; set; }

        public void Reveal(int rowPosition, int colPosition){
            GetCellAtPosition(rowPosition,colPosition).Reveal();
        }
        public void PlantMine(int rowPosition, int colPosition){
            GetCellAtPosition(rowPosition,colPosition).AddMine();
        }


        public Cell GetCellAtPosition ( int rowPosition, int colPosition){
            return this.CellPositions.ToList().FirstOrDefault(k=> k.Row == rowPosition && k.Col == colPosition).Cell;
        }

    }
}