namespace VsBug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;

            PrintHorizontalLine();
            for (int i = 0; i < 12; i++)
            {
                Console.Write("|");
                for (int line = 0; line <= 30; line++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.WriteLine();
            }
            PrintHorizontalLine();
        }
        static void PrintHorizontalLine()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                System.Console.Write("-");
            Console.Write("+");
            Console.WriteLine();
        }

    }
}