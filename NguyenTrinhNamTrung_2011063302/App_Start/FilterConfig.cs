using System.Web;
using System.Web.Mvc;

namespace NguyenTrinhNamTrung_2011063302
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
