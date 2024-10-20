using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Core.CrossCuttingConcerns.Exceptions.Extensions;

public static class ProblemDetailsExtensions
{
    public static string AsJson<TProblemDetail>(this TProblemDetail details) //"T" hangi isimde olursa olsun demek
        where TProblemDetail : ProblemDetails => JsonSerializer.Serialize(details);
}