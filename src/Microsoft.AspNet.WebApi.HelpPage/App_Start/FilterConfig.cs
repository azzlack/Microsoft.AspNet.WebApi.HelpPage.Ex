using System.Web;
using System.Web.Mvc;

namespace Microsoft.AspNet.WebApi.HelpPage
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
