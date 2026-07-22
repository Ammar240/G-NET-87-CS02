using System.Globalization;
using System.Runtime.Serialization.Json;

namespace session_03_Assingment;

internal class Program
{
    static void Main(string[] args)
    {
        #region question 
        int pages = 464;
        Console.WriteLine(pages > 300 ? "Long Book" : "Short Book");
        Console.WriteLine("==================");
        #endregion

        #region queston 2
        bool isAvailable = true;
        if (pages > 300 && isAvailable)
            Console.WriteLine("You can borrow this book");
        Console.WriteLine("==================");

        #endregion

        #region question 3
        string title = "Refactoring";
        switch (title)
        {
            case "Clean code":
            case "Nice pick!":
            case "Refactoring":
                Console.WriteLine("Great choice");
                break;
            default:
                Console.WriteLine("Never heard of it");
                break;
        }

        Console.WriteLine("==================");
        #endregion

        #region question 4
        string[] books = { "Refactoring", "Clean code", "The Pragmatic Programmer" };
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {books[i]}");
        }

        Console.WriteLine("==================");
        #endregion

        #region question 5
        int count = 0;
        while (count < books.Length)
        {
            Console.WriteLine($"{count + 1}. {books[count]}");
            count++;
        }

        Console.WriteLine("==================");
        #endregion

        #region question 6
        int count2 = 0;
        do
        {
            Console.WriteLine("Checking book...");
            count2++;
        } while (count2 < 3);

        Console.WriteLine("==================");
        #endregion

        #region question 7
        int j = 1;
        foreach (string book in books)
        {
            Console.WriteLine($"{j}. {book}");
            j++;
        }

        Console.WriteLine("==================");
        #endregion

        #region question 8
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {books[i]}");
            if (books[i].Equals("Refactoring"))
                break;
        }

        Console.WriteLine("==================");
        #endregion

        #region question 9

        Console.WriteLine("==================");
        #endregion

    }
}
