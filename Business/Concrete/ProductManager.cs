using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        /*
            - constructor içerisine IProductDal veya onu kalıtım alan nesne gönderebiliyoruz (EfProductDal vb.).
            - Burada gerçekleştiriliyor olan sürece verilen isim "constructor injection". 
            - Direkt olarak EfProductDal da gönderebilirdik fakat o zaman bağımlı hale gelmiş olacaktık. Şuan bağımlıyız fakat biraz 
              daha gevşek bağımlıyız (referans üzerinde bağlıyız.)
              Bu kısmı açalım biraz;
              Biz şuan projemizde EntityFrameWork kullanıyoruz ancak yarın farklı bir ORM teknolojisine geçmek isteyebiliriz. 
              Geçmek istediğimiz durumda bir çok yerde değişiklik yapmamızın önüne geçmiş oluyoruz. Çünkü IProductDal içerisinde
              veriye erişimle ilgili bir kısıt yok sadece bize dönecek değerin tipini belirtiyor asıl işi yapan EfProductDal. 
              Manager'ı kullandığımız noktada tam olarak ne anlatılmak istenildiği ile ilgili ufak bir örnek yapıyor olacağım.
        */

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        // Sadece bir liste döner. Başarılı olma durumunu veya hata durumunu dönmez.
        public List<ProductDetailDto> GetAllProductDetails()
        {
            return new List<ProductDetailDto>(_productDal.GetProductDetails());
        }

        public IResult Add(Product customer)
        {
            if (string.IsNullOrEmpty(customer.ProductName))
                return new Result(false ,"Ürünün ismin boş geçilemez"); 

            _productDal.Add(customer);
            return new SuccessResult(Messages.Added);
        }

        public IDataResult<List<ProductDetailDto>> GetAllDetails()
        {
            // .get() => delegate => promise
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails(), Messages.Listed);
        }
    }
}


