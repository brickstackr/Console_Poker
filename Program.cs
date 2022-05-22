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

    }
}

