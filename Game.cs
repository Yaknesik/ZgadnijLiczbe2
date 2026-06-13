using System;

public abstract class Game
{
    protected int targetNumber;
    protected int maxNumber;
    protected int currentTry = 1;
    protected int difficulty;
    protected int maxTriesLimit = 0;
    protected bool hasBet = false;
    protected Random rand = new Random();

    public Game(int difficulty)
    {
        this.difficulty = difficulty;
        if (difficulty == 1) maxNumber = 50;
        else if (difficulty == 2) maxNumber = 100;
        else maxNumber = 250;

        targetNumber = rand.Next(1, maxNumber + 1);
    }

    public abstract bool IsNewGamePlus { get; }

    public void SetBetLimit(int limit)
    {
        maxTriesLimit = limit;
        hasBet = true;
    }

    protected virtual void OnBeforeGuess() 
    {

    }

    public void StartGame(HallOfFame hof)
    {
        DateTime startTime = DateTime.Now;

        Console.Clear();
        Console.WriteLine(string.Format(Translation.Get("GameRange"), maxNumber));

        bool guessed = false;
        int guess = 0;

        while (!guessed)
        {
            OnBeforeGuess();

            if (hasBet && currentTry > maxTriesLimit)
            {
                Console.WriteLine(string.Format(Translation.Get("BetLost"), maxTriesLimit));
                System.Threading.Thread.Sleep(3000);
                break;
            }

            Console.Write(string.Format(Translation.Get("TryNumber"), currentTry));
            
            if (!int.TryParse(Console.ReadLine(), out guess) || guess < 1 || guess > maxNumber)
            {
                Console.WriteLine(string.Format(Translation.Get("InputError"), maxNumber));
                continue;
            }

            if (guess < targetNumber)
            {
                Console.WriteLine(Translation.GetRandomHint(true));
                currentTry++;
            }
            else if (guess > targetNumber)
            {
                Console.WriteLine(Translation.GetRandomHint(false));
                currentTry++;
            }
            else
            {
                guessed = true;
                DateTime endTime = DateTime.Now;
                int elapsedSeconds = (int)(endTime - startTime).TotalSeconds;
                
                Console.WriteLine("\n" + string.Format(Translation.Get("WinMessage"), targetNumber, currentTry, elapsedSeconds));
                Console.Write(Translation.Get("EnterName"));
                string name = Console.ReadLine();

                Score newScore = new Score(difficulty, currentTry, name, elapsedSeconds, IsNewGamePlus);
                hof.SaveScore(newScore);
                
                Console.WriteLine(Translation.Get("ScoreSaved"));
                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}