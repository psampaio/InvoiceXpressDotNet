// Connector API InvoiceXpressDotNet developed by EventKey,Lda http://www.eventkey.pt
using System;
using System.Net;

namespace InvoiceXpressDotNet
{
	/// <summary>
	/// InvoiceXpress <a href="https://invoicexpress.com/api/clients">Clients</a> module
	/// </summary>
	public class ClientsRepository
	{
		private readonly IApiClient apiClient;

		public ClientsRepository(IApiClient apiClient)
		{
			this.apiClient = apiClient;
		}

		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/create">Clients Create</a> Method
		/// </summary>
		public ClientDto Create(ClientDto inputData)
		{
 			string url = string.Format("https://{1}.app.invoicexpress.com/clients.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName);
			var result = apiClient.Send("POST", url, 201, inputData.XmlSerializeToString());
			return result.DeserializeXml<ClientDto>();
 		}

		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/get">Clients Get</a> Method
		/// </summary>
		public ClientDto Get(string clientId)
		{
 			string url = string.Format("https://{1}.app.invoicexpress.com/clients/{2}.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, clientId);
			var result = apiClient.Send("GET", url, 200);
			return result.DeserializeXml<ClientDto>();
 		}

		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/update">Clients Update</a> Method
		/// </summary>
		public void Update(string clientId, ClientDto inputData)
		{
 			string url = string.Format("https://{1}.app.invoicexpress.com/clients/{2}.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, clientId);
			apiClient.Send("PUT", url, 200, inputData.XmlSerializeToString());
		}

		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/list">Clients List</a> Method
		/// </summary>
		public ClientsDto List(int? page, int? perPage)
		{
 			string url = string.Format("https://{1}.app.invoicexpress.com/clients.xml?api_key={0}&page={2}&per_page={3}", apiClient.ApiKey, apiClient.AccountName, page, perPage);
			var result = apiClient.Send("GET", url, 200);
			return result.DeserializeXml<ClientsDto>();
 		}

		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/list-invoice">Clients Invoices</a> Method
		/// </summary>
		public InvoicesDto Invoices(string clientId, int? page, int? perPage)
		{
 			string url = string.Format("https://{1}.app.invoicexpress.com/clients/{2}/invoices.xml?api_key={0}&page={3}&per_page={4}", apiClient.ApiKey, apiClient.AccountName, clientId, page, perPage);
			var result = apiClient.Send("GET", url, 200);
			return result.DeserializeXml<InvoicesDto>();
 		}

		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/find-by-name">Clients FindByName</a> Method
		/// </summary>
		public ClientDto FindByName(string clientName)
		{
 			string url = string.Format("https://{1}.app.invoicexpress.com/clients/find-by-name.xml?api_key={0}&client_name={2}", apiClient.ApiKey, apiClient.AccountName, clientName);
			var result = apiClient.Send("GET", url, 200);
			return result.DeserializeXml<ClientDto>();
 		}

		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/find-by-code">Clients FindByCode</a> Method
		/// </summary>
		public ClientDto FindByCode(string clientCode)
		{
 			string url = string.Format("https://{1}.app.invoicexpress.com/clients/find-by-code.xml?api_key={0}&client_code={2}", apiClient.ApiKey, apiClient.AccountName, clientCode);
			var result = apiClient.Send("GET", url, 200);
			return result.DeserializeXml<ClientDto>();
 		}
	}
}