
namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data, true, message) { }

        public SuccessDataResult(T data) : base(data, true) { }

        public SuccessDataResult(string message) : base(default, true, message) { }
        // Burada belirlenen default ile birlikte <T> içerisinde gönderilen veri tipinini default değeri gönderilir
        // int default değer = 0, string default değeri = null, char default değeri => '0', bool default değeri = false gibi...
        public SuccessDataResult() : base(default, true) { }
    }
}
