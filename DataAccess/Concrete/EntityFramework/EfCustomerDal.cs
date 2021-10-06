
using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal: EfEntityRepositoryBase<Customer, NorthwindContext>, ICustomerDal
    {
        public List<CustomerDetailsDto> GetCustomerDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return (from p in context.Customers
                        select new CustomerDetailsDto()
                        {
                            Alan1 = "1",
                            Alan2 = "2"
                        }).ToList();
            }
        }
    }
}
