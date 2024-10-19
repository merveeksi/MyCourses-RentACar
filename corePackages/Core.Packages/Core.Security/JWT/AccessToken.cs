namespace Core.Security.JWT;

//Refresh Token ı veritabanında tutabiliriz fakat Access Token dotnet Identity tarafından yönetilecek

//Sisteme giriş için kullanılacak olan token
public class AccessToken
{
    public string Token { get; set; }
    public DateTime Expiration { get; set; }

    public AccessToken()
    {
        Token = string.Empty;
    }

    public AccessToken(string token, DateTime expiration)
    {
        Token = token;
        Expiration = expiration;
    }
}