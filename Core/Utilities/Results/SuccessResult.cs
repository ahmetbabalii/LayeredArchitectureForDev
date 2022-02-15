
namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        // base keyword'ü ile beraber implemente edilen sınıfın İKİ parametreli contrcutor'ı çalışacaktır.
        // İşlemin başarılı olduğunu default olarak göndermiş oluyoruz. (Mesaj ile birlikte)
        public SuccessResult(string message) : base(true, message) { }

        // base keyword'ü ile beraber implemente edilen sınıfın TEK parametreli contrcutor'ı çalışacaktır.
        // İşlemin başarılı olduğunu default olarak göndermiş oluyoruz.
        public SuccessResult() : base(true) { }
    }
}
