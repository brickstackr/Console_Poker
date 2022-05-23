namespace ConsolePoker 
{
    class InputValidation {
        public static bool InputIsValid(string LineToCheck) 
        {
            bool IsValid;
            if (LineToCheck.All(x => char.IsLetterOrDigit(x) || char.IsWhiteSpace(x)))
                IsValid = true;
            else
                IsValid = false;
            return IsValid;
        }
    public class Player
{
    // Constructor that takes no arguments:
    public Player()
    {
        Name = "unknown";
    }

    // Constructor that takes one argument:
    public Player(string name)
    {
        Name = name;
    }

    // Auto-implemented readonly property:
    public string Name { get; }

    // Method that overrides the base class (System.Object) implementation.
    public override string ToString()
    {
        return Name;
    }
}
    }
}