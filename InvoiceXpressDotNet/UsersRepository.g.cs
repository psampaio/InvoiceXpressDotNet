// Connector API InvoiceXpressDotNet developed by EventKey,Lda http://www.eventkey.pt
using System;
using System.Net;

namespace InvoiceXpressDotNet
{
		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/users">Users</a> module
		/// </summary>
		public class UsersRepository
		{
			private readonly IApiClient apiClient;

			public UsersRepository(IApiClient apiClient)
			{
				this.apiClient = apiClient;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/users/login">Users Login</a> Method
			/// </summary>
			public UserAccountDto Login(CredentialsDto inputData)
			{
 				string url = string.Format("https://www.app.invoicexpress.com/login.xml");
				var result = apiClient.Post(url, 200, inputData.XmlSerializeToString());
				return result.DeserializeXml<UserAccountDto>();
 			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/users/accounts">Users Accounts</a> Method
			/// </summary>
			public UserAccountsDto Accounts()
			{
 				string url = string.Format("https://www.app.invoicexpress.com/users/accounts.xml?api_key?api_key={apiKey}");
				var result = apiClient.Get(url, 200);
				return result.DeserializeXml<UserAccountsDto>();
 			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/users/change-account">Users ChangeAccount</a> Method
			/// </summary>
			public void ChangeAccount(ChangeAccountToDto inputData)
			{
 				string url = string.Format("https://{accountName}.app.invoicexpress.com/users/change_AccountName.xml?api_key?api_key={apiKey}");
				var result = apiClient.Put(url, 200, inputData.XmlSerializeToString());
			}

}
}