using MVCNorthWind.BLL;
using MVCNorthWind.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCNorthWind.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Customer()
        {

            List<Customer> cst = CustomerBLL.GetCustomer();


            return View(cst);
        }


        public ActionResult Detay(string id)
        {

            Customer cst = CustomerBLL.GetCustomerDetail(id);
            return View(cst);
        }

        public ActionResult Sil(string id)
        {

            int cst = CustomerBLL.DeleteCustomer(id);

            if (cst > 0)
            {
                return RedirectToAction("Silindi"); 
            }
            return View();
        }

        public ActionResult Silindi()
        {
            return View();
        }
    }
}