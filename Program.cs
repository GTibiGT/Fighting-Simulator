// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using Character;

class Sim{
    static void Main(){
        bool isValid = false;
        int num;
        Console.WriteLine("Welcome to Fighting Simulator this is a turn based game where each character");
        Console.WriteLine("has their own specific skill/martial art and weaknesses and strengths.");
        Console.WriteLine("");
        Console.WriteLine("Choose your character");
        Console.WriteLine("1. Boxer");
        Console.WriteLine("2. Wrestler");
        Console.WriteLine("3. Kick-Boxer");
        Console.WriteLine("Enter corresponding number to the style you want to pick");
        do
        {
            string input = Console.ReadLine();
            isValid = int.TryParse(input, out num);

            if (!isValid || num < 1 || num > 3)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer between 1 and 3.");
            }

        } while (!isValid || num < 1 || num > 3);
    
        Console.WriteLine("So you chose: The " + charSelect(num));
    }

    static string charSelect(int num){
        Dictionary<int, string> chars = new Dictionary<int, string>
        {
            {1, "Boxer"},
            {2, "Wrestler"},
            {3, "Kick-Boxer"}
        };
        if (chars.ContainsKey(num)){
            return chars[num];
        }
        return "Unknown";
    
    }
}