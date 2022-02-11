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

    [TestMethod]
    public void FranksBakery_PastryPriceReturnsCorrectPriceFor1Pastry()
    {
      PastryStuff new1Pastry = new PastryStuff("1");
      double pastryCost = 2.00;
      Assert.AreEqual(new1Pastry.pastryCost, pastryCost);
    }

    [TestMethod]
    public void FranksBakery_PastryPriceReturnsCorrectPriceFor3Pastries()
    {
      PastryStuff new3Pastry = new PastryStuff("3");
      double pastriesCost = 5.00;
      Assert.AreEqual(new3Pastry.pastryCost, pastriesCost);
    }

    [TestMethod]
    public void FranksBakery_PastryPriceReturnsCorrectPriceFor4Pastries()
    {
      PastryStuff new4Pastry = new PastryStuff("4");
      double pastriesCost = 7.00;
      Assert.AreEqual(new4Pastry.pastryCost, pastriesCost);
    }

    [TestMethod]
    public void FranksBakery_PastryPriceReturnsCorrectPriceFor5Pastries()
    {
      PastryStuff new5Pastry = new PastryStuff("5");
      double pastriesCost = 9.00;
      Assert.AreEqual(new5Pastry.pastryCost, pastriesCost);
    }

    [TestMethod]
    public void FranksBakery_PastryPriceReturnsCorrectPriceFor6Pastries()
    {
      PastryStuff new6Pastry = new PastryStuff("6");
      double pastriesCost = 10.00;
      Assert.AreEqual(new6Pastry.pastryCost, pastriesCost);
    }
  }
}