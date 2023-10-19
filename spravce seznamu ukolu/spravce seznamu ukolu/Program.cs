using System;
using System.Collections.Generic;

class Program
{
    static List<string> tasks = new List<string>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Správce seznamu úkolů");
            Console.WriteLine("1. Přidat úkol");
            Console.WriteLine("2. Smazat úkol");
            Console.WriteLine("3. Zobrazit seznam úkolů");
            Console.WriteLine("4. Ukončit");
            Console.Write("Vyberte akci (1-4): ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        AddTask();
                        break;
                    case 2:
                        DeleteTask();
                        break;
                    case 3:
                        DisplayTasks();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Neplatná volba. Zadejte číslo od 1 do 4.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Neplatná volba. Zadejte číslo od 1 do 4.");
            }
        }
    }

    static void AddTask()
    {
        Console.Write("Název úkolu: ");
        string task = Console.ReadLine();
        tasks.Add(task);
        Console.WriteLine("Úkol byl přidán.");
    }

    static void DeleteTask()
    {
        Console.WriteLine("Seznam úkolů:");
        DisplayTasks();

        if (tasks.Count == 0)
        {
            Console.WriteLine("Seznam úkolů je prázdný.");
            return;
        }

        Console.Write("Zadejte číslo úkolu k smazání: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= tasks.Count)
        {
            tasks.RemoveAt(index - 1);
            Console.WriteLine("Úkol byl smazán.");
        }
        else
        {
            Console.WriteLine("Neplatná volba.");
        }
    }

    static void DisplayTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Seznam úkolů je prázdný.");
            return;
        }

        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
    }
}
