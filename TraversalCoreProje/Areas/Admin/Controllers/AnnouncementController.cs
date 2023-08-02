using AutoMapper;
using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _mapper.Map<List<AnnouncementListDTO>>(_announcementService.TGetlist());
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDTO model)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TAdd(new Announcement()
                {
                    Content = model.Content,
                    Title = model.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult DeleteAnnouncement(int id)
        {
            var values = _announcementService.TGetById(id);
            _announcementService.TDelete(values);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var values = _mapper.Map<AnnouncementUpdateDTO>(_announcementService.TGetById(id));
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAnnouncement(AnnouncementUpdateDTO model)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TUpdate(new Announcement
                {
                    AnnouncementID = model.AnnouncementID,
                    Title = model.Title,
                    Content = model.Content,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
