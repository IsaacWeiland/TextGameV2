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
        Console.WriteLine("Dummy text.\n[1] I like your hair.\n[2] Your hair sucks.\n[3] Say nothing");
        affinity = AnswerMath(affinity);
        Console.WriteLine($"{affinity}");
        
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
                Console.WriteLine("Thank you!");
                int parseAff = int.Parse(affinity);
                parseAff++;
                return $"{parseAff}";
            }

            if (response == 2)
            {
                Console.WriteLine("That was rude!");
                int parseAff = int.Parse(affinity);
                parseAff--;
                return $"{parseAff}";
            }

            if (response == 3)
            {
                Console.WriteLine("(You said nothing).");
                return affinity;
            }
            else Console.WriteLine("Invalid answer\nPlease enter a valid answer.");
        } while (response != null);

        return "complete";
    }
}