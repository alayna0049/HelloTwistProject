using System;

public class HelloTwist
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        Console.WriteLine("What is your favorite hobby?");
        string hobby = Console.ReadLine();

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~");

        Console.WriteLine($"Hello, {name}!");

        Console.WriteLine($"It's awesome that you like {hobby}. {hobby} is so diverse!");

        Console.WriteLine($"Did you know that {hobby} can be a form of expression?");

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
    }
}


