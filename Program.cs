using System;

class Program
{
    private static Settings settings = new Settings();
    private static HallOfFame hof = new HallOfFame();

    static void Main(string[] args)
    {
        int choice = 0;

        do
        {
            Console.Clear();
            Console.WriteLine(Translation.Get("MenuTitle"));
            Console.WriteLine(string.Format(Translation.Get("CurrentSettings"), settings.Language, settings.AskForBet ? "ON" : "OFF"));
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(Translation.Get("MenuOption1"));
            Console.WriteLine(Translation.Get("MenuOption2"));
            
            bool showHof = hof.HasScores();
            if (showHof) 
            {
                Console.WriteLine(Translation.Get("MenuOption3"));
            }
                
            Console.WriteLine(Translation.Get("MenuOption4"));
            Console.WriteLine(Translation.Get("MenuOption5"));
            Console.Write(Translation.Get("SelectOption"));
            
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine(Translation.Get("InvalidOption"));
                System.Threading.Thread.Sleep(1000);
                continue;
            }
            
            switch (choice)
            {
                case 1: 
                    HandleNewGame(); 
                    break;
                case 2: 
                    ShowInstruction(); 
                    break;
                case 3: 
                    if (showHof) hof.DisplayMenu(); 
                    break;
                case 4: 
                    HandleSettings(); 
                    break;
                case 5: 
                    Console.WriteLine(Translation.Get("ExitGame")); 
                    break;
                default: 
                    Console.WriteLine(Translation.Get("InvalidOption")); 
                    System.Threading.Thread.Sleep(1000);
                    break;
            }
            
        } while (choice != 5);
    }
    
    static void HandleNewGame()
    {
        Console.Clear();
        Console.WriteLine(Translation.Get("ChooseDifficulty"));
        Console.WriteLine(Translation.Get("DiffEasy"));
        Console.WriteLine(Translation.Get("DiffMedium"));
        Console.WriteLine(Translation.Get("DiffHard"));
        Console.Write(Translation.Get("SelectOption"));

        int diff;
        if (!int.TryParse(Console.ReadLine(), out diff) || diff < 1 || diff > 3) return;

        Console.Clear();
        Console.WriteLine(Translation.Get("ChooseMode"));
        Console.Write(Translation.Get("SelectOption"));
        
        int mode;
        if (!int.TryParse(Console.ReadLine(), out mode) || (mode != 1 && mode != 2)) return;

        Game game;
        
        if (mode == 2)
        {
            game = new GamePlus(diff);
        }
        else
        {
            game = new StandardGame(diff);

            if (settings.AskForBet)
            {
                Console.Write(Translation.Get("BetPrompt"));
                string answer = Console.ReadLine().ToUpper();
                if (answer == "T" || answer == "Y")
                {
                    Console.Write(Translation.Get("BetMaxTries"));
                    int limit;
                    if (int.TryParse(Console.ReadLine(), out limit))
                    {
                        game.SetBetLimit(limit);
                    }
                }
            }
        }

        game.StartGame(hof);
    }

    static void ShowInstruction()
    {
        Console.Clear();
        Console.WriteLine(Translation.Get("Instruction"));
        Console.WriteLine("\nWpisz 1 aby wrocic do menu: ");
        Console.ReadLine();
    }

    static void HandleSettings()
    {
        int choice = 0;
        do
        {
            Console.Clear();
            Console.WriteLine(Translation.Get("SettingsTitle"));
            Console.WriteLine(Translation.Get("SetLang"));
            Console.WriteLine(Translation.Get("SetClear"));
            Console.WriteLine(Translation.Get("SetBet"));
            Console.WriteLine("4. " + Translation.Get("DiffBack"));
            Console.Write(Translation.Get("SelectOption"));

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice == 1) settings.ToggleLanguage();
                else if (choice == 2)
                {
                    Console.Write(Translation.Get("ConfirmClear"));
                    string confirm = Console.ReadLine().ToUpper();
                    if (confirm == "T" || confirm == "Y")
                    {
                        hof.ClearAll();
                        Console.WriteLine(Translation.Get("HoFCleared"));
                        System.Threading.Thread.Sleep(1000);
                    }
                }
                else if (choice == 3) settings.ToggleBetMode();
            }
        } while (choice != 4);
    }
}