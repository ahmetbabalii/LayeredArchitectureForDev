
using Core;

namespace Entities.Dtos
{
    // Bu sınıf bir DTO örneğidir. Birden fazla tablodan alınabilecek alanları temsil eder.
    // Join vb. operasyonları yönetebilmek ve kod okunurluğunu arttırmak amacıyla Core katmanı altında bulunan IDTO implementasyonunu gerçekleştiriyoruz.
    public class ProductDetailDto : IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock{ get; set; }
    }
}
