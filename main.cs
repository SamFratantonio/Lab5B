using System;

class MainClass {
  public static void Main (string[] args) {
    double sAverage = 0;
    Console.Write("Enter Number Of Cars: ");
    double cNum = double.Parse(Console.ReadLine());
    for (int x = 1; x <= cNum; x++)
    {
      Console.Write("Enter The Distance Covered By Car " + x + ": ");
      double d = double.Parse(Console.ReadLine());
      Console.Write("Enter The Time Taken By Car " + x + ": ");
      double t = double.Parse(Console.ReadLine());
      Console.WriteLine("The Speed Of Car " + x + " is " 
      + (d / t) + " Miles Per Hour");
      sAverage += (d / t);
    }
    Console.WriteLine("The Average Speed Is " + sAverage + " Miles Per Hour");
  }
}