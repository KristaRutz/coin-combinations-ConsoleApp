using System;
using CoinCombinations.Models;

namespace CoinCombinations
{
  public class Program
  {
    public static void Main()
    {
      try
      {
        int cents = GetChangeOwedInput();
        CoinSorter.SortCoins(cents);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        Main();
      }
    }

    public static int GetChangeOwedInput()
    {

      Console.WriteLine("Customer owes: [example formats: '$0.71' or '$12.01' or '$2']");
      Console.Write("$");
      int total = CoinSorter.ParseCents(Console.ReadLine());
      Console.WriteLine("Customer paid:");
      Console.Write("$");
      int paid = CoinSorter.ParseCents(Console.ReadLine());
      Console.WriteLine($"Change due: {CoinSorter.ConvertToDollarString(paid - total)}");
      return paid - total;

    }
  }
}