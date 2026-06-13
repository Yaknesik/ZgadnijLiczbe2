using System;
using System.Collections.Generic;
using System.IO;

public class HallOfFame
{
    private string filePath = "wyniki.txt";
    private List<Score> scores = new List<Score>();

    public bool HasScores()
    {
        LoadScores();
        return scores.Count > 0;
    }

    public void LoadScores()
    {
        scores.Clear();
        if (!File.Exists(filePath)) return;

        StreamReader sr = new StreamReader(filePath);
        string line;
        while ((line = sr.ReadLine()) != null)
        {
            string[] parts = line.Split(',');
            if (parts.Length == 5)
            {
                int diff = int.Parse(parts[0]);
                int tries = int.Parse(parts[1]);
                string name = parts[2];
                int time = int.Parse(parts[3]);
                bool ngPlus = bool.Parse(parts[4]);

                scores.Add(new Score(diff, tries, name, time, ngPlus));
            }
        }
        sr.Close();
        SortScores();
    }

    public void SaveScore(Score score)
    {
        StreamWriter sw = new StreamWriter(filePath, true);
        sw.WriteLine(score.Difficulty + "," + score.Tries + "," + score.Name + "," + score.DurationSeconds + "," + score.IsNewGamePlus);
        sw.Close();
        LoadScores();
    }

    public void ClearAll()
    {
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }
        scores.Clear();
    }

    private void SortScores()
    {
        for (int i = 0; i < scores.Count - 1; i++)
        {
            for (int j = 0; j < scores.Count - i - 1; j++)
            {
                bool swapNeeded = false;

                if (scores[j].Tries > scores[j + 1].Tries)
                {
                    swapNeeded = true;
                }
                else if (scores[j].Tries == scores[j + 1].Tries)
                {
                    if (scores[j].DurationSeconds > scores[j + 1].DurationSeconds)
                    {
                        swapNeeded = true;
                    }
                }

                if (swapNeeded)
                {
                    Score temp = scores[j];
                    scores[j] = scores[j + 1];
                    scores[j + 1] = temp;
                }
            }
        }
    }

    public void DisplayMenu()
    {
        LoadScores();
        int currentDiff = 1;

        while (true)
        {
            Console.Clear();
            Console.WriteLine(Translation.Get("HoFTitle"));
            string diffName = currentDiff == 1 ? "EASY" : currentDiff == 2 ? "MEDIUM" : "HARD";
            Console.WriteLine("--- LEVEL: " + diffName + " ---");

            List<Score> filtered = new List<Score>();
            for (int i = 0; i < scores.Count; i++)
            {
                if (scores[i].Difficulty == currentDiff)
                {
                    filtered.Add(scores[i]);
                }
            }

            if (filtered.Count == 0)
            {
                Console.WriteLine(Translation.Get("HoFEmpty"));
            }
            else
            {
                int limit = filtered.Count;
                if (limit > 5) limit = 5;

                for (int i = 0; i < limit; i++)
                {
                    string prefix = filtered[i].IsNewGamePlus ? "[NG+] " : "";
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine((i + 1) + ". " + prefix + filtered[i].Name + " | Tries: " + filtered[i].Tries + " | Time: " + filtered[i].DurationSeconds + "s");
                    Console.ResetColor();
                }
            }

            Console.WriteLine("\n[1-3] Switch Diff | [4] Main Menu");
            Console.Write(Translation.Get("SelectOption"));
            
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice >= 1 && choice <= 3) currentDiff = choice;
                else if (choice == 4) break;
            }
        }
    }
}