
using System.Collections.Generic;
using Entities.Concrete;
using Core.DataAccess;
using Entities.Dtos;


namespace DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
        // ürüne ait özel operasyonları buraya ekliyoruz
        List<CustomerDetailsDto> GetCustomerDetails();
    }
}
