string again = "a";

// Řídící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A"  
// Jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a" )
{
    // Vymazání konzole
    Console.Clear();
    
    // Hlavička programu
    Console.WriteLine("****************************************************************");
    Console.WriteLine("************ Vykreslování pravoúhlého trojúhelníku *************");
    Console.WriteLine("****************************************************************");
    Console.WriteLine("*************************** Jakub Konečný **********************");
    Console.WriteLine("****************************************************************");
    Console.WriteLine();
    Console.WriteLine();

    // Načtení první hodnoty 
    Console.Write("Zadejte výšku trojúhelníku (celé kladné číslo): ");
    int width;
    while(!int.TryParse(Console.ReadLine(), out width) || width <= 0) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste celé kladné číslo. Zadejte číslo znovu: ");
        Console.ResetColor();
    }


    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"Výška: {width};");
    Console.WriteLine("=============================");
    Console.WriteLine();
    Console.WriteLine();

    // Zde budeme pokračovat konkrétním algoritmem
    for (int i = 1; i <= width; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(" *");
        }
        Console.WriteLine();
    }

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stislněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}
