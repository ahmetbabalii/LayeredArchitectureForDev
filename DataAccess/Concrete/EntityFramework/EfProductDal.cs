
using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetCustomerDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return (from p in context.Products
                        join c in context.Categories
                            on p.CategoryId equals c.CategoryId
                        select new ProductDetailDto()
                        {
                           CategoryName = c.CategoryName,
                           ProductId = p.ProductId,
                           ProductName = p.ProductName,
                           UnitsInStock = p.UnitsInStock
                        }).ToList();
            }
        }
    }
}
