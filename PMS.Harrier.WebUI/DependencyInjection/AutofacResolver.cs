using System.Collections.Generic;
using System.Data.Entity;
using Autofac;
using Autofac.Integration.Mvc;
using PMS.Harrier.BusinessLogicLayer.Abstract;
using PMS.Harrier.BusinessLogicLayer.Implementations;
using PMS.Harrier.DataAccessLayer.Concrete;
using PMS.Harrier.DataAccessLayer.Repository;
using PMS.Harrier.DataAccessLayer.Repository.Interfaces;
using PMS.Harrier.DataAccessLayer.UnitOfWork;

namespace PMS.Harrier.WebUI.DependencyInjection
{
    public class AutofacResolver
    {
        private static IContainer _container;
        static AutofacResolver()
        {
            Build();
        }

        public static IContainer GetContainer()
        {
            return _container;
        }

        private static void Build()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            RegisterTypes(builder);
            _container = builder.Build();
        }





        private static void RegisterTypes(ContainerBuilder builder)
        {
            //Register Types here
            builder.RegisterType<EfDbContext>().As<EfDbContext>();
            builder.RegisterType<ProjectRepository>().As<IProjectRepository>();
            builder.RegisterType<AccountRepository>().As<IAccountRepository>();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterType<ProjectLogic>().As<IProjectLogic>();

        }
    }
}