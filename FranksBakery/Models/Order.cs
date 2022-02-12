using System.Collections.Generic;
using System;
using Bread;
using Pastry;

namespace Order
{
  public class OrderStuff
  {
    public double orderCost {get; set;}


    public OrderStuff(double pastryCost, double breadCost)
    {
      orderCost = pastryCost + breadCost;
    }
  }
}