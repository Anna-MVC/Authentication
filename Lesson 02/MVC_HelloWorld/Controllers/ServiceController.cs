﻿using MVC_HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_HelloWorld.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Pizza(int page = 1)
        {
            ViewBag.page = page;
            ViewData["page"] = page;
            for (int i = 0; i < 10; i++)
            {
                //ViewData[$"data{i}"] = i;
                ViewData.Add($"data{i}", i);
            }

            var quantity = 2;
            var list = ModelFactory.GetPizzaList();
            var model = list
                .Skip((page - 1) * quantity)
                .Take(quantity)
                .Select(p => ModelFactory.Create(p));

            return View(model);
        }
    }
}