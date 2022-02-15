
namespace Core.Utilities.Results
{

    // Mesaj, başarılı işlem olup olmadığı ve içerisinde barındırdığı veriyi geriye döndürecektir.
    // Bunu Result'a eklemedik. Nedeni şu işlemlerimizin sonucunda her zaman veri veya bir liste dönmek zorunda değil.
    // Buda şu anlama geliyor kullanmayacağımız bir properties tanımlamak SOLID prensiplerinden I harfine ters olacaktır.
    // Ve sonuç olarak farklı bir sınıf olan DataResult'ı oluşturuyoruz.
    public interface IDataResult<out T> : IResult 
    {
        T Data { get; } // <T>(generic - tip belli değil) dönüş tipi dışarıdan gönderilerek belirleniyor.
    }
}
