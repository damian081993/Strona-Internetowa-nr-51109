using System.Web;
using System.Web.Mvc;

namespace StronaInternetowa51109
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
