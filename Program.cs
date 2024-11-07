using GeometricProgressionLibrary;
using System;

namespace GeometricProgressionClientProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeometricProgression progression1 = new GeometricProgression(4, 3);
            GeometricProgression progression2 = new GeometricProgression(3, 3);

            Console.WriteLine("Sum of progressions:");
            GeometricProgression sum = progression1 + progression2;
            Console.WriteLine($"{progression1} + {progression2} = {sum}");

            Console.WriteLine("Subtraction of progressions:");
            GeometricProgression substraction = progression1 - progression2;
            Console.WriteLine($"{progression1} - {progression2} = {substraction}");

            Console.WriteLine("Multiplying progression by a number:");
            double number = 2;
            GeometricProgression multiplying = progression1 * number;
            Console.WriteLine($"{progression1} * {number} = {multiplying}");

            Console.WriteLine("Equality and inequality check:");
            Console.WriteLine($"{progression1} == {progression2} : {progression1 == progression2}");
            Console.WriteLine($"{progression1} != {progression2} : {progression1 != progression2}");

            Console.WriteLine("Comparison of progressions:");
            Console.WriteLine($"{progression1} >= {progression2} : {progression1 >= progression2}");
            Console.WriteLine($"{progression1} <= {progression2} : {progression1 <= progression2}");

            Console.WriteLine("Type conversion:");
            GeometricProgression progression = new GeometricProgression(5, 2);
            double initialElement = (double)progression;
            Console.WriteLine($"Explicit conversion GeometricProgression to double: {initialElement}");

            double value = 10.0;
            GeometricProgression newProgression = value;
            Console.WriteLine($"Implicit conversion double to GeometricProgression: {newProgression}");

            Console.WriteLine("Getting element by index:");
            int index = 4;
            double element = progression1.GetElement(index);
            Console.WriteLine($"{index}th element of progression {progression1}: {element}");

        }
    }
}
