using BiletlemeSis.Models;
using BiletlemeSis.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace BiletlemeSis.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Customer customer = new Customer(); 
            CustomerRepo repo= new CustomerRepo();  

            customer = repo.GetById(1);

            return Redirect("/Home/Index");
        }

        public ActionResult Update()
        {
            Customer customer = new Customer(); 
            CustomerRepo repo= new CustomerRepo();

            customer.Id = 1;
            customer.Name = "test";
            customer.Surname = "test";
            customer.Email = "test";
            customer.CreateDate = DateTime.Now;
            customer.Birthday = DateTime.Now;
            customer.TelephoneNumber = "test";
            customer.Male = "test";
            customer.IsActive = true;
            customer.IsDelete = true;

            if (!repo.Update(customer))
            {
                customer = null; 
            }
            return Redirect("/Home/Update");
        }

        public ActionResult Delete()
        {
            Customer customer = new Customer();
            CustomerRepo repo= new CustomerRepo();

            customer = repo.GetById(1);
            customer.Name = "test";
            customer.Surname = "test";
            customer.Email = "test";
            customer.CreateDate = DateTime.Now;
            customer.Birthday = DateTime.Now;
            customer.TelephoneNumber = "test";
            customer.Male = "test";
            customer.IsActive = true;
            customer.IsDelete = true;

            if (!repo.Delete(customer))
            {
                customer = null;
            }
            return Redirect("Home/Delete");
        }

        public ActionResult Insert()
        {
            Customer customer = new Customer(); 
            CustomerRepo repo= new CustomerRepo();

            customer.Id = new int();
            customer.Name = "test";
            customer.Surname = "test";
            customer.Email = "test";
            customer.CreateDate = DateTime.Now;
            customer.Birthday = DateTime.Now;
            customer.TelephoneNumber = "test";
            customer.Male = "test";
            customer.IsActive = true;
            customer.IsDelete = true;

            if (repo.Insert(customer) > 0)
            {
                customer = null;    
            }
            return Redirect("/Home/Insert");
        }
    }   
}