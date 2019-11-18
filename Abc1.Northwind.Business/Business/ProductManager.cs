using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.Entities.Concrete;
using Abc.Core.CrossCuttingConcerns.Validation.FluentValidation;
using Abc1.Northwind.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Abc.Northwind.Business.ValidationRules.FluentValidation;
using Abc.Core.Aspects.PostSharp.ValidationAspects;

namespace Abc.Northwind.Business.Business
{
    public class ProductManager:IProductService
    {
        private readonly IProductDAL _productDAL;
        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }
        [FluentValidationAspect(typeof(ProductValidator))]
        public void Add(Product product)
        {
            _productDAL.Add(product);
        }

        public void Delete(Product product)
        {
            _productDAL.Delete(product);
        }

        public List<Product> GetAll()
        {
           return _productDAL.GetList();
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            return _productDAL.GetList(p => p.CategoryId == categoryId);
        }

        public void Update(Product product)
        {
            _productDAL.Update(product);
        }
    }
}
