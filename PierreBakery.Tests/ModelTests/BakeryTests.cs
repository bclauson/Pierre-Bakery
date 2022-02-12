using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreadSpace.Models;
using PastrySpace.Models;
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

    [TestMethod]
    public void BreadRandomCost_CalcBreadRandomCost_Bread()
    {
      Bread newBread = new Bread(7);
      int result = newBread.Cost();
      Assert.AreEqual(25,result);
    }
  }
}

namespace PastrySpace.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatePastryConstructor_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void PastrySingleCost_CalcPastryCost_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      int result = newPastry.Cost();
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void PastryDoubleCost_CalcPastryCost_Pastry()
    {
      Pastry newPastry = new Pastry(2);
      int result = newPastry.Cost();
      Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void Pastry3Cost_CalcPastryCost_Pastry()
    {
      Pastry newPastry = new Pastry(3);
      int result = newPastry.Cost();
      Assert.AreEqual(5, result);
    }
  }
}