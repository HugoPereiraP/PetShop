using System.Text.RegularExpressions;

namespace PetShop.Helpers.Validation
{
    public static class EmailHelper
    {
        public static bool IsValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
