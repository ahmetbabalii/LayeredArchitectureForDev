
namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        // this ile beraber altta yer alan constructor da çalışacaktır.
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; }
    }
}
