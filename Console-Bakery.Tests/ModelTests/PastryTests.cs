using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace ModelTests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void AddPastries_AddThreeToQuantity_3()
    {
      Pastry newPastry = new Pastry();
      newPastry.AddPastries(3);
      Assert.AreEqual(3, newPastry.Quantity);
    }
  }
}