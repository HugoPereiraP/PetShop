using System.Security.Cryptography;
using System.Text;

namespace PetShop.Helpers.Security
{
    public static class PasswordHelper
    {
        public static string Hash(string senha)
        {
            using var sha = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(senha);
            var hash = sha.ComputeHash(bytes);
            return Convert.ToHexString(hash);
        }
    }
}
