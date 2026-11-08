string again = "a";

// Řídící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A"
// Jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a" )
{
    // Vymazání konzole
    Console.Clear();

    // Hlavička programu
    Console.WriteLine("*************************************");
    Console.WriteLine("******** Ciferný součet - text ******");
    Console.WriteLine("*************************************");
    Console.WriteLine("*********** Jakub Konečný ***********");
    Console.WriteLine("*************************************");
    Console.WriteLine();
    Console.WriteLine();

    // Načtení hodnoty
    Console.Write("Zadejte celé číslo: ");
    int number;
    while(!int.TryParse(Console.ReadLine(), out number)) {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }

    // Příprava pomocných proměnných pro výpočet
    int sum = 0;     // Neutrální hodnota pro sčítání je 0
    int soucin = 1;  // Neutrální hodnota pro násobení je 1

    // Převod čísla na text, znaménko nemá vliv na číslice
    string text = number.ToString().Replace("-", "");

    Console.WriteLine();
    Console.WriteLine("Průběh rozkladu čísla na číslice (zleva)");

    // Procházíme text znak po znaku
    foreach(char znak in text)
    {
        int digit = znak - '0';   // Odečtením znaku '0' získáme hodnotu číslice
        sum = sum + digit;
        soucin = soucin * digit;
        Console.WriteLine($"Získaná číslice: {digit}");
    }

    // Výpis výsledků
    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"Součet číslic čísla {number} je {sum}.");
    Console.WriteLine("=============================");
    Console.WriteLine($"Součin číslic čísla {number} je {soucin}.");
    Console.WriteLine("=============================");

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter.");
    Console.WriteLine("Jakoukoli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}
