
namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        // Belirlenen tipte değeri alır bununla beraber işlemin başarısız olduğunu ve iletilen mesajı base sınıfa iletir.
        public ErrorDataResult(T data, string message) : base(data, false, message) { }

        public ErrorDataResult(T data) : base(data, false) { }

        public ErrorDataResult(string message) : base(default, false, message) { }

        public ErrorDataResult() : base(default, false) { }
    }
}
