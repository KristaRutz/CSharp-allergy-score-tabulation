using System;
using Allergies.Models;

namespace Allergies
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("List the allergies you have by adding up their scores");
      for (int i = 1; i <= 128; i *= 2)
      {
        Console.WriteLine("Score: " + i + " \t" + (Allergy.AllergiesList)i);
      }
      string scoreString = Console.ReadLine();
      int score;
      bool success = int.TryParse(scoreString, out score);
      if (success)
      {
        var allergyResults = (Allergy.AllergiesList)score;
        Console.WriteLine(allergyResults);
        Console.ReadLine();
      }
      else
      {
        Main();
      }
    }
  }
}