using System.Web;
using System.Web.Mvc;

namespace WebApiCrud_JorgeCorrea
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
