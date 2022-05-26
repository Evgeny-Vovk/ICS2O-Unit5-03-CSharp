// Created by: Evgeny Vovk
// Created on: May 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program calculate which movie rate can you watch
        int age;

        // input
        Console.WriteLine("");
        Console.Write("Input your age to check which movie rate can you watch: ");
        age = Convert.ToInt32(Console.ReadLine());

        // process
        Console.WriteLine("");
        if (age >= 17)
        {
            Console.WriteLine("You are " + age + " years old, so you can see R rated movies.");
        }
        else if(age >= 13)
        {
            Console.WriteLine("You are " + age + " years old, so you can see PG-13 rated movies.");
        }
        else
        {
            Console.WriteLine("You are " + age + " years old, so you can see G rated movies.");
        }
        Console.WriteLine("\nDone.");
    }
}