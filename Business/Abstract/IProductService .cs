using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;


namespace Business.Abstract
{
    // iş katmanında kullanılacağımız servis operasyonları
    public interface IProductService
    {
        IDataResult<List<ProductDetailDto>> GetAllDetails();
    }
}
