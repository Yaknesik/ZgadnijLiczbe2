public class StandardGame : Game
{
    public StandardGame(int difficulty) : base(difficulty)
    {
    }

    public override bool IsNewGamePlus
    {
        get { return false; }
    }
}