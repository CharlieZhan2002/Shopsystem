using System.Text.RegularExpressions;

namespace Shop_system.Helpers
{
    public static class EmailValidator
    {
        private static readonly string EmailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        public static bool IsValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            return Regex.IsMatch(email, EmailPattern);
        }
    }
}

