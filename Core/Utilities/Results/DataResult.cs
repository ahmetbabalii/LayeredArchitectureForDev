
namespace Core.Utilities.Results
{

    // Result da var olanlara sahip bununla beraber T tipinde bir DATA barındırıyor.
    // Burada gönderilen parametreler base'e gönderiliyor. Nested olarak yani içe çağrılıyorlar ve çalışıyorlar
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message) : base(success, message)
        {
            Data = data;
        }

        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
