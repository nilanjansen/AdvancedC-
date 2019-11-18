using Abc.Northwind.Entities.Concrete;
using Abc1.Northwind.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Abc.Northwind.WebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: Product
        public List<Product> Get()
        {
            return _productService.GetAll();
        }
    }
}
