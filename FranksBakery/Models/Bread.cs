using System.Collections.Generic;
using System;

namespace Bread
{
  public class BreadStuff
  {
    public int breadQuantity {get; set;}
    public double breadCost {get; set;}

    public BreadStuff(string quantity)
    {
      int quantityToInt;
      Int32.TryParse(quantity, out quantityToInt);
      breadQuantity = quantityToInt;
      breadCost = BreadCost(breadQuantity);
    }

    public double BreadCost(int breadQuantity)
    {
      if (breadQuantity <3)
      {
        breadCost = breadQuantity * 5.00;
      }
      else if (breadQuantity >= 3)
      {
        breadCost = (breadQuantity - (breadQuantity / 3)) * 5.00;
      }
      return breadCost;
    }
  }
}