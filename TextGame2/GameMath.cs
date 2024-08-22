namespace TextGame2;

public class GameMath
{
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
    }
    //RNG that chooses which dialogue is said next.

    public static int AlignMath(List<int> toCalc)
    {
        int output = 0;
        foreach (var change in toCalc)
        {
            output += change;
        }

        return output;
    }
    //takes alignment to be calculated for later
}