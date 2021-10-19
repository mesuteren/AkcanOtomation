﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Controllers
{
    public class OperasyonController : Controller
    {
        // GET: Operasyon
        Context c = new Context();
        public ActionResult Index()
        {
            var operasyon = c.Operations.ToList();
            return View(operasyon);
        }

        public ActionResult FlowChart()
        {
            var operasyon = c.Operations.ToList();
            return View(operasyon);
        }
    }
}