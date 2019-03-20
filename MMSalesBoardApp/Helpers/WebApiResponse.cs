namespace MMSalesBoard.Api.Helpers
{
    public class WebApiResponse<T> where T : class
    {
        public WebApiResponse()
        {
            this.Success = true;
            this.Message = "İşlem başarıyla gerçekleşmiştir.";

        }

        public bool Success { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
