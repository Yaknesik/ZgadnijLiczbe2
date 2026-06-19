# Gra Konsolowa - Zgadnij Liczbę 2

## Wymagania:
Do skompilowania i uruchomienia gry wymagane jest środowisko **.NET SDK** (wersja 6.0 lub nowsza). Możesz je pobrać za darmo z [oficjalnej strony Microsoft](https://dotnet.microsoft.com/download).

## Jak uruchomić

### Opcja 1: Przez Terminal:

1. Otwórz terminal v folderze, w którym chcesz utworzyć grę.
2. Utwórz nowy projekt konsolowy poleceniem:
```bash
dotnet new console -n GuessTheNumber
```
3. Przejdź do nowo utworzonego katalogu:
```bash
cd GuessTheNumber
```
4. Usuń automatycznie wygenerowany plik `Program.cs`.
5. Skopiuj i umieść w tym folderze **wszystkie pliki `.cs`** z tego projektu (`Program.cs`, `Game.cs`, `StandardGame.cs`, `GamePlus.cs`, `Score.cs`, `Settings.cs`, `HallOfFame.cs`, `Translations.cs`).
6. Uruchom grę za pomocą komendy:
```bash
dotnet run
```
### Opcja 2: Przez Visual Studio:
1. Uruchom Visual Studio i wybierz **Utwórz nowy projekt** (Create a new project).
2. Wybierz szablon **Aplikacja konsolowa** (Console App) dla języka C# i przejdź dalej.
3. Nazwij projekt (np. `GuessTheNumber`) i kliknij *Utwórz*.
4. W oknie *Eksploratora rozwiązań* (Solution Explorer) po prawej stronie kliknij prawym przyciskiem myszy na domyślny plik `Program.cs` i wybierz **Usuń** (Delete).
5. Przeciągnij i upuść wszystkie pliki `.cs` tego projektu do okna Eksploratora rozwiązań (lub kliknij prawym przyciskiem myszy na projekt -> *Dodaj* -> *Istniejący element* i wybierz pliki).
6. Uruchom grę, klikając zielony przycisk **Start** na górnym pasku narzędzi lub wciskając klawisz `F5`.