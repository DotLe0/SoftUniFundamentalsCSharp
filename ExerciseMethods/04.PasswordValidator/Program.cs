namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool valid = true;
            if (IsBetween6and10CharectersLong(password) == false)
            {
                valid = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (IsOnlyLettersOrDigits(password) == false)
            {
                valid = false;
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (IsWithAtLeast2Digits(password) == false)
            {
                valid = false;
                Console.WriteLine("Password must have at least 2 digits");
            }
            if(valid == true)
            {
                Console.WriteLine("Password is valid");
            }    
        }

        private static bool IsWithAtLeast2Digits(string? password)
        {
            int count = 0;
            List<char> chars = new List<char>(password);
            for (int i = 0; i < chars.Count; i++)
            {
                if (char.IsDigit(chars[i]))
                {
                    count++;
                    if (count == 2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool IsOnlyLettersOrDigits(string? password)
        {
            List<char> chars = new List<char>(password);
            for (int i = 0; i < chars.Count; i++)
            {
                if (char.IsLetterOrDigit(chars[i]))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsBetween6and10CharectersLong(string? password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            return false;
        }
    }
}