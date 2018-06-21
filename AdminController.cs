using ModelShopOnline.Model;
using ShopOnlineMvc1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopOnlineMvc1.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(DetailProductPainting p )
        {
            ShopOnlineDbContext ctx = new ShopOnlineDbContext();
            ctx.Product.Add(p);
            ctx.SaveChanges();
            return Content("ثبت با موفقیت انجام شد ");
           


        }
        public ActionResult ProductList()
        {
            return View();
        } 

    }
}