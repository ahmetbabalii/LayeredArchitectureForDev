using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    // Context : Db tabloları ile proje class'larını bağlıyoruz.
    public class NorthwindContext : DbContext 
    {
        // Proje çalışır çalışmaz direkt olarak buraya gelerek ilgili db bilgisini alıyor.
        // Bu method bizim projemizin hangi veritabanı ile ilişki kurduğunu belirtiyor oluyoruz.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Burada connection string yazarken büyük küçük harf duyarlılığı bulunmuyor (SQL case insensitive'dir)
            optionsBuilder.UseSqlServer(@"Data Source=AHMETBAB\SQLEXPRESS;Initial Catalog=NorthwindNetCore;Integrated Security=True");
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
