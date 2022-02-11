using System.Collections.Generic;
using System;

namespace Pastry
{
  public class PastryStuff
  {
    public int pastryQuantity {get; set;}
    public double pastryCost {get; set;}

    public PastryStuff(string quantity)
    {
      int quantityToInt;
      Int32.TryParse(quantity, out quantityToInt);
      pastryQuantity = quantityToInt;
      pastryCost = PastryCost(pastryQuantity);
    }

    public double PastryCost(int pastryQuantity)
    {
      pastryCost = ((pastryQuantity / 3) * 1.00) + ((pastryQuantity - (pastryQuantity / 3)) * 2.00);
      return pastryCost;
    }
  }
}