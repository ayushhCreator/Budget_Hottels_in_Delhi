using System.Web;
using System.Web.Mvc;

namespace Budget_hotels_In_Delhi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
