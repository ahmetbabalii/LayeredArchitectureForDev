
namespace Core.Utilities.Results
{
    public class ErrorResult : Result
    {
        // base keyword'ü ile beraber implemente edilen sınıfın İKİ parametreli contrcutor'ı çalışacaktır.
        // İşlemin başarısız olduğunu default olarak göndermiş oluyoruz. (Mesaj ile birlikte)
        public ErrorResult(string message) : base(false, message) { }

        // base keyword'ü ile beraber implemente edilen sınıfın TEK parametreli contrcutor'ı çalışacaktır.
        // İşlemin başarısız olduğunu default olarak göndermiş oluyoruz. 
        public ErrorResult() : base(false) { }
    }
}
