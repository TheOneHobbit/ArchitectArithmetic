using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Creating switch cases for the output, and allowing input choice from the user on which floor plan they wish to work with:
      Console.WriteLine("What monument would you like to work with?");
      Console.Write("Choose the TAJ MAHAL, AL-HARAM, or TEOTIHUACAN: ");
      string answer = Console.ReadLine();
      if (answer != null)
      {
        answer = answer.ToUpper(); 

      switch (answer)
      {
        case "TAJ MAHAL":
          CalculateTotalCost(answer);
          break;

        case "AL-HARAM":
          CalculateTotalCost(answer);
          break;

        case "TEOTIHUACAN":
          CalculateTotalCost(answer);
          break;

         default:
          Console.WriteLine("Error, please input a monument.");
          break;
       }
     }
    }
      /* Teotihuacan floor plan:
      Rectangle = 1500m x 2500m
      Circle = 375m/2*
      Triangle = 500m x 750m */

      /* Taj Mahal floor plan:
      Triangle = 2 x (24m x 24m) x 4;
      Square = 90.5m x 90.5m */

      /* Al-Haram Great Mosque floor plan:
      Large Rectangle = 284m x 264m
      Small Rectangle = 180m x 106m
      Triangle = (264m x 84m)/2 */
    
    // Creating a method to use in Main which calculates total cost depending on floor plan:
    static double CalculateTotalCost(string Building)
      {
      switch (Building)
       {
        case "TAJ MAHAL":
         // Calculating total area variable:
         double triArea = Tri(24, 24) * 4;
         double TajMahalArea = Rect(90.5, 90.5) - triArea;
         // Total cost of materials where material is equal to 180 Mexican pesos:
         double price = TajMahalArea * 180;
         // Returning the price which is to be outputted to the console:
         Console.WriteLine($"{Math.Round(price, 2)} pesos");
         return price;
                    
        case "AL-HARAM":
         // Calculating total area variable:
         double triArea2 = Tri(264, 84);
         double bigRectArea = Rect(284, 264) - triArea2;
         double smallRectArea = Rect(180, 106);
         double AlHaramArea = bigRectArea + smallRectArea;
         // Total cost of materials where material is equal to 180 Mexican pesos:
         double price2 = AlHaramArea * 180;
         // Returning the price which is to be outputted to the console:
         Console.WriteLine($"{Math.Round(price2, 2)} pesos");
         return price2;
     
        case "TEOTIHUACAN":
         // Calculating total area variable:
         double TeotihuacanArea = Rect(2500, 1500) + Tri(750, 500) + (Circ(375) / 2); 
         // Total cost of materials where material is equal to 180 Mexican pesos:
         double price3 = TeotihuacanArea * 180;
         // Returning the price which is to be outputted to the console:
         Console.WriteLine($"The plan will cost: {Math.Round(price3, 2)} pesos");
         return price3;

        default:
         Console.WriteLine("No input given.");
         return 0;
       }
      }
     // Creating area methods for use in floor plan costs:
     static double Rect(double length, double width)
     {
      double area = length * width;
      return area;
     }
     static double Circ(double radius)
     {
      double area = Math.PI * Math.Pow(radius, 2);
      return area;
     }
     static double Tri(double bottom, double height)
     {
      double area = 0.5 * bottom * height;
      return area;
     }
    }
  }

