using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombinations.Models;

namespace CoinCombinations.Tests
{
  [TestClass]
  public class CoinSorterTests
  {
    [TestMethod]
    public void Sort_SortValuesUnder5_Pennies()
    {
      CoinSorter change = new CoinSorter();
      Assert.AreEqual(4, change);
    }
  }
}