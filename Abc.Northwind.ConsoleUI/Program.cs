using Abc.Northwind.Business.Business;
using Abc.Northwind.DataAccess.Concrete;
using Abc1.Northwind.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Northwind.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductManager(new EfProductDAL());
            foreach(var product in productService.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            Console.ReadKey();
        }
    }
}
