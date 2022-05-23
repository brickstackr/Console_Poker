namespace ConsolePoker
{
    partial class ConsolePrompts
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
    }
    Card2 []Deck = new Card2 [52];
    Card2? t;
    int i, j, n=0;
    string [] v = new string[13] {"2","3","4","5","6","7","8","9","10","J","D","K","A"};
    string [] s = new string[4] {"h", "d", "c", "s"};
    
    Card2 []Player_1 = new Card2[2];
    Card2 []Player_2 = new Card2[2];
    Random rand = new Random();

    for(i = 0; i<4;i++)
        for(j = 0; j <13;j++)
            {
            Deck[n].Card2_Set(v[j],s[i]);
            n++;
             }
		
}