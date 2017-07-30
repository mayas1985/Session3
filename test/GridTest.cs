using Microsoft.VisualStudio.TestTools.UnitTesting;
using MineSweeper;


namespace test
{
    [TestClass]
    public class GridTest
    {
         [TestMethod]
         public void Should_Match_Cell_Count(){
             var grid = new Grid(3,3);
             Assert.AreEqual(grid.CellPositions.Length, 9);
         }

    }
}