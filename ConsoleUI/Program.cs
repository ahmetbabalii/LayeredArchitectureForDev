using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*
                Manager'ı çağırdğımız noktada gevşek bağımlığı anlatacağımdan bahsetmiştim. 
                Manager'ı kullanırken soyut bir nesne veya ona implemente edilen bir nesne bizden talep ediyordu.
                Biz aşağıda ki örnekte EntityFrameWork ile db işlemlerini yürüttüğümüz somut nesneyi göndererek verilerimizi çekebildik.
                
                Peki bunun haricinde farklı olarak ne gönderebilirdik? Farklı bir ORM tulu olan Dapper'ı kullandığımızı düşünelim.
                Projemize dapper ekleyip bunun erişimini tamamladıktan sonra DPProductDal gibi bir sınıf daha projeye kazandırdığımızda
                bizi tek değiştirmemiz gereken nokta bu kısım olacaktır => new ProductManager(new EfProductDal());
            */


            // Dapper ile bir kullanım gerçekleştirmek isteseydik değiştirmemiz gereken tek kısım aşağıda yer alıyor.
            // ProductManager productManager = new ProductManager(new DPProductDal());

            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetAllProductDetails())
            {
                Console.WriteLine(item.ProductName);
            }

            Console.ReadLine();
        }
    }
}
