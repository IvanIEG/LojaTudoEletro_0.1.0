
using System.Reflection;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.Practices.Unity;

using Ivan.LojaTudoEletro.ProjetoModelo.MVC.App_Start;
using Unity;

namespace Ivan.LojaTudoEletro.ProjetoModelo.MVC
{

    public class UnityFactory : IControllerFactory
    {
        IUnityContainer Container;

        public UnityFactory()
        {
            Container = new UnityContainer();
            // Recupera o assembly da aplicação
            Assembly assm = Assembly.GetExecutingAssembly();
            // Gera uma lista com todos os controllers da aplicação
            var controllers = from t in assm.GetTypes() where (t.Name.EndsWith("Controller")) select t;
            foreach (var controller in controllers)
            {
                // registra os controllers encontrados no container do Unity
                Container.RegisterType(typeof(IController), controller, controller.Name);
            }
            // Gera uma lista de classes que estão anotadas com ComponentAttribute
            var components = from t in assm.GetTypes() where t.GetCustomAttributes(typeof(ComponentAttribute), false) != null select t;
            foreach (var component in components)
            {
                // Registra os componentes para que eles possam ser injetados no construtor dos controllers
                Container.RegisterType(component);
            }
        }

        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            // Como registramos o controller com o nome da classe, devemos adicionar o prefixo Controller
            return Container.Resolve<IController>(controllerName + "Controller");
        }

        public void ReleaseController(IController controller)
        {
            // Deixamos o unity container desalocar o controller
            //Container.Teardown(controller);
        }

        public System.Web.SessionState.SessionStateBehavior GetControllerSessionBehavior(RequestContext ctx, string controllerName)
        {
            // Como não queremos desabilitar a Session do controller, vamos usar SessionStateBehavior.Default
            return System.Web.SessionState.SessionStateBehavior.Default;
        }
    }
}