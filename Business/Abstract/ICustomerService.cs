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
    public interface ICustomerService
    {
        // Soyut methotlar 

        IResult Add(Customer customer);

        IDataResult<List<Customer>> GetAll();

        IDataResult<List<CustomerDetailsDto>> GetAllDetails();
    }
}
