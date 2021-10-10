using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess
{
    /*
       - Burada bir  Generic Repository Pattern deseni kullanıyoruz.    
       - Gelen tipde değişiklik olacağından <T> olarak belirttik. Burada <T>, veritabanı üzerinde çalışacağı tipi belirtiyor.
       - Veritabanı ile ilgili genel operasyonları gerçekleştireceğimiz interface.                
       - <T> için bir kısıtlama da tamnımlamamız gerekiyor bu noktada Generic Constraint tanımlamamız gerekiyor.
       - T bir referans tip olmalı ve T aynı zamanda IEntity'den implemente edilmiş bir nesne olmalı veya direkt olarak IEntity olmalıdır
       - new() : new'lenebilir bir nesne olmalı yani burada IEntity gibi interface'leri buraya gönderemiyor oluyoruz.   
       - class: bu referans tip sadece olabilir    
       - IEntity :  IEntity olabilir veya IEntity'i implemente eden bir nesne olabilir.
    */

    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        /*
             Interface operasyonları public'dir. 
             Bundan ötürü ayrıca public yazmaya gerek kalmıyor.
        */
      
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        T Get(Expression<Func<T, bool>> expression);

        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        // Liste dönerken bir filtre uygulanacak ise buraya ayrıca parametre geçiliyor, parametre geçilmes ise tüm listeyi filtre uygulamadan geri dönüyor olacak.
    }
}
