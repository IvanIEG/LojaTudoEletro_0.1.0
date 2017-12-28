using System.Collections.Generic;
using SimpleInjector;
using Ivan.LojaTudoEletro.Services;
using Ivan.LojaTudoEletro.Services.Interfaces;
using Ivan.LojaTudoEletro.Infra.Data.Repositories.Interfaces;
using Ivan.LojaTudoEletro.Infra.Data.Repositories;

namespace Ivan.LojaTudoEletro.ProjetoModelo.MVC.IOC
{

    public static class SimpleInjectorContainer
    {
        public static Container RegisterServices()
        {
            Container container = new Container();

           
            container.Register<IProductServices, ProductServices>();
            container.Register<IProductRepository, ProductRepository>();
            container.Verify();
           
            return container;
        }

    }
}