using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Office2010.Excel;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminReservationController : Controller
    {
        IDestinationService _destinationService;
        IReservationService _reservationService;
        private readonly UserManager<AppUser> _userManager;

        public AdminReservationController(UserManager<AppUser> userManager, IDestinationService destinationService, IReservationService reservationService)
        {
            _userManager = userManager;
            _destinationService = destinationService;
            _reservationService = reservationService;
        }
        public async Task< IActionResult> Index()
        {
          
            return View();
        }
    }
}
