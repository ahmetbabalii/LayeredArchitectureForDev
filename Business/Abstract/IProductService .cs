using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;


namespace Business.Abstract
{
    // iş katmanında kullanılacağımız servis operasyonları
    public interface IProductService
    {
        List<ProductDetailDto> GetAllProductDetails();


        IResult Add(Product customer);
        IDataResult<Product> ProductDetails(int productId);
        IDataResult<List<ProductDetailDto>> GetAllDetails();
    }
}





