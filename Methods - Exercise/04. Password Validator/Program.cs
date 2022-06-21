using System;
using System.Diagnostics;

namespace _04._Password_Validator
{
  
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();


            bool IsEnoughLenght = LenghtPassword(password);
            bool OnlyLettersDigit = LetterDigit(password);
            bool TwoDigits = TwoDigit(password);

            if (!IsEnoughLenght)
            {
                Console.WriteLine($"Password must be between 6 and 10 characters");
            }
            if (!OnlyLettersDigit)
            {
                Console.WriteLine($"Password must consist only of letters and digits");
            }
            if (!TwoDigits)
            {
                Console.WriteLine($"Password must have at least 2 digits");
            }

            if (IsEnoughLenght && OnlyLettersDigit && TwoDigits)
            {
                Console.WriteLine($"Password is valid");
            }
        }


        private static bool LetterDigit(string password)
        {
            bool checker = true;
            foreach (char checkers in password)
            {
                checker = char.IsLetterOrDigit(checkers);
                if (!checker)
                {
                    return false;
                }
            }
            return checker;
        }

        private static bool TwoDigit(string password)
        {
            bool twoDigit = true;
            int count = 0;
            foreach (char item in password)
            {
                if (char.IsDigit(item))
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                twoDigit = true;
            }
            else
            {
                twoDigit = false;
            }
            return twoDigit;
        }


        private static bool LenghtPassword(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
