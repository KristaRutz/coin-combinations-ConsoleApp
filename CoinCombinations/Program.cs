using System;
using CoinCombinations.Models;

namespace CoinCombinations
{
  public class Program
  {
    public static void Main()
    {
      int cents = GetChangeOwedInput();
      CoinSorter.SortCoins(cents);
    }

    public static int GetChangeOwedInput()
    {
      Console.WriteLine("Customer total cents owed?");
      int total = int.Parse(Console.ReadLine());
      Console.WriteLine("Customer cents paid?");
      int paid = int.Parse(Console.ReadLine());
      Console.WriteLine($"Change due: {paid - total} cents");
      return paid - total;
    }
  }
}