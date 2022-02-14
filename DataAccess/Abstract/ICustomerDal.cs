
using System.Collections.Generic;
using Entities.Concrete;
using Core.DataAccess;
using Entities.Dtos;


namespace DataAccess.Abstract
{
    // ICustomerDal bir IEntityRepository'dir ve aynı zamanda çalışma tipi de Customer.
    // ICustomerDal'ı Customer için yapılandırmış oluyoruz.
    public interface ICustomerDal : IEntityRepository<Customer>
    {
        // Ürüne ait özel operasyonları buraya ekliyoruz. 
        // Customer'a ait özel bir operasyon eklemiş olduk.
    }
}
