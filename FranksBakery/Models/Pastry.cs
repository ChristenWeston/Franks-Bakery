using System.Collections.Generic;
using System;

namespace Pastry
{
  public class PastryStuff
  {
    public int pastryQuantity {get; set;}
    public double pastryCost {get; set;}

    //Constructor
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
      Console.WriteLine("Pastry cost is : " + pastryCost);
      return pastryCost;
    }
  }
}

//Buy 1 for $2 or 3 for $5. 
//Four pastries costs $7, five pastries costs $9,
// and six pastries costs $10.