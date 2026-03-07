// Given the side length of a square, calculate its area and perimeter.

using System;

class Logic
{
    static void Main()
    {
        int side, area, perimeter;

        Console.WriteLine("Provide the side of the square:");

        while (!int.TryParse(Console.ReadLine(), out side))
        {
            Console.WriteLine("Invalid attempt. Please enter a valid number:");
        }

        area = side * side;
        perimeter = side * 4;

        Console.WriteLine("Area: " + area);
        Console.WriteLine("Perimeter: " + perimeter);
    }
}