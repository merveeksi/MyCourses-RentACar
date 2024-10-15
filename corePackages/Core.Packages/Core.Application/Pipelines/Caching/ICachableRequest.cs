namespace Core.Application.Pipelines.Caching;

public interface ICachableRequest
{
    string CacheKey { get; }
    bool BypassCache { get; }  //cache kullanmak istemiyorsa
    string? CacheGroupKey { get; } //gruplama yapmak için
    TimeSpan? SlidingExpiration { get; } //ne kadar duracak

}