using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class DestinationController : Controller
    {
       

        IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            var values = from x in _destinationService.TGetlist() select x;
            if (!string.IsNullOrEmpty(searchString))
            {
                values = values.Where(y => y.City.Contains(searchString));
            }
            return View(values.ToList());
        }
    }
}
