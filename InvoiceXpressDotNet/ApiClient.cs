using System;
using System.IO;
using System.Net;
using System.Text;

namespace InvoiceXpressDotNet
{
    public class ApiClient : IApiClient
    {
        private const string ContentType = "application/xml; charset=utf-8";

        public ApiClient(string accountName, string apiKey)
        {
            AccountName = accountName;
            ApiKey = apiKey;
        }

        public string AccountName { get; }
        public string ApiKey { get; }

        public string Send(string method, string url, int successCode, string data)
        {
            var request = (HttpWebRequest) WebRequest.Create(string.Format(url, AccountName, ApiKey));
            request.Method = method;
            if (!string.IsNullOrWhiteSpace(data))
            {
                request.ContentType = ContentType;

                var dataBytes = Encoding.UTF8.GetBytes(data);
                request.ContentLength = dataBytes.Length;

                var requestStream = request.GetRequestStream();
                requestStream.Write(dataBytes, 0, dataBytes.Length);
                requestStream.Close();
            }

            string responseStr = null;
            HttpStatusCode responseCode;

            try
            {
                using (var response = (HttpWebResponse) request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    responseCode = response.StatusCode;
                    if (stream != null) responseStr = new StreamReader(stream).ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                using (var exResponse = (HttpWebResponse) ex.Response)
                using (var exStream = exResponse.GetResponseStream())
                {
                    responseCode = exResponse.StatusCode;
                    if (exStream != null) responseStr = new StreamReader(exStream).ReadToEnd();
                }
            }

            if ((int) responseCode != successCode)
            {
                throw new Exception($"Invalid HttpStatusCode. Expected {(HttpStatusCode) successCode}",
                    new Exception(responseStr));
            }

            return responseStr;
        }
    }
}