using System;
using System.Text.RegularExpressions;

namespace TestUnit
{
    class RegexPattern
    {
        public static string Name(string name)
        {
            string regexPattern = "^[A-Za-z]+$";
            if (Regex.IsMatch(name, regexPattern))
            {
                return name;
            }
            else if (name == null)
            {
                return null;
            }
            return null;
        }

        internal static long PhoneNumber(long pNum)
        {
            string pattern = @"^([\d]+){10}$";
            Regex r = new Regex(pattern);
            if (r.IsMatch(""+pNum+""))
            {
                return pNum;
            }
            else
            {
                return 0;
            }
        }
        internal static string Email(string email)
        {
            string pattern = @"^[A-Za-z0-9.%]+@[A-Za-z]+\.[A-Za-z]+$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(email))
            {
                return email;
            }
            else
            {
                return null;
            }

        }
        internal static string Password(string password)
        {
            string pattern = @"^(?=^.{6,16}$)(?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?!.*\s).*$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(password))
            {
                return password;
            }
            else
            {
                return null;
            }
        }

        
    }
}
