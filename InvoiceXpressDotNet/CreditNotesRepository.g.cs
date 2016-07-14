// Connector API InvoiceXpressDotNet developed by EventKey,Lda http://www.eventkey.pt
using System;
using System.Net;

namespace InvoiceXpressDotNet
{
	/// <summary>
	/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes">CreditNotes</a> module
	/// </summary>
	public class CreditNotesRepository
	{
		private readonly IApiClient apiClient;

		public CreditNotesRepository(IApiClient apiClient)
		{
			this.apiClient = apiClient;
		}

		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/create">CreditNotes Create</a> Method
		/// </summary>
		public CreditNoteDto Create(CreditNoteDto inputData)
		{
 			string url = string.Format("https://{1}.app.invoicexpress.com/credit_notes.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName);
			var result = apiClient.Send("POST", url, 201, inputData.XmlSerializeToString());
			return result.DeserializeXml<CreditNoteDto>();
 		}

		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/get">CreditNotes Get</a> Method
		/// </summary>
		public CreditNoteDto Get(string creditNoteId)
		{
 			string url = string.Format("https://{1}.app.invoicexpress.com/credit_notes/{2}.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, creditNoteId);
			var result = apiClient.Send("GET", url, 200);
			return result.DeserializeXml<CreditNoteDto>();
 		}

		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/update">CreditNotes Update</a> Method
		/// </summary>
		public void Update(string creditNoteId, CreditNoteDto inputData)
		{
 			string url = string.Format("https://{1}.app.invoicexpress.com/credit_notes/{2}.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, creditNoteId);
			apiClient.Send("PUT", url, 200, inputData.XmlSerializeToString());
		}

		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/list">CreditNotes List</a> Method
		/// </summary>
		public CreditNotesDto List(int? page, int? perPage)
		{
 			string url = string.Format("https://{1}.app.invoicexpress.com/credit_notes.xml?api_key={0}&page={2}&per_page={3}", apiClient.ApiKey, apiClient.AccountName, page, perPage);
			var result = apiClient.Send("GET", url, 200);
			return result.DeserializeXml<CreditNotesDto>();
 		}

		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/change-state">CreditNotes ChangeState</a> Method
		/// </summary>
		public void ChangeState(string creditNoteId, CreditNoteChangeStateDto inputData)
		{
 			string url = string.Format("https://{1}.app.invoicexpress.com/credit_notes/{2}/change-state.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, creditNoteId);
			apiClient.Send("PUT", url, 200, inputData.XmlSerializeToString());
		}

		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/email">CreditNotes EmailDocument</a> Method
		/// </summary>
		public void EmailDocument(string creditNoteId, EmailMessageDto inputData)
		{
 			string url = string.Format("https://{1}.app.invoicexpress.com/credit_notes/{2}/email-document.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, creditNoteId);
			apiClient.Send("PUT", url, 200, inputData.XmlSerializeToString());
		}

		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/documents-pdf">CreditNotes Pdf</a> Method
		/// </summary>
		public PdfOutputDto Pdf(string creditNoteId)
		{
 			string url = string.Format("https://{1}.app.invoicexpress.com/api/pdf/{2}.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, creditNoteId);
			var result = apiClient.Send("GET", url, 200);
			return result.DeserializeXml<PdfOutputDto>();
 		}
	}
}