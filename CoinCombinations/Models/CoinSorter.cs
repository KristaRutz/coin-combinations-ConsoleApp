using System;

namespace Project.Models
{
  public class CoinSorter
  {
    public static int dollar = 100;
    public static int quarter = 25;
    public static int dime = 10;
    public static int nickel = 5;
    public static int penny = 1;

    public static int Remainder = 0;

    public static int[] highToLow = new int[] { dollar, quarter, dime, nickel, penny };

    public static void HowManyCoins(int cents, int startIndex)
    {
      Remainder = cents % highToLow[startIndex];
      if (Remainder > 0)
      {
        HowManyCoins(Remainder, startIndex + 1);
      }
      Console.WriteLine($"{startIndex}: {cents / highToLow[startIndex]}");

    }
  }
}