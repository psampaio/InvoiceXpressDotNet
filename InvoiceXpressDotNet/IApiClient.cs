namespace InvoiceXpressDotNet
{
    public interface IApiClient
    {
        string AccountName { get; }
        string ApiKey { get; }
        string Send(string method, string url, int successCode, string data = null);
    }
}