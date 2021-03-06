using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace ModelTests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void AddItems_AddThreeToQuantity_3()
    {
      Bread newBread = new Bread();
      newBread.AddItems(3);
      Assert.AreEqual(3, newBread.Quantity);
    }
    [TestMethod]
    public void CalculateOrder_CalculateTotalCostOf3Breads_15()
    {
      Bread newBread = new Bread();
      newBread.AddItems(3);
      newBread.CalculateOrder();
      Assert.AreEqual(15, newBread.TotalCost);
    }
  }
}