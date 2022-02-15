using Entities.Concrete;
using Core.DataAccess;


namespace DataAccess.Abstract
{
    // ICustomerDal bir IEntityRepository'dir ve aynı zamanda çalışma tipi de Customer.
    // ICustomerDal'ı Customer için yapılandırmış oluyoruz.
    public interface ICustomerDal : IEntityRepository<Customer>
    {
    }
}
