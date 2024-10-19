using Microsoft.IdentityModel.Tokens;

namespace Core.Security.Encryption;

public static class SigningCredentialsHelper
{
    //imzaladığımız nesneyi döndürür
    public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey) => new(securityKey, SecurityAlgorithms.HmacSha512Signature);
}