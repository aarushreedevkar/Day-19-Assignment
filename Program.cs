namespace ValidationUsingRegex
{
    class Program
    {
        public static void Main(string[] args)
        {
            RegexValidation regexValidation = new RegexValidation();
            //  bool RegexResult1 = regexValidation.validateFirstName();
            // Console.WriteLine("firstname"+ " "  +RegexResult1);

           // bool RegexResult2 = regexValidation.validateLastName();
           // Console.WriteLine("lastname"+ "  "    +RegexResult2);

           // bool RegexResult3 = regexValidation.validateEmail();
           // Console.WriteLine("Email" + "  " + RegexResult3);

            bool RegexResult4 = regexValidation.validateMobileNumber();
            Console.WriteLine("MobileNumber" + "  " + RegexResult4);

        }
    }
}
