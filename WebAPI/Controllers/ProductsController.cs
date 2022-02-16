using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Business.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]  // İstekte bulunurken kullanılacak path'i temsil eder. Domainname ardından gönderilecek yolu temsil eder. [controller] => dynamic
    [ApiController]  // ATTRIBUTE
    public class ProductsController : ControllerBase // Controller olarak imzasını taşır
    {
        /*
             - Bağımlılığın azaltılması amacıyla yapılan geliştirme (Loosely coupled = soyuta olan bağımlılık)
             - IProductService istenildiğinde Startup.cs içerisinde belirtilen somut geriye dönecektir.
                    => new ProductManeger() gibi => Referans geriye dönüyor.
               Bu kısımda WebApı içerisinde hazır olarak gelen bir IOC container (Inversion of control ) yapısı kullanılıyor. 
               Anlamı bellekte var olan referansların ctor içerisinden ulaşılmasıdır.       
        */

        private IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet, Route("GetProductsDetails")] // Client tarafından gönderilen isteğin Get tipinde request olduğunu belirtir.
        public IActionResult GetProductsDetails()
        {
            var result = _productService.GetAllDetails();
            if (result.Success)
            {
                return Ok(result.Data); // => 200 Durum Kodu (Ok)
            }

            return BadRequest(result.Message); // => 400 Durum Kodu (Bad Request)
        }

        [HttpPost, Route("AddProduct")]
        public IActionResult AddProduct(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpGet, Route("GetProductDetails")] // https://localhost:44331/api/Products/GetProductDetails?productId=1
        public IActionResult GetProductDetails(int productId)
        {
            var result = _productService.ProductDetails(productId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
    }
}
