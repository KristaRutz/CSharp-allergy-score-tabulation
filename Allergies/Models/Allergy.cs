using System;

namespace Allergies.Models
{
  public class Allergy
  {

    [Flags]
    public enum AllergiesList
    {
      None = 0,
      Eggs = 1,
      Peanuts = 2,
      Shellfish = 4,
      Strawberries = 8,
      Tomatoes = 16,
      Chocolate = 32,
      Pollen = 64,
      Cats = 128
    }
  }
}