using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreadSpace.Models;
using System.Collections.Generic;

namespace BreadSpace.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreateBreadConstructor_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadSingleCost_CalcBreadCost_Bread()
    {
      Bread newBread = new Bread(1);
      int result = newBread.Cost();
      Assert.AreEqual(5,result);
    }

    [TestMethod]
    public void BreadTwoCost_CalcBreadTwoCost_Bread()
    {
      Bread newBread = new Bread(2);
      int result = newBread.Cost();
      Assert.AreEqual(10,result);
    }

    [TestMethod]
    public void BreadThreeCost_CalcBreadThreeCost_Bread()
    {
      Bread newBread = new Bread(3);
      int result = newBread.Cost();
      Assert.AreEqual(10,result);
    }
  }
}