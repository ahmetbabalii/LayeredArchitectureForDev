using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entities;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    /// <summary>
    /// Repository Pattern'in implementasyonudur. CRUD operasyonlar için gerekli tüm toolkit burada implemente edilmiştir.
    /// ayrıca lifetimescope autofac tarafından yönetildiğinden metodların içinde bulunan usingler kaldırılmıştır.
    /// </summary>
    /// <typeparam name="TEntity">Tablo</typeparam>
    /// <typeparam name="TContext">Context</typeparam>
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            // Aşağıda kullanılan using sayesinde örneklenen nesnenin işi bitti ise garbage collecter bellekten o nesneyi atar.
            // C#'da bellek tasarufu için önemli bir yapıdır. (garbage collecter) 
            // Using C#'ın IDisposable pattern implementation'ıdır.

            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);  // Veri kaynağı ile ilişkilendir.
                addedEntity.State = EntityState.Added; // Ekleme operasyonu olduğunu belirttik.
                context.SaveChanges(); // Veritabanında işlemi tamamlar.
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            // LINQ => Language Integrated Query
            using (TContext context = new TContext())
            {
                // Gönderilen filtre ile ilgili ilk kaydın yer aldığı sonucu geriye dönecek.
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                // Filtrenin uygulandığı kısımdır. Eğer filtre ile ilgili parametre gönderilmez ise tüm kayıtları geriye döndürecektir.
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
