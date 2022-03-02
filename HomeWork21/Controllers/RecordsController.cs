using HomeWork21.ContextFolder;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork21.Controllers
{
    public class RecordsController : Controller
    {
        public IActionResult RecordBook()
        {
            ViewBag.Record = new DataContext().Records;
            return View();
        }
        
        
        [HttpGet]
        public IActionResult RecordPage()
        {
            return View();
        }

        
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult GetDataFromViewFields(string lastName, string firstName, string middleName, string phone, string adress, string info)
        {
            using(var db = new DataContext())
            {
                db.Records.Add(
                    new Entitys.Record()
                    { 
                        LastName = lastName,
                        FirstName = firstName,
                        MiddleName = middleName,
                        Phone = phone,
                        Adress = adress,
                        Info = info
                    });
                db.SaveChanges();
            }           
            return Redirect("~/");
        }

        //[HttpDelete]
        public IActionResult DeleteData(int id)
        {
            var db = new DataContext();
            var order = db.Records.Where(o => o.ID == id).FirstOrDefault();
            db.Remove(order);
            db.SaveChanges();         
            return Redirect("~/");
        }
    }
}
