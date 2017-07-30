using Microsoft.VisualStudio.TestTools.UnitTesting;
using MineSweeper;

namespace test
{
    [TestClass]
    public class CellTest
    {
        [TestMethod]
        public void Should_Has_Mine()
        {
            
            var cell = new Cell();
            cell.AddMine();
            Assert.AreEqual(cell.HasMine, true);
        }
[TestMethod]
        public void Should_Be_Revealed()
        {
            
            var cell = new Cell();
            cell.Reveal();
            Assert.AreEqual(cell.IsRevealed, true);
        }
        [TestMethod]
        public void Should_Not_Be_Flagged_If_NotRevealed()
        {
            
            var cell = new Cell();
            cell.Reveal();
            cell.AddFlag();
            Assert.AreEqual(cell.IsFlagged, false);
        }

    }
}
