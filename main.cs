using System;

class Program {
  
  public static void Main (string[] args) {

    Console.WriteLine("Enter the wind speed in miles per hour: ");
    double windSpeed = Convert.ToDouble(Console.ReadLine());

    String category;
    switch (windSpeed)
    {
    case double speed when speed >= 157:
    category = "Category Five Hurricane";
    break;
    case double speed when speed >= 130:
    category = "Category Four Hurricane";
    break;
    case double speed when speed >= 111:
    category = "Category Three Hurricane";
    break;
    case double speed when speed >= 96:
    category = "Category Two Hurricane";
    break;
    case double speed when speed >= 74:
    category = "Category One Hurricane";
    break;
    default:
    category = "Not a hurricane";
    break;
      }
    Console.WriteLine(category);
    }
  }
  