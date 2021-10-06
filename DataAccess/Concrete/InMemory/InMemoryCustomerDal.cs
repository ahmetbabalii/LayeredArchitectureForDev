using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCustomerDal : ICustomerDal
    {
        // class içerisinde fakat methodların dışında tanımladığımız için bu değişken tip bir global değişkendir.
        // global değişkenlerin başına genellikle "_" ifadesi eklenir. Bu olaya naming convention denir.
        List<Customer> _customers;

        public InMemoryCustomerDal()
        {
            // Bu kısımda üzerinde çalışabileceğimiz örnek veriler üretiyoruz.
            _customers = new List<Customer>()
            {
                new Customer() { CustomerID =  "1", CompanyName = "X"},
                new Customer() { CustomerID =  "2", CompanyName = "Y"},
                new Customer() { CustomerID =  "3", CompanyName = "Z"}
            };
        }

        public List<Customer> GetAll()
        {
            return _customers;
        }

        public void Add(Customer customer)
        {
            _customers.Add(customer);
        }

        public void Update(Customer customer)
        {
            var findCustomer = _customers.FirstOrDefault(x => x.CustomerID == customer.CustomerID);
            findCustomer.CompanyName = customer.CompanyName;
        }

        public void Delete(Customer customer)
        {
            // Bu şekilde bir silme yöntemi yok.
            // Bunun sebebi head de yer alan bilgilerden kaynaklanıyor.
            // List bir referans tip olduğu için hepsinin referans numarası farklı olacaktır.
            // Bundan dolayı head de olan bir referansın tutturulamayağı için silme işlemi gerçekleştiremeyecek
            // Bu bölümde LINQ kullanarak ilerliyor olacağız.

            var findCustomer = _customers.FirstOrDefault(x => x.CustomerID == customer.CustomerID);
            _customers.Remove(findCustomer);
        }

        public List<CustomerDetailsDto> GetCustomerDetails()
        {
            throw new NotImplementedException();
        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

      
    }
}
