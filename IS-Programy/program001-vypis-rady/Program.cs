string again = "a";

// Řídící cyklus programu
// ToLower() --> převede na LowerCase 
// Jakýkoliv jiný bstup programu ukončí
while (again.ToLower() == "a")
{

    Console.Clear();

    // Hlavička programu
    Console.WriteLine("************************************************************");
    Console.WriteLine("************************Výpis řady**************************");
    Console.WriteLine("************************************************************");
    Console.WriteLine("***********************Jakub Konečný************************");
    Console.WriteLine("************************************************************");

    //Vstup počáteční hodnoty
    Console.Write("Zadejte PRVNÍ číslo číselné řady (kladné celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte PRVNÍ číslo řady znovu: ");   
    }


    //Vstup konečné hodnoty
    Console.Write("Zadejte POSLEDNÍ číslo číselné řady (kladné celé číslo): ");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte POSLEDNÍ číslo řady znovu: ");   
    }






    //Vstup hodnoty kroku
    Console.Write("Zadejte diferenci (kladné celé číslo): ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step) || step <=0 )
    {
        Console.Write("Nezadali jste celé číslo. Zadejte diferenci znovu: ");   
    }

    //dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pokud chcete pokračovat v programu stiskněte klávesu A. Následně potvrďte klávesou ENTER.: ");
    again = Console.ReadLine() ?? "";
}