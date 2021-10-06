
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entities.Concrete;
using Core.DataAccess;
using Entities.Dtos;


namespace DataAccess.Abstract
{
    public interface ICustomerDalYedek //: IEntityRepository<Customer>
    {
        // ürüne ait özel operasyonları buraya ekliyoruz

        void Add(Customer entity);
        void Update(Customer entity);
        void Delete(Customer entity);

        Customer Get(Expression<Func<Customer, bool>> expression);

        // Null verilmesinin nedeni filtre uygulayıp uygulamamanın opsoyonel olması
        // Express'ın delegeta'i
        List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null);

        List<CustomerDetailsDto> GetCustomerDetails();
    }
}
