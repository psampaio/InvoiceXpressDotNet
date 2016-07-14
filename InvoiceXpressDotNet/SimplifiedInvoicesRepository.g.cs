// Connector API InvoiceXpressDotNet developed by EventKey,Lda http://www.eventkey.pt
using System;
using System.Net;

namespace InvoiceXpressDotNet
{
		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices">SimplifiedInvoices</a> module
		/// </summary>
		public class SimplifiedInvoicesRepository
		{
			private readonly IApiClient apiClient;

			public SimplifiedInvoicesRepository(IApiClient apiClient)
			{
				this.apiClient = apiClient;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/create">SimplifiedInvoices Create</a> Method
			/// </summary>
			public SimplifiedInvoiceDto Create(SimplifiedInvoiceDto inputData)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/simplified_invoices.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName);
				var result = apiClient.Post(url, 201, inputData.XmlSerializeToString());
				return result.DeserializeXml<SimplifiedInvoiceDto>();
 			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/get">SimplifiedInvoices Get</a> Method
			/// </summary>
			public SimplifiedInvoiceDto Get(string simplifiedInvoiceId)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/simplified_invoices/{2}.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, simplifiedInvoiceId);
				var result = apiClient.Get(url, 200);
				return result.DeserializeXml<SimplifiedInvoiceDto>();
 			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/update">SimplifiedInvoices Update</a> Method
			/// </summary>
			public void Update(string simplifiedInvoiceId, SimplifiedInvoiceDto inputData)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/simplified_invoices/{2}.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, simplifiedInvoiceId);
				var result = apiClient.Put(url, 200, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/list">SimplifiedInvoices List</a> Method
			/// </summary>
			public SimplifiedInvoicesDto List(int? page, int? perPage)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/simplified_invoices.xml?api_key={0}&page={2}&per_page={3}", apiClient.ApiKey, apiClient.AccountName, page, perPage);
				var result = apiClient.Get(url, 200);
				return result.DeserializeXml<SimplifiedInvoicesDto>();
 			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/change-state">SimplifiedInvoices ChangeState</a> Method
			/// </summary>
			public void ChangeState(string simplifiedInvoiceId, SimplifiedInvoiceChangeStateDto inputData)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/simplified_invoices/{2}/change-state.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, simplifiedInvoiceId);
				var result = apiClient.Put(url, 200, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/change-state">SimplifiedInvoices EmailInvoice</a> Method
			/// </summary>
			public void EmailInvoice(string simplifiedInvoiceId, EmailMessageDto inputData)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/simplified_invoices/{2}/email-document.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, simplifiedInvoiceId);
				var result = apiClient.Put(url, 200, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/documents-pdf">SimplifiedInvoices Pdf</a> Method
			/// </summary>
			public PdfOutputDto Pdf(string simplifiedInvoiceId)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/api/pdf/{2}.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, simplifiedInvoiceId);
				var result = apiClient.Get(url, 200);
				return result.DeserializeXml<PdfOutputDto>();
 			}

}
}