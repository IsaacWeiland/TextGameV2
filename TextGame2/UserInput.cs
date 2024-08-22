namespace TextGame2;

public class UserInput
{
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
}