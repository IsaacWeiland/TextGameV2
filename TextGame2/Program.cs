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
        Nekomata(alignment);

    }

    public static string Sex() //asks user for gender, currently unused
    {
        string ans;
        do
        {
            ans = Console.ReadLine();
            if (ans == "1")
            {
                return "Male";
            }

            if (ans == "2")
            {
                return "Female";
            }
            else Console.WriteLine("Invalid answer\nPlease enter a valid answer.");
        } while (ans != null);//repeats until a selection is made
        return ans;
    }

    public static string Pronoun(string a)//code for player pronouns, currently unused
    {
        string pn1 = a; 
        switch (pn1)
        {
            case "Male":
            {
                string pronoun2 = "he";
                return pronoun2;
                break;
            }
            default:
            {
                string pronoun2 = "she";
                return pronoun2;
                break;
                
            }
        }
    }
    
    public static int QuestionGen(int[] findLuck)
    {
        Random r = new Random();
        int randNum = r.Next(1, 5);
        // findLuck[randNum];
        int luckFound = findLuck[randNum];
        while (luckFound == 0)
        {
            randNum = r.Next(1, 5);     //r.Next is added here, so it doesn't infinite loop num assignment
            luckFound = findLuck[randNum];
        }        //while loop so no option is repeated 
        findLuck[randNum] = 0;
        return luckFound;
    }//RNG that chooses which dialogue is said next.
    public static int UserInputParse() // Tries to parse user input and returns number value 1 - 3.
    {
        int choiceOut = 0;
        var inputSuccess = int.TryParse(Console.ReadLine(), out int parseSucceed);

        while (!inputSuccess || parseSucceed > 3 || parseSucceed < 1)
        {
            Console.WriteLine("Please enter a number 1 - 3.");
            inputSuccess = int.TryParse(Console.ReadLine(), out parseSucceed);
        }

        choiceOut = parseSucceed;
        return choiceOut;

    }

    public static void Nekomata(List<int> currentAlignment)
    {
        int[] getLuck = { 1, 2, 3, 4, 5 };
        int affinity = 50;
        while (affinity > 0 && affinity <= 100)
        {
            int nextResponse = QuestionGen(getLuck);
            int getResponse;
            switch (nextResponse) //TODO Write dialogue in here, Change answer properties
            {
                case 1:
                    Console.WriteLine("Dummy 1");
                    Console.WriteLine("Dummy asnwer1\nDummy answer2\nDummy Answer 3");
                    getResponse = UserInputParse();
                    if (getResponse == 1)
                    {
                        Console.WriteLine("Alignment Up!");
                        currentAlignment.Add(1);
                    }
                    else if (getResponse == 2)
                    {
                        Console.WriteLine("Alignment Down!");
                        currentAlignment.Add(-1);
                        affinity += 25;
                    }
                    else
                    {
                        Console.WriteLine("Alignment Neutral");
                        currentAlignment.Add(0);
                        affinity -= 10;
                    }

                    break;
                case 2:
                    Console.WriteLine("Dummy 2");
                    Console.WriteLine("Dummy asnwer1\nDummy answer2\nDummy Answer 3");
                    getResponse = UserInputParse();
                    if (getResponse == 1)
                    {
                        Console.WriteLine("Alignment Up!");
                        currentAlignment.Add(1);
                    }
                    else if (getResponse == 2)
                    {
                        Console.WriteLine("Alignment Down!");
                        currentAlignment.Add(-1);
                        affinity += 25;
                    }
                    else
                    {
                        Console.WriteLine("Alignment Neutral");
                        currentAlignment.Add(0);
                        affinity -= 10;
                    }

                    break;
                case 3:
                    Console.WriteLine("Dummy 3");
                    Console.WriteLine("Dummy asnwer1\nDummy answer2\nDummy Answer 3");
                    getResponse = UserInputParse();
                    if (getResponse == 1)
                    {
                        Console.WriteLine("Alignment Up!");
                        currentAlignment.Add(1);
                    }
                    else if (getResponse == 2)
                    {
                        Console.WriteLine("Alignment Down!");
                        currentAlignment.Add(-1);
                        affinity += 25;
                    }
                    else
                    {
                        Console.WriteLine("Alignment Neutral");
                        currentAlignment.Add(0);
                        affinity -= 10;
                    }

                    break;
                case 4:
                    Console.WriteLine("Dummy 4");
                    Console.WriteLine("Dummy asnwer1\nDummy answer2\nDummy Answer 3");
                    getResponse = UserInputParse();
                    if (getResponse == 1)
                    {
                        Console.WriteLine("Alignment Up!");
                        currentAlignment.Add(1);
                    }
                    else if (getResponse == 2)
                    {
                        Console.WriteLine("Alignment Down!");
                        currentAlignment.Add(-1);
                        affinity += 25;
                    }
                    else
                    {
                        Console.WriteLine("Alignment Neutral");
                        currentAlignment.Add(0);
                        affinity -= 10;
                    }

                    break;
                case 5:
                    Console.WriteLine("Dummy 5");
                    Console.WriteLine("Dummy asnwer1\nDummy answer2\nDummy Answer 3");
                    getResponse = UserInputParse();
                    if (getResponse == 1)
                    {
                        Console.WriteLine("Alignment Up!");
                        currentAlignment.Add(1);
                    }
                    else if (getResponse == 2)
                    {
                        Console.WriteLine("Alignment Down!");
                        currentAlignment.Add(-1);
                        affinity += 25;
                    }
                    else
                    {
                        Console.WriteLine("Alignment Neutral");
                        currentAlignment.Add(0);
                        affinity -= 10;
                    }
                    break;
            }
        }

        int addedAlignment = AlignMath(currentAlignment);
        if (addedAlignment > 1 && affinity > 0)
        {
            Console.WriteLine("Law ending");
        }
        else if (affinity >= 100)
        {
            Console.WriteLine("Neutral Date ending\nEnjoy your catgirl demon gf!");
        }
        else
        {
            Console.WriteLine("Bad ending\nYou really suck.");
        }
    }//probably will end up being the main copy-paste for most script in the game.

    public static int AlignMath(List<int> toCalc)
    {
        int output = 0;
        foreach (var change in toCalc)
        {
            output += change;
        }

        return output;
    }//takes alignment to be calculated for later
}