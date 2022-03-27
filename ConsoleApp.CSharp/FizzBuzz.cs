﻿namespace ConsoleApp.CSharp;

using static Console;

public static class FizzBuzz
{
    public static void Run(int fromNum, int toNum)
    {
        for (var i = fromNum; i <= toNum; i++)
        {
            var result = "";
        
            if (i % 3 == 0) result += "Fizz";
            if (i % 5 == 0) result += "Buzz";

            WriteLine(result == "" ? i : result);
        }
    }
}