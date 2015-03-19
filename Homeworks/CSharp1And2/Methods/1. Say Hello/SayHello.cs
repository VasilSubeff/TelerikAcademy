//Problem 1. Say Hello
//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.

using System;

class SayHello
{
    public static void SayHelloName(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
    static void Main()
    {
        Console.WriteLine("What is your name ?");
        string inputName = Console.ReadLine();

        SayHelloName(inputName);
    }
}

