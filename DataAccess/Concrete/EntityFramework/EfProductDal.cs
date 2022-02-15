using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;


namespace DataAccess.Concrete.EntityFramework
{
    /*
        - Base işlemler yürütebilmek için kullandığımız EfEntityRepositoryBase nesnesini ve temel operasyonlar harici süreci
          yürütmek amacıyla IProductDal'ı implemente ediyoruz.

        - EfEntityRepositoryBase kullanırken ilk önce hangi entity üzerinde çalışacağımızı ve çalışacağımız entity'in hangi
          context içerisinde var olduğu bilgisini aktarıyoruz.

        - Temel CRUD işlemleri dışında burada custom bir geliştirme yapılıyor. IProduct içerisinde yer alan GetProductDetails()
          methodu ile birlikte join işlemi gerçekleştiriliyor.Product ve Categories tablosunda eşleşen kayıtlar çekiliyor.
          Alınan kayıtlar üzerinde yeni bir dönüş tipi olan ProductDetailDto sınıfı tanımlanıyor.

        - ProductDetailDto bir DTO(Data Transformation Object). Join gibi operasyonların sonucunda istenilen alanlar dışında birden fazla
          tabloda var olan alanların dönülmesini talep edilebilir bu yüzden ayrı bir nesne oluşturduk.        
     */
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
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
