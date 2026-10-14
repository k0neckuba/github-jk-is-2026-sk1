string again = "a";

// Řídící cyklus programu
// ToLower() --> převede na LowerCase 
// Jakýkoliv jiný bstup programu ukončí
while (again.ToLower() == "a")
{

    //dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine("Pokud chcete pokračovat v programu stiskněte klávesu A. Následně potvrďte klávesou ENTER.");
    again = Console.ReadLine() ?? "";
}