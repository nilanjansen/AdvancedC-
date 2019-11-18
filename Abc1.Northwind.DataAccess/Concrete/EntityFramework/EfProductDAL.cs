using Abc.Core.DataAccess.EntityFramework;
using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.Entities.Concrete;
using Abc.Northwind.DataAccess.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Abc.Northwind.DataAccess.Concrete
{
    public class EfProductDAL : EfEntityRepositoryBase<Product,NorthWindContext>,IProductDAL
    {
       
    }
}
