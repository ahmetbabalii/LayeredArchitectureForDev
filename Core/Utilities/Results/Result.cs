
namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        // this ile beraber altta yer alan constructor da çalışacaktır. Base contructor çağrılıyor.
        // İki farklı şekilde kullanıma açtık.
        // Sadece başarılı olup olmama durumu gönderilebilir veya başarı olma durumuyla beraber mesaj da gönderilebilir.
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        // Success set edilme işi aşağıda yer alan contructor'a aktarılmış oluyor.
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; }
    }
}
