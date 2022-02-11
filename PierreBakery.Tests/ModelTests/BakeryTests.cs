using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakerySpace.Models;
using System.Collections.Generic;

namespace BakerySpace.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BakeryConstructor_CreateBakeryConstructor_Bakery()
    {
      Bakery newBakery = new Bakery(1);
      Assert.AreEqual(typeof(Bakery), newBakery.GetType());
    }
  }
}