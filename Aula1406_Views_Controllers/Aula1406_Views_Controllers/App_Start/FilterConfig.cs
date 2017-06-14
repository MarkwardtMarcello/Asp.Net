using System.Web;
using System.Web.Mvc;

namespace Aula1406_Views_Controllers
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
