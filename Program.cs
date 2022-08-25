namespace ValidationUsingRegex
{
    class Program
    {
        public static void Main(string[] args)
        {
            RegexValidation regexValidation = new RegexValidation();
            bool RegexResult1 = regexValidation.validateFirstName();
            Console.WriteLine("firstname"+ " "  +RegexResult1);
        }
    }
}
