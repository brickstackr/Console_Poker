namespace ConsolePoker 
{
    class InputValidation {
        public bool InputFileIsValid(string FileToCheck) 
        {
            bool IsValid;
            if (FileToCheck.All(x => char.IsLetterOrDigit(x) || char.IsWhiteSpace(x)))
                IsValid = true;
            else
                IsValid = false;
            return IsValid;
        }
    }
}