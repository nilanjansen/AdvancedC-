
using Abc.Northwind.Entities.Concrete;
using System;
using System.Text;

namespace Abc.Northwind.DataAccess.Abstract
{
    public interface IProductDAL:Abc.Core.DataAccess.IEntityRepository<Product>
    {
    }
}
