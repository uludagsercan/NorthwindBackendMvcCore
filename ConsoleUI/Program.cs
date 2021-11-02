using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        //SOLID
        //Open Closed Principle
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();

        }

        //private static void CategoryTest()
        //{
        //    CategoryManager pm = new CategoryManager(new EfCategoryDal());

        //    foreach (var item in pm.GetAll())
        //    {
        //        Console.WriteLine(item.CategoryName);
        //    }
        //}

        //private static void ProductTest()
        //{
        //    ProductManager pm = new ProductManager(new EfProductDal());
        //    var result = pm.GetProductDetails();
        //    if (result.Success)
        //    {
        //        foreach (var item in result.Data)
        //        {
        //            Console.WriteLine(item.CategoryName);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        //    foreach (var item in pm.GetProductDetails().Data)
        //    {
        //        Console.WriteLine(item.CategoryName + "-" + item.ProductName);
        //    }
            
        //}
    }
}
