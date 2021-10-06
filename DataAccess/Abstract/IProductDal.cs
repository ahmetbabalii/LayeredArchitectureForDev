using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Abstract
{
    // IProductDal bir IEntityRepository'dir ve aynı zamanda çalışma tipi de Product.
    // IProductDal'ı Product için yapılandırmış oluyoruz.
    public interface IProductDal : IEntityRepository<Product>
    {
        // Ürüne ait özel operasyonları buraya ekliyoruz. 
        // Product'a ait özel bir operasyon eklemiş olduk.
    }
}