// Connector API InvoiceXpressDotNet developed by EventKey,Lda http://www.eventkey.pt
using System;
using System.Net;

namespace InvoiceXpressDotNet
{
	/// <summary>
	/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/create">InvoiceReceipts</a> module
	/// </summary>
	public class InvoiceReceiptsRepository
	{
		private readonly IApiClient apiClient;

		public InvoiceReceiptsRepository(IApiClient apiClient)
		{
			this.apiClient = apiClient;
		}

		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/create">InvoiceReceipts Create</a> Method
		/// </summary>
		public InvoiceReceiptDto Create(InvoiceReceiptDto inputData)
		{
 			string url = string.Format("https://{1}.app.invoicexpress.com/invoice_receipts.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName);
			var result = apiClient.Send("POST", url, 201, inputData.XmlSerializeToString());
			return result.DeserializeXml<InvoiceReceiptDto>();
 		}

		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/get">InvoiceReceipts Get</a> Method
		/// </summary>
		public InvoiceReceiptDto Get(int invoiceReceiptId)
		{
 			string url = string.Format("https://{1}.app.invoicexpress.com/invoice_receipts/{2}.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, invoiceReceiptId);
			var result = apiClient.Send("GET", url, 200);
			return result.DeserializeXml<InvoiceReceiptDto>();
 		}

		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/update">InvoiceReceipts Update</a> Method
		/// </summary>
		public void Update(int invoiceReceiptId, InvoiceReceiptDto inputData)
		{
 			string url = string.Format("https://{1}.app.invoicexpress.com/invoice_receipts/{2}.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, invoiceReceiptId);
			apiClient.Send("PUT", url, 200, inputData.XmlSerializeToString());
		}

		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/list">InvoiceReceipts List</a> Method
		/// </summary>
		public InvoiceReceiptsDto List()
		{
 			string url = string.Format("https://{1}.app.invoicexpress.com/invoice_receipts.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName);
			var result = apiClient.Send("GET", url, 200);
			return result.DeserializeXml<InvoiceReceiptsDto>();
 		}

		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/change-state">InvoiceReceipts ChangeState</a> Method
		/// </summary>
		public InvoiceReceiptChangeStateDto ChangeState(int invoiceReceiptId, InvoiceReceiptChangeStateDto inputData)
		{
 			string url = string.Format("https://{1}.app.invoicexpress.com/invoice_receipts/{2}/change-state.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, invoiceReceiptId);
			var result = apiClient.Send("PUT", url, 200, inputData.XmlSerializeToString());
			return result.DeserializeXml<InvoiceReceiptChangeStateDto>();
 		}

		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/email">InvoiceReceipts EmailInvoice</a> Method
		/// </summary>
		public void EmailInvoice(int invoiceReceiptId, EmailMessageDto inputData)
		{
 			string url = string.Format("https://{1}.app.invoicexpress.com/invoice_receipts/{2}/email-document.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, invoiceReceiptId);
			apiClient.Send("PUT", url, 200, inputData.XmlSerializeToString());
		}

		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/related-documents">InvoiceReceipts RelatedDocuments</a> Method
		/// </summary>
		public InvoicesDto RelatedDocuments(int invoiceReceiptId)
		{
 			string url = string.Format("https://{1}.app.invoicexpress.com/document/{2}/related_documents.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, invoiceReceiptId);
			var result = apiClient.Send("GET", url, 200);
			return result.DeserializeXml<InvoicesDto>();
 		}

		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/documents-pdf">InvoiceReceipts Pdf</a> Method
		/// </summary>
		public PdfOutputDto Pdf(int invoiceReceiptId)
		{
 			string url = string.Format("https://{1}.app.invoicexpress.com/api/pdf/{2}.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, invoiceReceiptId);
			var result = apiClient.Send("GET", url, 200);
			return result.DeserializeXml<PdfOutputDto>();
 		}
	}
}