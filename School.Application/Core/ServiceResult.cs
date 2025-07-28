namespace School.Application.Core
{
    public class ServiceResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public static ServiceResult Ok(string message = "Success")
        {
            return new ServiceResult { Success = true, Message = message };
        }

        public static ServiceResult Fail(string message = "Error")
        {
            return new ServiceResult { Success = false, Message = message };
        }
    }
}
