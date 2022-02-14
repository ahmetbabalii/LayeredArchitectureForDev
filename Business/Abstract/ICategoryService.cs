using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;


namespace Business.Abstract
{
    // iş katmanında kullanılacağımız servis operasyonları
    public interface ICategoryService
    {
        // Soyut methotlar 

        IDataResult<List<Category>> GetAll();

        IDataResult<Category> GetById(int categoryId);
    }
}
