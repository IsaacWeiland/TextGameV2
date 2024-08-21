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
    public static int UserInputParse3() // Tries to parse user input and returns number value 1 - 3.
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
    public static int UserInputParse2() // Tries to parse user input and returns number value 1 or 2.
    {
        int choiceOut = 0;
        var inputSuccess = int.TryParse(Console.ReadLine(), out int parseSucceed);

        while (!inputSuccess || parseSucceed > 2 || parseSucceed < 1)
        {
            Console.WriteLine("Please enter 1 or 2");
            inputSuccess = int.TryParse(Console.ReadLine(), out parseSucceed);
        }

        choiceOut = parseSucceed;
        return choiceOut;

    }

    public static void Nekomata(List<int> currentAlignment)
    {
        int[] getLuck = { 1, 2, 3, 4, 5 };
        int affinity = 50;
        bool trueFeelings = false;
        Console.WriteLine("(You approached the Nekomata)");
        Console.WriteLine("What? A human? What do you want from me?");
        Console.WriteLine("[1] Ask to be friends\n[2] Ask to go on a date\n[3] Ask to be allies");
        switch (UserInputParse3())
        {
            case 1:
                Console.WriteLine("Friends? Uhhh, sure I guess.");
                currentAlignment.Add(0);
                break;
            case 2:
                Console.WriteLine("What!? I don't even know you creep!");
                Console.WriteLine("(It looks like that didn't go over very well...");
                currentAlignment.Add(-5);
                affinity -= 25;
                trueFeelings = true;
                break;
            case 3:
                Console.WriteLine("Allies? Can you even fight?\nWell, whatever at least you're not a total creep.");
                currentAlignment.Add(1);
                break;
        }
        while (affinity > 0 && affinity <= 100)
        {
            int nextResponse = QuestionGen(getLuck);
            int getResponse;
            switch (nextResponse) //TODO Finish case 5
            {
                case 1:
                    Console.WriteLine("Hey! You think you're strong?\nI bet you can't crush this rock with your bare hands!");
                    Console.WriteLine("[1] Attempt to crush the rock\n[2] Do not attempt to crush the rock\n[3] Attempt to eat the rock");
                    getResponse = UserInputParse3();
                    if (getResponse == 1)
                    {
                        Console.WriteLine("(You attempted to crush the rock.)\n(You were not strong enough to crush it)");
                        Console.WriteLine("Hahaha! You're so weak!");
                        currentAlignment.Add(0);
                        affinity -= 10;
                    }
                    else if (getResponse == 2)
                    {
                        Console.WriteLine("(You didn't even try)");
                        Console.WriteLine("What? That's so lame...\n(She seems to respect your honesty)");
                        currentAlignment.Add(2);
                        affinity += 10;
                    }
                    else
                    {
                        Console.WriteLine("(You attempted to take a bite off the rock.)");
                        Console.WriteLine("(Nekomata started laughing)\nI can't believe you would do that, haha!");
                        currentAlignment.Add(-1);
                        affinity += 30;
                    }

                    break;
                case 2:
                    Console.WriteLine("Hey, so, I've heard that some people can fuse us demons into other demons.\nWould you fuse me into another demon if you could?");
                    Console.WriteLine("[1] Say you would fuse her into a powerful demon\n[2] Say you would fuse her into a beautiful demon\n[3] Say you would not fuse her at all");
                    getResponse = UserInputParse3();
                    if (getResponse == 1)
                    {
                        Console.WriteLine("Well I dunno... I'm already pretty strong as is.");
                        currentAlignment.Add(-1);
                    }
                    else if (getResponse == 2)
                    {
                        if (trueFeelings)
                        {
                            Console.WriteLine("Tch, so much for asking me out earlier...");
                            Console.WriteLine("(Nekomata seems very displeased)");
                            currentAlignment.Add(-5);
                            affinity -= 50;
                        }
                        else
                        {
                            Console.WriteLine("Hmph, well, I think I'm pretty beautiful as is.");
                            currentAlignment.Add(-1);
                            affinity += 10;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Pshaw, I bet you can't even fuse demons anyway.");
                        Console.WriteLine("(She seems a little pleased by this, however.");
                        currentAlignment.Add(1);
                        if (trueFeelings)
                        {
                            affinity += 20;
                        }
                        else
                        {
                            affinity -= 10;
                        }
                    }

                    break;
                case 3:
                    Console.WriteLine("Hey, do you have a lot of fish where you're from?");
                    Console.WriteLine("[1] Tell her yes\n[2] Tell her no\n[3] Ask her what a fish is");
                    getResponse = UserInputParse3();
                    if (getResponse == 1)
                    {
                        Console.WriteLine("Woah! I haven't had fish in like, forever.\nWe should go get fish sometime!");
                        currentAlignment.Add(1);
                        affinity += 20;
                    }
                    else if (getResponse == 2)
                    {
                        Console.WriteLine("So you don't get to have fish either?\n*Sigh* that's okay they don't live around here either.");
                        currentAlignment.Add(0);
                        affinity += 10;
                    }
                    else
                    {
                        Console.WriteLine("What!? You don't know what a fish is!?");
                        if (trueFeelings)
                        {
                             Console.WriteLine("You should know what the girl you ask out likes to eat you know!");
                             currentAlignment.Add(-1);
                             affinity -= 10;
                        }
                        Console.WriteLine("(Nekomata proceeded to explain what fish are and how much she loves eating them.");
                        Console.WriteLine("(It seemed like an overall positive interaction)");
                        currentAlignment.Add(0);
                        affinity += 10;
                    }

                    break;
                case 4:
                    Console.WriteLine("(Nekomata looks bored)");
                    Console.WriteLine("[1] Sing for her\n[2] Dance for her\n[3] Flash some money");
                    getResponse = UserInputParse3();
                    if (getResponse == 1)
                    {
                        Console.WriteLine("(You sang for Nekomata)");
                        Console.WriteLine("(Nekomata meowed along with you)\nYou're not too bad yourself!");
                        currentAlignment.Add(2);
                        affinity += 25;
                    }
                    else if (getResponse == 2)
                    {
                        Console.WriteLine("(You did a dance for Nekomata)");
                        Console.WriteLine("(Nekomata laughed at you)");
                        currentAlignment.Add(-1);
                        affinity += 5;
                    }
                    else
                    {
                        
                            Console.WriteLine("Hm? What're you gonna do with that?");
                            Console.WriteLine("[1] Offer to buy her jewelry\n[2] Offer to buy her groceries\n[3] Say it's for her");
                            getResponse = UserInputParse3();
                            if (getResponse == 1)
                            {
                                Console.WriteLine("Oh jewels? Those are nice, but I'm not that interested.");
                                currentAlignment.Add(1);
                            }
                            else if (getResponse == 2)
                            {
                                Console.WriteLine("Groceries? Is that like fish? I love fish!");
                                currentAlignment.Add(0);
                                affinity += 10;
                            }
                            else
                            {
                                if (trueFeelings)
                                {
                                    Console.WriteLine("Do you think I'm some cheap girl you can just buy!?");
                                    currentAlignment.Add(-5);
                                    affinity -= 25;
                                }
                                else
                                {
                                    Console.WriteLine("I'm not really interested in that at all...");
                                    currentAlignment.Add(-1);
                                    affinity -= 10;
                                }
                            }
                    }

                    break;
                case 5:
                    Console.WriteLine("Do you like animals?");
                    Console.WriteLine("[1] Tell her yes\n[2] Tell her no\n[3] Tell her you eat them for pleasure");
                    getResponse = UserInputParse3();
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
        if (addedAlignment > 1 && affinity > 0)//TODO rework this section, maybe make it a method
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