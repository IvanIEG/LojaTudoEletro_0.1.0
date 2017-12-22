using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoModelo.mvc.Startup))]
namespace ProjetoModelo.mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
