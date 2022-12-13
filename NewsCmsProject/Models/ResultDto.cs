using Newtonsoft.Json;

namespace NewsCmsProject.Models
{
    public class ResultDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public static string CreateJson(bool isSuccess, string message)
        {
            return JsonConvert.SerializeObject(new ResultDto { IsSuccess = isSuccess, Message = message });
        }
    }
    public class ResultDto<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}