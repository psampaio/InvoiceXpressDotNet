using System;
using System.Net;
namespace InvoicExpress.Net
{
	public static partial class InvoiceExpress
    {
		public static class Clients
		{
		        
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/clients/create">Clients Create</a> Method
			/// </summary>
			public static string Create(string apiKey, string accountName, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/clients.xml?api_key={0}", apiKey, accountName);
				var result = url.HttpPost(inputData);
				if((int)result.StatusCode != 201)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)201)
						,new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/clients/create">Clients Create</a> Method
			/// </summary>
			public static R.Clients.Create.client CreateTyped(string apiKey, string accountName, I.Clients.Create.client inputData)
			{
				return Create(apiKey, accountName, inputData.XmlSerializeToString()).DeserializeXml<R.Clients.Create.client>();
			}
			        
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/clients/get">Clients Get</a> Method
			/// </summary>
			public static string Get(string apiKey, string accountName, string clientId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/clients/{2}.xml?api_key={0}", apiKey, accountName, clientId);
				var result = url.HttpGet();
				if((int)result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						,new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/clients/get">Clients Get</a> Method
			/// </summary>
			public static R.Clients.Get.client GetTyped(string apiKey, string accountName, string clientId)
			{
				return Get(apiKey, accountName, clientId).DeserializeXml<R.Clients.Get.client>();
			}
			        
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/clients/update">Clients Update</a> Method
			/// </summary>
			public static string Update(string apiKey, string accountName, string clientId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/clients/{2}.xml?api_key={0}", apiKey, accountName, clientId);
				var result = url.HttpPut(inputData);
				if((int)result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						,new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/clients/update">Clients Update</a> Method
			/// </summary>
			public static void UpdateTyped(string apiKey, string accountName, string clientId, I.Clients.Update.client inputData)
			{
				Update(apiKey, accountName, clientId, inputData.XmlSerializeToString());
			}
			        
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/clients/list">Clients List</a> Method
			/// </summary>
			public static string List(string apiKey, string accountName, int page, int perPage)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/clients.xml?api_key={0}&page={2}&per_page={3}", apiKey, accountName, page, perPage);
				var result = url.HttpGet();
				if((int)result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						,new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/clients/list">Clients List</a> Method
			/// </summary>
			public static R.Clients.List.clients ListTyped(string apiKey, string accountName, int page, int perPage)
			{
				return List(apiKey, accountName, page, perPage).DeserializeXml<R.Clients.List.clients>();
			}
			        
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/clients/list-invoice">Clients Invoices</a> Method
			/// </summary>
			public static string Invoices(string apiKey, string accountName, string clientId, int page, int perPage, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/clients/{2}/invoices.xml?api_key={0}&page={3}&per_page={4}", apiKey, accountName, clientId, page, perPage);
				var result = url.HttpGet(inputData);
				if((int)result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						,new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/clients/list-invoice">Clients Invoices</a> Method
			/// </summary>
			public static R.Clients.Invoices.invoices InvoicesTyped(string apiKey, string accountName, string clientId, int page, int perPage, I.Clients.Invoices.filter inputData)
			{
				return Invoices(apiKey, accountName, clientId, page, perPage, inputData.XmlSerializeToString()).DeserializeXml<R.Clients.Invoices.invoices>();
			}
			        
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/clients/find-by-name">Clients FindByName</a> Method
			/// </summary>
			public static string FindByName(string apiKey, string accountName, string clientName)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/clients/find-by-name.xml?api_key={0}&client_name={2}", apiKey, accountName, clientName);
				var result = url.HttpGet();
				if((int)result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						,new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/clients/find-by-name">Clients FindByName</a> Method
			/// </summary>
			public static R.Clients.FindByName.client FindByNameTyped(string apiKey, string accountName, string clientName)
			{
				return FindByName(apiKey, accountName, clientName).DeserializeXml<R.Clients.FindByName.client>();
			}
			        
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/clients/find-by-code">Clients FindByCode</a> Method
			/// </summary>
			public static string FindByCode(string apiKey, string accountName, string clientCode)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/clients/find-by-code.xml?api_key={0}&client_code={2}", apiKey, accountName, clientCode);
				var result = url.HttpGet();
				if((int)result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						,new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/clients/find-by-code">Clients FindByCode</a> Method
			/// </summary>
			public static R.Clients.FindByCode.client FindByCodeTyped(string apiKey, string accountName, string clientCode)
			{
				return FindByCode(apiKey, accountName, clientCode).DeserializeXml<R.Clients.FindByCode.client>();
			}
				}
	}
}