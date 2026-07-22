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

    }
}
