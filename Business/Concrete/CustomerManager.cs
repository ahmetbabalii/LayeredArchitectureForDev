using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        // Somut methodlar


        // bu kısımda bağımlılıklar ortadan kaldırılıyor.
        private ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.Added);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            // iş kodları
            // yetkisi var mı vs. kontrolleri yapılır.
            // bir iş sınıfı başka bir sınıfları newlemez.
            // eğer newler ise bağımlılıklar oluşur

            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(null));
        }
    }
}
