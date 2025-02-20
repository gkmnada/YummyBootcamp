namespace Yummy.Application.Common.Base
{
    public class BaseResponse
    {
        public object Data { get; set; } = null!;
        public bool IsSuccess { get; set; }
        public string Message { get; set; } = string.Empty;
        public ICollection<string> Errors { get; set; } = new List<string>();
    }
}
