using System.Web;
using System.Web.Mvc;

namespace FirstGitGubWithVisualStudio
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
