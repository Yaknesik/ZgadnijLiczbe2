using System;
using System.Collections.Generic;

public class Translation
{
    public static string Language = "PL";

    public static string Get(string key)
    {
        if (Language == "PL")
        {
            if (key == "MenuTitle") return "============================================\nWitamy w \"Guess The Number!\"\n============================================";
            if (key == "MenuOption1") return "1. Rozpocznij gre";
            if (key == "MenuOption2") return "2. Instrukcja";
            if (key == "MenuOption3") return "3. Hall of Fame";
            if (key == "MenuOption4") return "4. Ustawienia";
            if (key == "MenuOption5") return "5. Wyjscie";
            if (key == "CurrentSettings") return "Aktualne ustawienia: Jezyk: {0} | Zaklady: {1}";
            if (key == "SelectOption") return "Wybierz opcje: ";
            if (key == "HOFOptions") return "[1-3] Zmien Poziom | [4] Menu Glowne";
            if (key == "HOFTries") return "Próby: ";
            if (key == "HOFTime") return "Czas: ";
            if (key == "InvalidOption") return "Nieprawidlowa opcja! Sprobuj ponownie.";
            if (key == "ExitGame") return "Wyjscie z gry.";
            if (key == "ChooseDifficulty") return "Wybierz poziom trudnosci:";
            if (key == "DiffEasy") return "1. Latwy (1-50)";
            if (key == "DiffMedium") return "2. Sredni (1-100)";
            if (key == "DiffHard") return "3. Trudny (1-250)";
            if (key == "DiffBack") return "4. Powrot";
            if (key == "ChooseMode") return "Wybierz tryb gry:\n1. Standardowy\n2. Nowa Gra Plus (NG+)";
            if (key == "BetPrompt") return "Czy chcesz aktywowac tryb zakladu? (T/N): ";
            if (key == "BetMaxTries") return "Podaj maksymalna liczbe prob: ";
            if (key == "GameRange") return "Zgadnij liczbe w zakresie od 1 do {0}!";
            if (key == "TryNumber") return "Proba nr {0} | Twoj strzal: ";
            if (key == "InputError") return "BLAD! Wpisz liczbe od 1 do {0}!";
            if (key == "BetLost") return "Przegrales zaklad! Przekroczyles maksymalna liczbe prob ({0}).";
            if (key == "WinMessage") return "Brawo! Odgadles liczbe {0} w {1} probach! Czas: {2} sekund.";
            if (key == "EnterName") return "Podaj swoje imie: ";
            if (key == "ScoreSaved") return "Wynik zostal zapisany!";
            if (key == "NGPlusReset") return "LICZBA ZOSTALA ZMIENIONA!!!";
            if (key == "HoFTitle") return "===== HALL OF FAME =====";
            if (key == "HoFEmpty") return "Brak zapisanych wynikow dla tego poziomu!";
            if (key == "SettingsTitle") return "===== USTAWIENIA =====";
            if (key == "SetLang") return "1. Zmien jezyk (PL/EN)";
            if (key == "SetClear") return "2. Wyczysc Hall of Fame";
            if (key == "SetBet") return "3. Przelacz tryb zakladu";
            if (key == "ConfirmClear") return "Czy na pewno chcesz wyczyscic wyniki? (T/N): ";
            if (key == "HoFCleared") return "Hall of Fame zostalo wyczyszczone.";
            if (key == "Instruction") return "INSTRUKCJA:\nZgadnij liczbe wybrana przez komputer.\nW trybie NG+ liczba zmienia sie co 6-8 strzalow.\nW Hall of Fame liczy sie najpierw liczba prob, a potem czas!";
            if (key == "InstructionLeave") return "\nWpisz 1 aby wrocic do menu: ";
        }
        else
        {
            if (key == "MenuTitle") return "============================================\nWelcome to \"Guess The Number!\"\n============================================";
            if (key == "MenuOption1") return "1. Start Game";
            if (key == "MenuOption2") return "2. Instruction";
            if (key == "MenuOption3") return "3. Hall of Fame";
            if (key == "MenuOption4") return "4. Settings";
            if (key == "MenuOption5") return "5. Exit";
            if (key == "CurrentSettings") return "Current settings: Lang: {0} | Betting: {1}";
            if (key == "SelectOption") return "Select option: ";
            if (key == "HOFOptions") return "[1-3] Switch Diff | [4] Main Menu";
            if (key == "HOFTries") return "Tries: ";
            if (key == "HOFTime") return "Time: ";
            if (key == "InvalidOption") return "Invalid option! Try again.";
            if (key == "ExitGame") return "Exiting game.";
            if (key == "ChooseDifficulty") return "Choose difficulty level:";
            if (key == "DiffEasy") return "1. Easy (1-50)";
            if (key == "DiffMedium") return "2. Medium (1-100)";
            if (key == "DiffHard") return "3. Hard (1-250)";
            if (key == "DiffBack") return "4. Back";
            if (key == "ChooseMode") return "Choose game mode:\n1. Standard\n2. New Game Plus (NG+)";
            if (key == "BetPrompt") return "Do you want to enable betting mode? (Y/N): ";
            if (key == "BetMaxTries") return "Enter maximum number of tries: ";
            if (key == "GameRange") return "Guess the number between 1 and {0}!";
            if (key == "TryNumber") return "Try no. {0} | Your guess: ";
            if (key == "InputError") return "ERROR! Enter a number between 1 and {0}!";
            if (key == "BetLost") return "You lost the bet! Exceeded maximum tries ({0}).";
            if (key == "WinMessage") return "Congratulations! You guessed {0} in {1} tries! Time: {2} seconds.";
            if (key == "EnterName") return "Enter your name: ";
            if (key == "ScoreSaved") return "Score saved!";
            if (key == "NGPlusReset") return "THE NUMBER HAS CHANGED!!!";
            if (key == "HoFTitle") return "===== HALL OF FAME =====";
            if (key == "HoFEmpty") return "No scores recorded yet for this difficulty!";
            if (key == "SettingsTitle") return "===== SETTINGS =====";
            if (key == "SetLang") return "1. Change language (PL/EN)";
            if (key == "SetClear") return "2. Clear Hall of Fame";
            if (key == "SetBet") return "3. Toggle betting mode prompt";
            if (key == "ConfirmClear") return "Are you sure you want to clear records? (Y/N): ";
            if (key == "HoFCleared") return "Hall of Fame has been cleared.";
            if (key == "Instruction") return "INSTRUCTION:\nGuess the secret number chosen by computer.\nIn NG+ mode, the number shifts every 6-8 shots.\nIn Hall of Fame, lower tries win; ties are broken by shorter time!";
            if (key == "InstructionLeave") return "\nType 1 to back to main menu: ";
        }
        return key;
    }

    public static string GetRandomHint(bool tooLow)
    {
        Random rand = new Random();
        List<string> hints = new List<string>();

        if (Language == "PL")
        {
            if (tooLow) { hints.Add("Za malo!"); hints.Add("Wiecej!"); hints.Add("Podnies wartosc!"); hints.Add("Nie, liczba jest wieksza!"); hints.Add("Za niska liczba!"); }
            else { hints.Add("Za duzo!"); hints.Add("Mniej!"); hints.Add("Obniz wartosc!"); hints.Add("Nie, liczba jest nizsza!"); hints.Add("Zbyt wysoka liczba!"); }
        }
        else
        {
            if (tooLow) { hints.Add("Too low!"); hints.Add("More!"); hints.Add("Higher!"); hints.Add("No, the number is greater!"); hints.Add("Too low, try again!"); }
            else { hints.Add("Too big!"); hints.Add("Less!"); hints.Add("Lower!"); hints.Add("No, the number is lower!"); hints.Add("Too high, try again!"); }
        }

        return hints[rand.Next(hints.Count)];
    }
}
