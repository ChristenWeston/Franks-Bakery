using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bread;
using Pastry;
using System;

namespace FranksBakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void FranksBakery_BreadStuffCreatesNewBreadStuff()
    {
      BreadStuff newBread = new BreadStuff("2");
      Assert.AreEqual(typeof(BreadStuff), newBread.GetType());
    }

    [TestMethod]
    public void FranksBakery_BreadPriceReturnsCorrectPriceFor5Loaves()
    {
      BreadStuff new5LoafBread = new BreadStuff("5");
      double result = 20.00;
      Assert.AreEqual(new5LoafBread.breadCost, result);
    }

    [TestMethod]
    public void FranksBakery_BreadPriceReturnsCorrectPriceFor2Loaves()
    {
      BreadStuff new5LoafBread = new BreadStuff("2");
      double result = 10.00;
      Assert.AreEqual(new5LoafBread.breadCost, result);
    }
  }

  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void FranksBakery_PastryStuffCreatesNewPastryStuff()
    {
      PastryStuff newPastry = new PastryStuff("1");
      Assert.AreEqual(typeof(PastryStuff), newPastry.GetType());
    }
  }
}