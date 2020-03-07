using System;

namespace CoinCombinations.Models
{
  public class CoinSorter
  {
    public static Coin hundred = new Coin("hundreds", 10000);
    public static Coin twenty = new Coin("twenties", 2000);
    public static Coin ten = new Coin("tens", 1000);
    public static Coin five = new Coin("fives", 500);
    public static Coin dollar = new Coin("ones", 100);
    public static Coin quarter = new Coin("quarters", 25);
    public static Coin dime = new Coin("dimes", 10);
    public static Coin nickel = new Coin("nickels", 5);
    public static Coin penny = new Coin("pennies", 1);

    public static int Remainder = 0;

    public static Coin[] highToLow = new Coin[] { hundred, twenty, ten, five, dollar, quarter, dime, nickel, penny };

    public static void SortCoins(int cents)
    {
      if (cents <= 0)
      {
        Console.WriteLine("No coins back.");
      }
      else
      {
        HowManyCoins(cents, 0);
      }
    }

    public static void HowManyCoins(int cents, int startIndex)
    {
      Remainder = cents % highToLow[startIndex].Value;
      if (cents / highToLow[startIndex].Value != 0)
      {
        Console.WriteLine($"{highToLow[startIndex].Name}: {cents / highToLow[startIndex].Value}");
      }
      if (Remainder > 0)
      {
        HowManyCoins(Remainder, startIndex + 1);
      }
    }

    public static string ConvertToDollarString(int cents)
    {
      int dollars = cents / 100;
      int centsLeft = cents % 100;
      if (centsLeft < 10)
      {
        return $"${dollars}.0{centsLeft}";
      }
      return $"${dollars}.{centsLeft}";
    }

    public static int ParseCents(string dollars)
    {
      bool parsed = double.TryParse(dollars, out double result);
      if (parsed)
      {
        int cents = (int)(result * 100);
        return cents;
      }
      else
      {
        throw new Exception("Please enter a numerical input.");
      }
    }
  }
}