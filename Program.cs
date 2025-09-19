using System;

public class HelloTwist
{
    public static void Main(string[] args)
    {
        //added a greeting message
        Console.WriteLine("Hi there! /ᐠ. .ᐟ\ฅ");
        Console.WriteLine();

        //ask for name again if input is blank
        string name = "";
        while (string.IsNullOrWhiteSpace(name))
     {
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.Writeline("Please enter your name!");
        }
     }

        //ask for hobby again if input is blank
        string hobby = "";
        while (string.IsNullOrWhiteSpace(hobby))
    {
        Console.WriteLine("What is your favorite hobby?");
        hobby = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(hobby))
        {
            Console.Writeline("Please enter a hobby!");
        }
     }

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~");

        Console.WriteLine($"Hello, {name}!");
        Console.WriteLine();

        Console.WriteLine($"It's awesome that you like {hobby}. {hobby} is so diverse!");
        Console.WriteLine($"Did you know that {hobby} can be a form of expression?");

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
    }
}




