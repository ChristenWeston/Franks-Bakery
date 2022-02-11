using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bread;
using System;

namespace FranksBakery.Tests
{
  [TestClass]
  public class ItemTests
  {

    [TestMethod]
    public void FranksBakery_BreadStuffCreatesNewBreadStuff()
    {
      BreadStuff newBread = new BreadStuff("2");
      Assert.AreEqual(typeof(BreadStuff), newBread.GetType());
    }
  }
}