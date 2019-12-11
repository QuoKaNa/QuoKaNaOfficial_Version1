using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            OrderClient CC = new OrderClient();
            ViewBag.listOrders = CC.findAll();

            return View();
        }
        public ActionResult ChoXacNhan()
        {
            OrderClient CC = new OrderClient();
            ViewBag.listOrders = CC.findAll();

            return View();
        }
        public ActionResult ChoLayHang()
        {
            OrderClient CC = new OrderClient();
            ViewBag.listOrders = CC.findAll();

            return View();
        }
        public ActionResult DangGiao()
        {
            OrderClient CC = new OrderClient();
            ViewBag.listOrders = CC.findAll();

            return View();
        }
        public ActionResult DaGiao()
        {
            OrderClient CC = new OrderClient();
            ViewBag.listOrders = CC.findAll();

            return View();
        }
        public ActionResult DaHuy()
        {
            OrderClient CC = new OrderClient();
            ViewBag.listOrders = CC.findAll();

            return View();
        }
        public ActionResult TraHang()
        {
            OrderClient CC = new OrderClient();
            ViewBag.listOrders = CC.findAll();

            return View();
        }
        public ActionResult Detail(int id)
        {
            using (ShopDbContext db = new ShopDbContext())
            {
                return View(db.Orders.Where(x => x.ID == id).FirstOrDefault());
            }
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public ActionResult Create(OrderViewModel cvm)
        {
            OrderClient CC = new OrderClient();
            CC.Create(cvm.Order);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            OrderClient CC = new OrderClient();
            CC.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            OrderClient CC = new OrderClient();
            OrderViewModel CVM = new OrderViewModel();
            CVM.Order = CC.find(id);
            return View("Edit", CVM);
        }
        [HttpPost]
        public ActionResult Edit(OrderViewModel CVM)
        {
            OrderClient CC = new OrderClient();
            CC.Edit(CVM.Order);
            return RedirectToAction("Index");
        }
    }
}