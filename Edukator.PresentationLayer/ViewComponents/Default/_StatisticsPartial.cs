﻿using Edukator.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Edukator.PresentationLayer.ViewComponents.Default
{
    public class _StatisticsPartial : ViewComponent
    {
        Context context=new Context();
        public IViewComponentResult Invoke ()
        {
            ViewBag.v1 = context.Categories.Count();
            ViewBag.v2 = context.Courses.Count();
            ViewBag.v3 = 680;
            return View(); 
        }
    }
}
