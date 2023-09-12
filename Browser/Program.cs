public class Program
{
    public static void Main()
    {
        Browser browser = new Browser();

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Valige valik:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Minge uuele lehele");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("2. Tagasi");
            Console.WriteLine("3. Edasi");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("4. Näita praegune lehekülg");
            Console.WriteLine("5. Näita külstusajaloo");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("6. Add bookmark");
            Console.WriteLine("7. Näita järjehoidjaid");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("8. Kustuta järjehoidjaid ja külstusajaloo");
            Console.WriteLine("9. Lõpeta");
            Console.ResetColor();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Sisestage URL: ");
                    Console.ResetColor();
                    string url = Console.ReadLine();
                    browser.GoTo(url);
                    break;
                case "2":
                    browser.Back();
                    break;
                case "3":
                    browser.Forward();
                    break;
                case "4":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Käesolev lehekülg: " + browser.Current());
                    Console.ResetColor();
                    break;
                case "5":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Külastusajaloo: " + string.Join(", ", browser.History()));
                    Console.ResetColor();
                    break;
                case "6":
                    browser.AddBookmark();
                    break;
                case "7":
                    browser.ViewBookmarks();
                    break;
                case "8":
                    browser.RemoveHistory();
                    break;
                case "9":
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vale valik. Palun proovi uuesti.");
                    Console.ResetColor();
                    break;
            }

            // Пауза перед очисткой консоли
            Console.WriteLine("Jätkamiseks vajutage sisestusklahvi...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}