// Connector API InvoiceXpressDotNet developed by EventKey,Lda http://www.eventkey.pt
using System;
using System.Net;

namespace InvoiceXpressDotNet
{
		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices">Invoices</a> module
		/// </summary>
		public class InvoicesRepository
		{
			private readonly IApiClient apiClient;

			public InvoicesRepository(IApiClient apiClient)
			{
				this.apiClient = apiClient;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/create">Invoices Create</a> Method
			/// </summary>
			public InvoiceDto Create(InvoiceDto inputData)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/invoices.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName);
				var result = apiClient.Send("POST", url, 201, inputData.XmlSerializeToString());
				return result.DeserializeXml<InvoiceDto>();
 			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/get">Invoices Get</a> Method
			/// </summary>
			public InvoiceDto Get(int invoiceId)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/invoices/{2}.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, invoiceId);
				var result = apiClient.Send("GET", url, 200);
				return result.DeserializeXml<InvoiceDto>();
 			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/update">Invoices Update</a> Method
			/// </summary>
			public void Update(int invoiceId, InvoiceDto inputData)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/invoices/{2}.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, invoiceId);
				var result = apiClient.Send("PUT", url, 200, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/list">Invoices List</a> Method
			/// </summary>
			public InvoicesDto List()
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/invoices.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName);
				var result = apiClient.Send("GET", url, 200);
				return result.DeserializeXml<InvoicesDto>();
 			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/change-state">Invoices ChangeState</a> Method
			/// </summary>
			public InvoiceChangeStateDto ChangeState(int invoiceId, InvoiceChangeStateDto inputData)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/invoice/{2}/change-state.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, invoiceId);
				var result = apiClient.Send("PUT", url, 200, inputData.XmlSerializeToString());
				return result.DeserializeXml<InvoiceChangeStateDto>();
 			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/email-invoice">Invoices EmailInvoice</a> Method
			/// </summary>
			public void EmailInvoice(int invoiceId, EmailMessageDto inputData)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/invoices/{2}/email-document.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, invoiceId);
				var result = apiClient.Send("PUT", url, 200, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/related-documents">Invoices RelatedDocuments</a> Method
			/// </summary>
			public InvoicesDto RelatedDocuments(int invoiceId)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/document/{2}/related_documents.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, invoiceId);
				var result = apiClient.Send("GET", url, 200);
				return result.DeserializeXml<InvoicesDto>();
 			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/documents-pdf">Invoices Pdf</a> Method
			/// </summary>
			public PdfOutputDto Pdf(int invoiceId)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/api/pdf/{2}.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, invoiceId);
				var result = apiClient.Send("GET", url, 200);
				return result.DeserializeXml<PdfOutputDto>();
 			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/archive">Invoices Archive</a> Method
			/// </summary>
			public void Archive(string documentType, int documentId)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/{2}/{3}/archive.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, documentType, documentId);
				var result = apiClient.Send("PUT", url, 200);
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/unarchive">Invoices Unarchive</a> Method
			/// </summary>
			public void Unarchive(string documentType, int documentId)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/{2}/{3}/unarchive.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, documentType, documentId);
				var result = apiClient.Send("PUT", url, 200);
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/partial-payment">Invoices PartialPayment</a> Method
			/// </summary>
			public PartialPaymentReceiptDto PartialPayment(int documentId, PartialPaymentDto inputData)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/documents/{2}/partial_payments.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, documentId);
				var result = apiClient.Send("POST", url, 201, inputData.XmlSerializeToString());
				return result.DeserializeXml<PartialPaymentReceiptDto>();
 			}

}
}