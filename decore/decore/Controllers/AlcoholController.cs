﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using decore.ViewModels;
using Decore.Models;

namespace decore.Controllers
{
    public class AlcoholController : Controller
    {
        // GET: Alcohol
        public ActionResult Index()
        {

            var beverages = new List<Beverage>
            {
                new Beverage() { BeverageId = 1, Title = "Öl", Price = 22, Volume = 23},
                new Beverage() { BeverageId = 2, Title = "Cider", Price = 12, Volume = 43},
                new Beverage() { BeverageId = 3, Title = "Vatten", Price = 42, Volume = 32},
            };

            
            var measures = new List<Measure>
            {
                new Measure() { MeasureId = 1, MeasureType = "Styck"},
                new Measure() { MeasureId = 2, MeasureType = "Gram"},
                new Measure() { MeasureId = 3, MeasureType = "Centiliter"},
                new Measure() { MeasureId = 4, MeasureType = "Liter"},
            };

            var viewModel = new BeverageViewModel
            {
                Beverages = beverages,
                Beverage = new Beverage(),
                Measures = measures
            };

            return View(viewModel);
        }
    }
}