public class Settings
{
    private string language = "PL";
    private bool askForBet = true;

    public string Language
    {
        get { return language; }
        set { language = value; Translation.Language = value; }
    }

    public bool AskForBet
    {
        get { return askForBet; }
        set { askForBet = value; }
    }

    public void ToggleLanguage()
    {
        if (Language == "PL") Language = "EN";
        else Language = "PL";
    }

    public void ToggleBetMode()
    {
        AskForBet = !AskForBet;
    }
}