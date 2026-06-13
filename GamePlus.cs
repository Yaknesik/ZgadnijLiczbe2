using System;

public class GamePlus : Game 
{
    private int nextResetTry;

    public GamePlus(int difficulty) : base(difficulty)
    {
        CalculateNextReset();
    }

    public override bool IsNewGamePlus
    {
        get { return true; }
    }

    private void CalculateNextReset()
    {
        nextResetTry = currentTry + rand.Next(6, 9);
    }

    protected override void OnBeforeGuess()
    {
        if (currentTry == nextResetTry)
        {
            targetNumber = rand.Next(1, maxNumber + 1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + Translation.Get("NGPlusReset"));
            Console.ResetColor();
            CalculateNextReset();
        }
    }
}