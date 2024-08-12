namespace TextGame2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the game!\nPlease enter your name.");
        string playerName = Console.ReadLine();
        Console.WriteLine("Please enter your gender\n[1] Male\n[2] Female");
        string sex = Sex();
        string pn1 = Pronoun(sex);
        Console.WriteLine($"{playerName}, you are a {sex}.\nThat's a lovely one isn't {pn1}.");
        string affinity = "0";
        Nekomata(affinity);

    }
    

    public static string Sex() //asks user for gender
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

    public static string Pronoun(string a)
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

    public static string AnswerMath(string affinity)
    {
        int response;
        do
        {
            response = int.Parse(Console.ReadLine());
            if (response == 1)
            {
                Console.WriteLine("Friends? Sure! Don't think it'll be that easy though.");
                int parseAff = int.Parse(affinity);
                parseAff++;
                return $"{parseAff}";
            }

            if (response == 2)
            {
                Console.WriteLine("A date? *Chuckles* As if I'd go out with you!");
                int parseAff = int.Parse(affinity);
                parseAff--;
                return $"{parseAff}";
            }

            if (response == 3)
            {
                Console.WriteLine("Allies? Do you want me to die for you or something?.");
                return affinity;
            }
            else Console.WriteLine("Invalid answer\nPlease enter a valid answer.");
        } while (response != null);

        return "complete";
    }

    public static string Nekomata(string affinity)
    {
        Console.WriteLine("(You approached the Nekomata).\nOh a human! But... what could you want with me?\n[1] Ask to" +
                          " be friends.\n[2] Ask to go on a date with her.\n[3] Ask to be allies.");
        affinity = AnswerMath(affinity);
        Console.WriteLine($"{affinity}");
        return "complete";
    }
}