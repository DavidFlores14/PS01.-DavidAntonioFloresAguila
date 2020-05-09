using System.Web;
using System.Web.Mvc;

namespace PS01._DavidAntonioFloresAguila
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
