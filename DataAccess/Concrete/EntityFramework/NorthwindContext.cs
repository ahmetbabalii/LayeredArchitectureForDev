using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    // Context : Db tabloları ile proje içerisinde ki Entity Classlarını ilişkilendiriyor.
    public class NorthwindContext : DbContext 
    {
        // DbContext : EntityFramework ile beraber gelen context nesnesidir. Biz burada değişiklik yapmak istediğimiz kısımları override ederek kullanıyoruz.
        // Proje çalışır çalışmaz direkt olarak buraya gelerek ilgili db bilgisini alıyor.

        // OnConfiguring : Bu methodla birlikte bizim projemizin hangi veritabanı ile ilişkili olduğunu belirtiyoruz.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Burada connection string yazarken büyük küçük harf duyarlılığı bulunmuyor (SQL case insensitive'dir)
            // Bağlantı bilgilerini View altında yer alan SQL Server Object Explorer üzerinden yeni bağlantı ekleyerek ulaşabilirsiniz.
            optionsBuilder.UseSqlServer(@"Data Source=AHMETBAB\SQLEXPRESS;Initial Catalog=NorthwindNetCore;Integrated Security=True");
        }

        // DbSet ile birlikte veritabanında ki tablolar ile classları(entity'leri) eşleştirmiş oluyoruz.
        // örnek => public DbSet<EntityAdi> VeritabanındaKullanilanTabloAdi { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
