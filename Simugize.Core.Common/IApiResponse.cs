namespace Simugize.Core.Common
{
    public interface IApiResponse<T>
    {
        string? ErrorMessage { get; }
        T? Results { get; }
        bool HasError { get; }
    }
}
