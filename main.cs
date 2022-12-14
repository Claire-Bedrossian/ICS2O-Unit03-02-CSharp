// Created by: Claire Bedrossian
// Created on: Oct 2022
//
// This program calculates the area of a right rectangular pyramid

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double width;
        double length;
        double height;
        double area;
        Console.WriteLine("This program calculates the volume of a right rectangular pyramid.");
        Console.WriteLine("");

        Console.Write("Enter the length of side A (cm): ");
        width = Convert.ToSingle(Console.ReadLine());

        Console.Write("Enter the length of side B (cm): ");
        length = Convert.ToSingle(Console.ReadLine());

        Console.Write("Enter the height (cm): ");
        height = Convert.ToSingle(Console.ReadLine());

        area = (length * width * height) / 3;

        Console.WriteLine("");
        Console.WriteLine("The volume is: " + area.ToString("0.00") + " cm³. ");

        Console.WriteLine("\nDone.");
    }
}