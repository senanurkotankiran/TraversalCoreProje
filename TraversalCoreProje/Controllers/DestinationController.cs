using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
       
        IDestinationService _destinationService;
        private readonly UserManager<AppUser> _userManager;

        public DestinationController(UserManager<AppUser> userManager, IDestinationService destinationService = null)
        {
            _userManager = userManager;
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {

            var values = _destinationService.TGetlist();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> DestinationDetails(int id)
        {
            ViewBag.i = id;
            ViewBag.destID = id;
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userID = value.Id;
            var values = _destinationService.TGetDestinationWithGuide(id);   
            return View(values);
        }

        [HttpPost]
        public IActionResult DestinationDetails(Destination d)
        {
            return View();
        }


    }
}
