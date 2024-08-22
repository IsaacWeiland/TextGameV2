using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace TextGame2;


class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Welcome to the game!\nPlease enter your name.");
        // string playerName = Console.ReadLine();
        // Console.WriteLine("Please enter your gender\n[1] Male\n[2] Female");
        // string sex = Sex();
        // string pn1 = Pronoun(sex);
        // Console.WriteLine($"{playerName}, you are a {sex}.\nThat's a lovely one isn't {pn1}.");
        List<int> alignment = new List<int>();
        Negotiations.Nekomata(alignment);

    }
}