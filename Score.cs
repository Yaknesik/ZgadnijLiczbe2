public class Score
{
    public int Difficulty;
    public int Tries;
    public string Name;
    public int DurationSeconds;
    public bool IsNewGamePlus;

    public Score(int difficulty, int tries, string name, int durationSeconds, bool isNewGamePlus)
    {
        Difficulty = difficulty;
        Tries = tries;
        Name = name;
        DurationSeconds = durationSeconds;
        IsNewGamePlus = isNewGamePlus;
    }
}