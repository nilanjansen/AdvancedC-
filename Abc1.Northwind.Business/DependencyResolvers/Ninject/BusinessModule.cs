using Abc.Northwind.Business.Business;
using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.DataAccess.Concrete;
using Abc1.Northwind.Business.Abstract;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Northwind.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>();
            Bind<IProductDAL>().To<EfProductDAL>();
        }
    }
}
