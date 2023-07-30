using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class _PlatformSettings : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
