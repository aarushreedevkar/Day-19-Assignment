using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidationUsingRegex
{
    public  class RegexValidation
    {
      //  public static string FIRST_NAME_REGEX = "^[A-Z]{1}[A-Za-z]{3}$";
       
       
      // public static string LAST_NAME_REGEX = "^[A-Z]{1}[A-Za-z}{3}$";

       
       // public static string EMAIL_REGEX = "^[a-z0-9+_.-]+@[A-Z0-9.-]+$";


       // public static string MOBILENUMBER_REGEX = "^[+91]{1}[6-9]{1}[0-9]{9}$";


       public static string PASSWORD_REGEX = "^[[A_Z]{1}[A_Za-z][0-9]{1}[./@/%]{1]]{8}$";


        //  public  bool validateFirstName()
        //{
        //    return Regex.IsMatch("Teju", FIRST_NAME_REGEX);
        //}

        //public bool validateLastName()
        //{
        //    return Regex.IsMatch("Mate", LAST_NAME_REGEX);
        //}

        // public bool validateEmail()
        //{
        //    return Regex.IsMatch("jyotihage10@gmail.com", EMAIL_REGEX);
        //}

        //public bool validateMobileNumber()
        //{
        //    return Regex.IsMatch("+919673683178", MOBILENUMBER_REGEX);

        //}

        public bool validatePassword()
        {
            return Regex.IsMatch("Jyoti1@dh", PASSWORD_REGEX);

        }

    }

}
