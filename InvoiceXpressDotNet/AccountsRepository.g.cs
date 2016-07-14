// Connector API InvoiceXpressDotNet developed by EventKey,Lda http://www.eventkey.pt
using System;
using System.Net;

namespace InvoiceXpressDotNet
{
		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/AccountNames">Accounts</a> module
		/// </summary>
		public class AccountsRepository
		{
			private readonly IApiClient apiClient;

			public AccountsRepository(IApiClient apiClient)
			{
				this.apiClient = apiClient;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/accounts/create">Accounts Create</a> Method
			/// </summary>
			public AccountDto Create(AccountDto inputData)
			{
 				string url = string.Format("https://www.app.invoicexpress.com/api/accounts/create.xml?api_key={0}", apiClient.ApiKey);
				var result = apiClient.Send("POST", url, 201, inputData.XmlSerializeToString());
				return result.DeserializeXml<AccountDto>();
 			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/accounts/get">Accounts Get</a> Method
			/// </summary>
			public AccountDto Get(string accountId)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/api/AccountNames/{2}/get.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, accountId);
				var result = apiClient.Send("GET", url, 200);
				return result.DeserializeXml<AccountDto>();
 			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/accounts/stats">Accounts Stats</a> Method
			/// </summary>
			public AccountStatsDto Stats(string accountId)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/api/AccountNames/{2}/stats.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, accountId);
				var result = apiClient.Send("GET", url, 200);
				return result.DeserializeXml<AccountStatsDto>();
 			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/accounts/suspend">Accounts Suspend</a> Method
			/// </summary>
			public void Suspend(string accountId)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/api/AccountNames/{2}/suspend.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, accountId);
				var result = apiClient.Send("PUT", url, 200);
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/accounts/activate">Accounts Activate</a> Method
			/// </summary>
			public void Activate(string accountId)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/api/AccountNames/{2}/activate.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, accountId);
				var result = apiClient.Send("PUT", url, 200);
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/accounts/update">Accounts Update</a> Method
			/// </summary>
			public void Update(string accountId, AccountDto inputData)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/api/AccountNames/{2}/update.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, accountId);
				var result = apiClient.Send("PUT", url, 200, inputData.XmlSerializeToString());
			}

}
}