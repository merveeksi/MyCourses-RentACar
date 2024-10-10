using Microsoft.AspNetCore.Builder;


namespace Core.CrossCuttingConcerns.Exceptions.Extensions;

public static class ExceptionMiddlewareExtensions
{
    //Middleware'lerin eklenmesi için kullanılır
    public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
        =>app.UseMiddleware<ExceptionMiddleware>();
}