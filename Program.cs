namespace ConsolePoker
{
    class ConsolePrompts
{
    static void Main()
    {
        //Read a list of poker player names from an input file. 
        //  The path to the input file should be a command line
        //  parameter to the console application.  
       
        Console.WriteLine("Welcome to virtual poker");
        Console.WriteLine("Enter an input file in txt format");
        string InputFile = Console.ReadLine();
        Console.WriteLine("Reading players from {0}", InputFile);
        
        //The path to the output file should also be a command line parameter.
        //If there is no output file specified, just output to the console.

        bool ConsoleOutput = true;
        char selection = ' ';
        {
            Console.WriteLine("Output to console? Yes (Y) or No (N)");
            selection = Convert.ToChar(Console.ReadLine().ToUpper());
                if (selection.Equals('Y'))
                    ConsoleOutput = true;
                else if (selection.Equals('N'))
                    ConsoleOutput = false;
                else 
                    Console.WriteLine("Invalid Selection.Try again");

        }
        if (ConsoleOutput == false)
            {
                Console.WriteLine("Enter an output file in txt format");
                string OutputFile = Console.ReadLine();
                Console.WriteLine("View {0} for game results", OutputFile);
            }
        else 
            {
                Console.WriteLine("Validating Input");
            }
        // Each poker player name is only valid if it contains alphanumeric characters (spaces are also allowed). 
        //  Any other characters or symbols found on the input line makes the name invalid
        string[] InputArray = System.IO.File.ReadAllLines(InputFile);
        // table size- increment up for each valid input
        int table = 0;
        var PokerTable = new List<string>();
        foreach (string line in InputArray)
        {
            // Validate input
            if(InputValidation.InputIsValid(line))
                {
              //  new InputValidation.Player(line);
                PokerTable.Add(line);
                Console.WriteLine(line + " is joining the table");
                table++;
                }
            else
                Console.WriteLine("invalid input");
        }
        if (table > 0)
            Console.WriteLine("The game is ready to begin");
        else
            Console.WriteLine("There is no one to join the poker table");
        //Console.WriteLine("testing deal cards");

        //    string v = CardHandling.DealCards();
        //    string CardTest = v;
        foreach(string player in PokerTable)
        {
            Console.WriteLine("Player hand for: " + player);
            Stack<string> theStack = new Stack<string>();
            for (int number = 0; number <= 4; number++)
                    {
                        string v = CardHandling.DealCards();
                        string CardTest = v;
                        theStack.Push(v);
                        Console.WriteLine(v);
                    }

        }
        //Console.WriteLine(CardTest);
    }}}