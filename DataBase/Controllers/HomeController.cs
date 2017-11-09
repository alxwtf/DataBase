using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataBase.Models;

namespace DataBase.Controllers
{
    public class HomeController : Controller
    {
        static CompanyContext db = new CompanyContext();


        IEnumerable<Company> companies = db.Companies;

        public ActionResult Index()
        {
            ViewBag.Companies = companies;
            return View();
        }

        public ActionResult DBWork()
        {
            ViewBag.Companies = companies;
            return View();
        }
        [HttpPost]
        public void Edit(int id,string name,string email,string phone,string site, string action, string industry)
        {
            ViewBag.Companies = companies;
            Company company = db.Companies.Where(x => x.Id == id).FirstOrDefault();

            if (action == "remove")
            {
                db.Companies.Remove(company);
            }
            else if (action == "add")
            {
                db.Companies.Add(new Company{name=name,email=email,phone = phone,site = site});
            }
            else if (action == "update")
            {
                if (name != "") company.name = name;
                if (email != "") company.email = email;
                if (phone != "") company.phone = phone;
                if (site != "") company.site = site;
                if (industry!="") company.industry = industry;
            }
        db.SaveChanges();
           Response.Redirect("/Home/DBWork");
        }

        public ActionResult LinqTest()
        {
            return View();
        }
    }
    
}