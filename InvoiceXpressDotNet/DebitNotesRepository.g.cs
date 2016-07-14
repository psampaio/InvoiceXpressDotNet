// Connector API InvoiceXpressDotNet developed by EventKey,Lda http://www.eventkey.pt
using System;
using System.Net;

namespace InvoiceXpressDotNet
{
		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/debit-notes">DebitNotes</a> module
		/// </summary>
		public class DebitNotesRepository
		{
			private readonly IApiClient apiClient;

			public DebitNotesRepository(IApiClient apiClient)
			{
				this.apiClient = apiClient;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/debit-notes/create">DebitNotes Create</a> Method
			/// </summary>
			public DebitNoteDto Create(DebitNoteDto inputData)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/debit_notes.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName);
				var result = apiClient.Send("POST", url, 201, inputData.XmlSerializeToString());
				return result.DeserializeXml<DebitNoteDto>();
 			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/debit-notes/get">DebitNotes Get</a> Method
			/// </summary>
			public DebitNoteDto Get(string debitNoteId)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/debit_notes/{2}.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, debitNoteId);
				var result = apiClient.Send("GET", url, 200);
				return result.DeserializeXml<DebitNoteDto>();
 			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/debit-notes/update">DebitNotes Update</a> Method
			/// </summary>
			public void Update(string debitNoteId, DebitNoteDto inputData)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/debit_notes/{2}.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, debitNoteId);
				var result = apiClient.Send("PUT", url, 200, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/debit-notes/list">DebitNotes List</a> Method
			/// </summary>
			public DebitNoteDto List(int? page, int? perPage)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/debit_notes.xml?api_key={0}&page={2}&per_page={3}", apiClient.ApiKey, apiClient.AccountName, page, perPage);
				var result = apiClient.Send("GET", url, 200);
				return result.DeserializeXml<DebitNoteDto>();
 			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/debit-notes/change-state">DebitNotes ChangeState</a> Method
			/// </summary>
			public void ChangeState(string debitNoteId, DebitNoteChangeStateDto inputData)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/debit_notes/{2}/change-state.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, debitNoteId);
				var result = apiClient.Send("PUT", url, 200, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/debit-notes/email">DebitNotes EmailDocument</a> Method
			/// </summary>
			public void EmailDocument(string debitNoteId, EmailMessageDto inputData)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/debit_notes/{2}/email-document.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, debitNoteId);
				var result = apiClient.Send("PUT", url, 200, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/debit-notes/documents-pdf">DebitNotes Pdf</a> Method
			/// </summary>
			public PdfOutputDto Pdf(string debitNoteId)
			{
 				string url = string.Format("https://{1}.app.invoicexpress.com/api/pdf/{2}.xml?api_key={0}", apiClient.ApiKey, apiClient.AccountName, debitNoteId);
				var result = apiClient.Send("GET", url, 200);
				return result.DeserializeXml<PdfOutputDto>();
 			}

}
}