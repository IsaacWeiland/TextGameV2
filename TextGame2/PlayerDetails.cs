namespace TextGame2;

public class PlayerDetails
{
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
}