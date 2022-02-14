using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Business.Abstract;
using Entities.Dtos;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet]
        public List<ProductDetailDto> Get()
        {
            var result = _productService.GetAllDetails();
            return result.Data;
        }
    }
}
