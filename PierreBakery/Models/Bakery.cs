using System.Collections.Generic;

namespace BreadSpace.Models
{
  public class Bread
  {
    public int BreadDemand { get;set; }

    public Bread(int breadDemand)
    {
      BreadDemand = breadDemand;
    }

    public int Cost() 
    {
      int finalCost = 0;
      if (BreadDemand >= 3)
      {
        finalCost += (BreadDemand / 3) * 10;
      }
      finalCost += (BreadDemand%3) * 5;

      return finalCost;
    }

  }
}

namespace PastrySpace.Models
{
  public class Pastry
  {
    public int PastryDemand { get;set; }

    public Pastry(int pastryDemand)
    {
      PastryDemand = pastryDemand;
    }

    public int Cost()
    {
      int finalCost = 0;
      // int remainder = 0;

      finalCost += (PastryDemand / 3) * 5;
      finalCost += (PastryDemand % 3) * 2;
      // finalCost += (PastryDemand / 6) * 10;
      // remainder = (PastryDemand % 6);
      // if (remainder == 5)
      // {
      //   finalCost += 9;
      // }
      // else if (remainder == 4)
      // {
      //   finalCost += 7;
      // }
      // else if (remainder == 3)
      // {
      //   finalCost += 5;
      // }
      // else
      // {
      //   finalCost += remainder * 2;
      // }

      return finalCost;
      
    }

  }
}