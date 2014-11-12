using System.Web;
using System.Web.Mvc;

namespace HabitSculptor.Service.User
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
