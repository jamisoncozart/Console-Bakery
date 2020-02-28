using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace ModelTests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void AddBread_AddThreeToQuantity_Three()
    {
      Bread newBread = new Bread();
      newBread.AddBread(3);
      Assert.AreEqual(3, newBread.Quantity);
    }
  }
}