using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class KonserlerController : Controller
    {
        private readonly IKonserService _konserService;
        private readonly Context _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public KonserlerController(IKonserService konserService, Context context, IWebHostEnvironment webHostEnvironment)
        {
            _konserService = konserService;
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var values = _konserService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddKonserim()
        {
            return View();
        }
 
        [HttpPost]
        public async Task<IActionResult> AddKonserim(KonserEditViewModel model, IFormFile formfile)
        {
            if (formfile == null)
            {
                // Handle the case when no image file is provided
                ModelState.AddModelError("formfile", "Please upload an image file.");
                return View(model);
            }

            // Save the image file to the server's file system
            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "userimages", formfile.FileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await formfile.CopyToAsync(stream);
            }

            // Create a new Konser object and populate its properties
            var newKonser = new Konser
            {
                Image = formfile.FileName,
                Capacity = model.capacity,
                City = model.city,
                DayNight = model.daynight,
                GuideID = 2,
                Price = model.price
            };

            // Call the service or repository to add the new concert
            _konserService.TAdd(newKonser);

            return RedirectToAction("Index", "Konser");
        }
        public IActionResult DeleteKonserim(int id)
        {
            var values = _konserService.TGetByID(id);
            _konserService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateKonserim(int id)
        {
            var values = _konserService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateKonserim(KonserEditViewModel model, Konser konser, IFormFile formfile)
        {
            var guncellenecekUrun = _konserService.TGetByID(konser.KonserID);
            if (guncellenecekUrun == null)
            {
                return NotFound();
            }

            if (formfile != null)
            {
               
                string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "userimages", formfile.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await formfile.CopyToAsync(stream);
                }
                guncellenecekUrun.Image = formfile.FileName;
            }

            guncellenecekUrun.Capacity = model.capacity;
            guncellenecekUrun.City = model.city;
            guncellenecekUrun.DayNight = model.daynight;
            guncellenecekUrun.Price = model.price;
       
            _konserService.TUpdate(guncellenecekUrun);

            return RedirectToAction("Index","Konser");
        }
    }
}



