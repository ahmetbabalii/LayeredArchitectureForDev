using System.Collections.Generic;
using Entities.Concrete;
using Core.DataAccess;
using Entities.Dtos;

namespace DataAccess.Abstract
{
    // IProductDal bir IEntityRepository'dir ve aynı zamanda çalışma tipi de Product.
    // IProductDal'ı Product için yapılandırmış oluyoruz.
    public interface IProductDal : IEntityRepository<Product>
    {
        // Ürüne ait özel operasyonları buraya ekliyoruz. 
        // Product'a ait özel bir operasyon eklemiş olduk.
        List<ProductDetailDto> GetCustomerDetails();
    }
}