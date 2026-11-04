string again = "a";

// Řídící cyklus programu
// ToLower() --> převede na LowerCase 
// Jakýkoliv jiný bstup programu ukončí
while (again.ToLower() == "a")
{

    Console.Clear();

    // Hlavička programu
    Console.WriteLine("************************************************************");
    Console.WriteLine("************************Název programu**************************");
    Console.WriteLine("************************************************************");
    Console.WriteLine("***********************Jakub Konečný************************");
    Console.WriteLine("************************************************************");

    //Vstup počáteční hodnoty - špatně
    //Console.Write("Zadejte PRVNÍ číslo číselné řady (kladné celé číslo): ");
    //int first = int.Parse(Console.ReadLine());


    //Načtení hodnoty
    Console.Write("Zadejte číslo číselné řady (kladné celé číslo): ");
    int aaa;
    while (!int.TryParse(Console.ReadLine(), out aaa))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo řady znovu: ");
    }
    
    
    Console.Write("Zadejte číslo číselné řady (kladné celé číslo): ");
    int bbb;
    while (!int.TryParse(Console.ReadLine(), out bbb))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo řady znovu: ");
    }


     //rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("===========================================");
    // Console.WriteLine($"První číslo : {first}");
    // Console.WriteLine($"Poslední poslední : {last}");
    // Console.WriteLine($"Diference (krok) : {step}");
    Console.WriteLine($"První číslo : " + first + " ;Poslední číslo : " + last + " ;Diference (krok) : " + step);
    Console.WriteLine("===========================================");
    Console.WriteLine();

    Console.WriteLine("Výpis číselné řady");
    if (first <= last)
    {
        int current = first;
        while (current <= last)
        {
            Console.WriteLine(current);
            current += step;
        }

    }
    else
    {
        Console.WriteLine("První číslo je věší než poslední");
        Console.WriteLine("Tento program umí vypsat vzestupnou řadu (od menšího k většímu)");
    }







    //dotaz směrem k uživateli na opakování
        Console.WriteLine();
    Console.Write("Pokud chcete pokračovat v programu stiskněte klávesu A. Následně potvrďte klávesou ENTER.: ");
    again = Console.ReadLine() ?? "";



   

}