
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entities.Concrete;
using Core.DataAccess;
using Entities.Dtos;


namespace DataAccess.Abstract
{
    public interface IProductDal 
    {
        void Add(Product entity);
        void Update(Product entity);
        void Delete(Product entity);

        Customer Get(Expression<Func<Product, bool>> expression);

        List<Customer> GetAll(Expression<Func<Product, bool>> filter = null);
    }
}
