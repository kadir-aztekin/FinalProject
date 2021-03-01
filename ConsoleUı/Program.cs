using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using System;

namespace ConsoleUı
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Transformation Objects :DTOs
            Console.WriteLine("kingaras");
            


            ProductTest();
            //CategoryTest();
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var x in result.Data )
                {
                    Console.WriteLine(x.ProductName + "/" + x.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            //foreach (var x in categoryManager.GetAll())
            //{
            //    Console.WriteLine(x.CategoryName);
            //}
        }
    }
}
