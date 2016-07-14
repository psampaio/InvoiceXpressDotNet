// Connector API InvoiceXpressDotNet developed by EventKey,Lda http://www.eventkey.pt
using System;
using System.Net;

namespace InvoiceXpressDotNet
{
		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/items/create">Items</a> module
		/// </summary>
		public class ItemsRepository
		{
			private readonly IApiClient apiClient;

			public ItemsRepository(IApiClient apiClient)
			{
				this.apiClient = apiClient;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/items/create">Items Create</a> Method
			/// </summary>
			public ItemDto Create(ItemDto inputData)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/items.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName);
				var result = apiClient.Post(url, 201, inputData.XmlSerializeToString());
				return result.DeserializeXml<ItemDto>();
 			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/items/get">Items Get</a> Method
			/// </summary>
			public ItemDto Get(string itemId)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/items/{2}.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, itemId);
				var result = apiClient.Get(url, 200);
				return result.DeserializeXml<ItemDto>();
 			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/items/update">Items Update</a> Method
			/// </summary>
			public void Update(string itemId, ItemDto inputData)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/clients/{clientId}.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, itemId);
				var result = apiClient.Put(url, 200, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/items/delete">Items Delete</a> Method
			/// </summary>
			public void Delete(string itemId)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/items/{2}.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, itemId);
				var result = apiClient.Delete(url, 200);
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/list">Items List</a> Method
			/// </summary>
			public ItemsDto List()
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/items.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName);
				var result = apiClient.Get(url, 200);
				return result.DeserializeXml<ItemsDto>();
 			}

}
}