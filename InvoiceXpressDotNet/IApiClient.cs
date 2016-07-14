namespace InvoiceXpressDotNet
{
    public interface IApiClient
    {
        string AccountName { get; }
        string ApiKey { get; }
        string Delete(string url, int successCode, string data = null);
        string Get(string url, int successCode, string data = null);
        string Post(string url, int successCode, string data = null);
        string Put(string url, int successCode, string data = null);
    }
}