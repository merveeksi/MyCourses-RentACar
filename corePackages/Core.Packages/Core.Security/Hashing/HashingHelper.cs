using System.Security.Cryptography;
using System.Text;


namespace Core.Security.Hashing;

public static class HashingHelper
{
    //oluştur
    public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using HMACSHA512 hmac = new();

        passwordSalt = hmac.Key;
        passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
    }

    //doğrula
    public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
    {
        using HMACSHA512 hmac = new(passwordSalt);

        byte[] computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

        return computedHash.SequenceEqual(passwordHash);
    }
}