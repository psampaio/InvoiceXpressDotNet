namespace InvoiceXpressDotNet
{
    public class test
    {
        public void MyTestMethod()
        {
            IApiClient apiClient = new ApiClient("AccountName", "apikey");

            var invoicesRepository = new InvoicesRepository(apiClient);
            var invoiceDto = new InvoiceDto {Client = new ClientDto {Name = "some client"}};
            invoicesRepository.Create(invoiceDto);
        }
    }
}