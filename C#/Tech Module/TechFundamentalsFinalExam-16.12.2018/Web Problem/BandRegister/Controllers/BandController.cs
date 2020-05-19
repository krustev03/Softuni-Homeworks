using BandRegister.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BandRegister.Data;

namespace BandRegister.Controllers
{
    public class BandController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new BandRegisterDbContext())
            {
                var bands = db.Bands.ToList();
                return this.View(bands);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(string name, string members, decimal honorarium, string genre)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(members) || string.IsNullOrEmpty(genre) || honorarium <= 0)
            {
                return RedirectToAction("Index");
            }

            using (var db = new BandRegisterDbContext())
            {
                Band band = new Band
                {
                    Name = name,
                    Members = members,
                    Honorarium = honorarium,
                    Genre = genre
                };
                db.Bands.Add(band);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new BandRegisterDbContext())
            {
                var bandToEdit = db.Bands.Find(id);

                return View(bandToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Band band)
        {
            using (var db = new BandRegisterDbContext())
            {
                db.Bands.Update(band);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new BandRegisterDbContext())
            {
                var bandToDelete = db.Bands.Find(id);

                return View(bandToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Band band)
        {
            using (var db = new BandRegisterDbContext())
            {
                db.Bands.Remove(band);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}