﻿using GenFu;
using Microsoft.AspNetCore.Mvc;
using pugzore.website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pugzore.website.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var person = A.New<Person>();

            return View(person);
        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                //Save it
                return RedirectToAction("Index", "Home");
            }
            return View(person);
        }
    }
}
