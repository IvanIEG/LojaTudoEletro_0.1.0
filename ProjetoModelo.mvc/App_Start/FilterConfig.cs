using System.Web.Mvc;

namespace Ivan.LojaTudoEletro.ProjetoModelo.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
