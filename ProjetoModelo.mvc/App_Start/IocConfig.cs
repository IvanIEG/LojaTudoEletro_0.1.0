using System.Web.Mvc;
using Ivan.LojaTudoEletro.Infra.Data.Repositories;
using Ivan.LojaTudoEletro.Infra.Data.Repositories.Interfaces;
using Ninject;


namespace Ivan.LojaTudoEletro.ProjetoModelo.MVC
{
    public  class IocConfig
    {

        public static void ConfigurarDependencias()
        {
            //Cria o Container 
            IKernel kernel = new StandardKernel();

            //Instrução para mapear a interface IPessoa para a classe concreta Pessoa
            kernel.Bind<IProductRepository>().To<ProductRepository>();

            //Registra o container no ASP.NET
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
           
        }
    }
}