using System.Web;
using System.Web.Mvc;

namespace WCF_With_Authentication_Client
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
