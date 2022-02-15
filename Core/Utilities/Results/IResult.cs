
namespace Core.Utilities.Results
{
    // Temel bilgilendirme için kullanılan methodların imzaları
    public interface IResult
    {
        // İşlem sonucunun başarı durumunu gösterecek
        bool Success { get; } // => set işlemleri sadece contructor içerisinden yapılabilir. 


        // İşlem sonucunda kullanıcıya gösterilmek istenen mesaj
        string Message { get; }
    }
}
