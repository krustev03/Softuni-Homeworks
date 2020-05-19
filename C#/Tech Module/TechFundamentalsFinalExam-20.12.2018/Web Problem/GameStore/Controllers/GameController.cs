using System;
using System.Collections.Generic;
using System.Linq;
using GameStore.Data;
using GameStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new GameStoreDbContext())
            {
                var games = db.Games.ToList();
                return this.View(games);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(string name, string dlc, decimal price, string platform)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(dlc) || price < 0 || string.IsNullOrEmpty(platform))
            {
                return RedirectToAction("Index");
            }

            using (var db = new GameStoreDbContext())
            {
                Game game = new Game
                {
                    Name = name,
                    Dlc = dlc,
                    Price = price,
                    Platform = platform
                };
                db.Games.Add(game);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new GameStoreDbContext())
            {
                var gameToEdit = db.Games.Find(id);

                return View(gameToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Game game)
        {
            using (var db = new GameStoreDbContext())
            {
                db.Games.Update(game);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using(var db = new GameStoreDbContext())
            {
                var gameToDelete = db.Games.Find(id);

                return View(gameToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Game game)
        {
            using (var db = new GameStoreDbContext())
            {
                db.Games.Remove(game);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}