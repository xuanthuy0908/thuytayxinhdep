using System.Web;
using System.Web.Mvc;

namespace trankimxuanthuy_lab_456
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
