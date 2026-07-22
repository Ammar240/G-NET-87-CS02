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

        Console.WriteLine("==================");
        #endregion
        #region question 5

        Console.WriteLine("==================");
        #endregion

        #region question 6

        Console.WriteLine("==================");
        #endregion

        #region question 7

        Console.WriteLine("==================");
        #endregion

        #region question 8

        Console.WriteLine("==================");
        #endregion

        #region question 9

        Console.WriteLine("==================");
        #endregion

    }
}
