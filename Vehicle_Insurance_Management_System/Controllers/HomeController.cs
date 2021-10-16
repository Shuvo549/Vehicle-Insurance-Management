using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vehicle_Insurance_Management_System.Models;
using Vehicle_Insurance_Management_System.DataContext;
using Vereyon.Web;

namespace Vehicle_Insurance_Management_System.Controllers
{
    public class HomeController : Controller
    {
        Customers aRegister = new Customers();
        private Vehicle_InsuranceDbContext db = new Vehicle_InsuranceDbContext();
        public ActionResult Index()
        {
            if (Session["CustomerName"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            return View();
        }
        public ActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Register(Customers aCustomer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(aCustomer);
                db.SaveChanges();
                FlashMessage.Confirmation("Registration is Successful!");
                return RedirectToAction("Login");
            }
            return View();
        }
        public JsonResult IsEmailExists(string CustomerEmail)
        {
            aRegister.CustomerEmail = CustomerEmail.Trim();
            var em = db.Customers.ToList();
            if (!em.Any(cate => cate.CustomerEmail.ToLower() == aRegister.CustomerEmail.ToLower()))
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Customers aCustomer)
        {
            var registerDetails1 = db.Customers.Where(x => x.CustomerName == aCustomer.CustomerName && x.Password == aCustomer.Password).FirstOrDefault();
            if (registerDetails1 != null)
            {
                Session["CustomerName"] = aCustomer.CustomerName;
                return RedirectToAction("Index", "Home");
            }
            FlashMessage.Confirmation("UserName & Password Doesn't Match!");
            return View();
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login", "Home");
        }
        public ActionResult BikeInsurance()
        {
            if (Session["CustomerName"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            return View();
        }
    }
}