using System;

class GetTriangle
{
    static void Main(string[] args)
    {
       Console.WriteLine("Please enter a value for the base of the triangle:");
       int triangleBase = Convert.ToInt32(Console.ReadLine());

       Console.WriteLine("Please enter a value for the height of the triangle:");
       int triangleHeight = Convert.ToInt32(Console.ReadLine());
  
       int calculatedAreaOfTriangle = triangleBase * triangleHeight / 2;
       Console.WriteLine("The area of the triangle is " + calculatedAreaOfTriangle);
    }
}