using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Business.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // ATTRIBUTE => claas ile ilgili bilgi verir. class ile ilgili bilgi verir bir bakıma class'ın imzası
    public class CustomersController : ControllerBase
    {
        // SOLID => O => Open Closed Principle  => Uygulamaya yeni bir özellik eklerken mevcut kodda değişiklik yapmak zorunda olunmaması gerekiyor.
        // Loosely Coupled => Gevşek bağımlılık bir bağımlılığı var ama soyuta olan bağımlılık
        // IOC Container => Inversion Of Control configürasyonu
        private ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }


        [HttpGet]
        public List<Customer> Get()
        {
            /*
                // Dependency Chain => Bağımlılık var şuan burada.
                CustomerManager customerManager = new CustomerManager(new EfCustomerDal(new NorthwindContext()));
                var list = customerManager.GetAll();

                return list.Data;
            */

            var result = _customerService.GetAll();
            return result.Data;
        }
    }
}
