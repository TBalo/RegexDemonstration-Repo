using System;
using System.Text.RegularExpressions;

namespace RegexDemonstration
{
    public class RegexValidation
    {
        public static string NAME_REGEX = "^[A-Z]{1}[A-Za-z]{6,}$";
        public static string ID_REGEX = "^[-]{3}[a-zA-Z0-9]{1,5}[-]{3}$";
        public static string MOBILENUMBER_REGEX = "^[6-9]{1}[0-9]{9}$"; //has to start from number btw six to 9.
        public static string EMAIL_REGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([a-zA-Z]{2,3}){0,1}";
        public static string PASSWORD_REGEX = "^[a-zA-Z]{8,}";

        public bool validateFirstName()
        {
            return Regex.IsMatch("Manishi", NAME_REGEX);
        }

        public bool validateMobileNumber()
        {
            return Regex.IsMatch("6123456789", MOBILENUMBER_REGEX);
        }

        public bool validateEmail()
        {
            return Regex.IsMatch("tbalog426-tolu@gmail.com", EMAIL_REGEX);
        }

        public bool validatePassword()
        {
            return Regex.IsMatch("ismabsmy", PASSWORD_REGEX);
        }

        public bool validateID()
        {
            return Regex.IsMatch("---1234T---", ID_REGEX);
        }


        //content of readme.
//        This project is a demonstration of how regular expressions are being used - shortened as Regex.

//        Regex is a sequence of characters that specifies a search pattern in text.
//        Usually such patterns are used by string-searching algorithms for "find" or "find and replace" operations on strings, or for input validation.

//        The code validates that a set of given data is inputed in the exact format as defined by the business.
//It contains a method which validates a given Firstname, MobileNumber, Email, Password and an ID to return true or false if it was inputed in the format
//        defined in the code in kine with the business-specification.

        //Kindly ignore below
        //        using System;
        //using System.Text.RegularExpressions;

        //public class SimpleIdValidation
        //    {
        //        public static string ID_REGEX = "^[-]{3}[a-zA-Z0-9]{1,5}[-]{3}$";


        //        public static bool Validate(string id)
        //        {

        //            return Regex.IsMatch(id, ID_REGEX);

        //        }
        //    }
    }
}



