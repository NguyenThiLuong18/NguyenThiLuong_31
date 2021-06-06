using System.Web;
using System.Web.Mvc;

namespace NguyenThiLuong_31
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
