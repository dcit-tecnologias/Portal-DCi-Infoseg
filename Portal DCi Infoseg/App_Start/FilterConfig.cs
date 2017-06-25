using System.Web;
using System.Web.Mvc;

namespace Portal_DCi_Infoseg
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
