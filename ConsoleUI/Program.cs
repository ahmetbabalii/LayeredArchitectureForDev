using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CustomerTest();
        }

        // SOLİD
        // Open Closed Principle => Yaptığınız yazılıma yeni bir özellik ekliyorsanız mevcutta
        //                          ki hiçbir koda dokunamazsınız
        private static void CustomerTest()
        {
            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal(new NorthwindContext()));
            //foreach (var item in customerManager.GetAllDetails().Data)
            //{
            //    Console.WriteLine(item.Alan2 + item.Alan1);
            //}

            //Console.ReadLine();
        }
    }
}
