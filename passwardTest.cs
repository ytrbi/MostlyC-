using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {

  // 1. define all the standards for a pasword
        int minLength = 8; // number the minimum length of password
        string lowercase = "abcdefghijklmnopqrstuvwxyz"; // string with all lowercase letters
        string uppercase = lowercase.ToUpper() ; // string with all uppercase letters
        string digits = "1234567890"; // a string with all 10 digits
        string specialChars = "!@#$%^&*()_+-=|\/?,~"; // a string made of special characters

// 2. Capture input from the user
        Console.WriteLine("Enter a Password: ");
        string pass = Console.ReadLine();

// 3. Test
        int score = 0 ; // one point for each standard satisfied
        score += (pass.Length >= minLength) ? 1 : (Console.WriteLine("Password should be longer"), 0);
        score += (Tools.Contains(pass, uppercase)) ? 1 : (Console.WriteLine("Password should include uppercase characters"), 0);
        score += (Tools.Contains(pass, lowercase)) ? 1 : (Console.WriteLine("Password should include lowercase characters"), 0);
        score += (Tools.Contains(pass, digits)) ? 1 : (Console.WriteLine("Password should include digits"), 0);
        score += (Tools.Contains(pass, specialChars)) ? 1 : (Console.WriteLine("Password should include special characters"), 0);
// 4. Tell the user
        switch(score) {
          case 5: 
            Console.WriteLine("the password is extremely strong");
          case 4:
            Console.WriteLine("the password is extremely strong");
            break;
          case 3:
            Console.WriteLine("the password is strong");
            break;
          case 2:
            Console.WriteLine("the password is medium");
            break;
          case 1: 
            Console.WriteLine("the password is weak");
            break;
          default:
            Console.WriteLine("the password doesn’t meet any of the standards");
            break;
        }
    }
  }

}
