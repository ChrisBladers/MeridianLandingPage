namespace DataResponses
{
    public class DataResponse
    {
        public dynamic Data { get; set; }
        public bool Success { get; set; }
        public string Message {get;set;}

        public DataResponse (bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public DataResponse (dynamic data)
        {
            Data = data;
            Success = true;
            Message = "";
        }

    }

}