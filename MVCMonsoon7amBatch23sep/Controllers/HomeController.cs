﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMonsoon7amBatch23sep.Models;

namespace MVCMonsoon7amBatch23sep.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Getname()
        {
            return "Hello Divya";
        }

        public string GetEmpId(int? id)
        {
            return "Hello Divya your EmpId "+id;
        }

       
        public ActionResult GetMyView2()
        {

            return View("~/Views/Default/Index.cshtml");
        }

        public ActionResult Index()
        {

            return View();
        }



        public ActionResult GetMyView()
        {

            return View();
        }

        public ActionResult GetEmployee()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.Empid = 1211;
            obj.EmpName = "Swapnil";
            obj.EmpSalary = 29000;

            ViewBag.Employee = obj;
            
            return View();
        }

        public ActionResult GetEmployeeAll()
        {
            List<EmployeeModel> listobj = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.Empid = 1211;
            obj.EmpName = "Swapnil";
            obj.EmpSalary = 29000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.Empid = 1212;
            obj1.EmpName = "Divya";
            obj1.EmpSalary = 39000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.Empid = 1213;
            obj2.EmpName = "Manoj";
            obj2.EmpSalary = 49000;

            listobj.Add(obj);
            listobj.Add(obj1);
            listobj.Add(obj2);


            ViewBag.Employee = listobj;
            

            return View();
        }



        public ActionResult GetEmployeeModel()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.Empid = 1211;
            obj.EmpName = "Swapnil";
            obj.EmpSalary = 29000;

            //object model=obj;
            return View(obj);
        }

        public ActionResult GetAllEmployeeModel()
        {
            List<EmployeeModel> listobj = new List<EmployeeModel>();
            EmployeeModel obj = new EmployeeModel();
            obj.Empid = 1211;
            obj.EmpName = "Swapnil";
            obj.EmpSalary = 29000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.Empid = 1212;
            obj1.EmpName = "Divya";
            obj1.EmpSalary = 39000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.Empid = 1213;
            obj2.EmpName = "Swathi";
            obj2.EmpSalary = 49000;//

            listobj.Add(obj);
            listobj.Add(obj1);
            listobj.Add(obj2);
            //object model=obj;
            return View(listobj);
        }

        public ViewResult GetMyView1() {
            return View();
        }
        public RedirectResult RedirectmeToGoogle() {
            //return Redirect("http://www.google.com");
            return Redirect("~/home/GetMyView1");
        }
        public RedirectToRouteResult GetMyRoute()
        {
            //return RedirectToRoute("Tiger");
            return RedirectToAction("Index","Default",new { id = 1 });
        }

        public JsonResult GetJSonData() {

            List<EmployeeModel> listobj = new List<EmployeeModel>();
            EmployeeModel obj = new EmployeeModel();
            obj.Empid = 1211;
            obj.EmpName = "Swapnil";
            obj.EmpSalary = 29000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.Empid = 1212;
            obj1.EmpName = "Divya";
            obj1.EmpSalary = 39000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.Empid = 1213;
            obj2.EmpName = "Swathi";
            obj2.EmpSalary = 49000;//

            listobj.Add(obj);
            listobj.Add(obj1);
            listobj.Add(obj2);

            return Json(listobj, JsonRequestBehavior.AllowGet);
        }

        public FileResult getMeFile()
        {
            return File("~/Web.config","application/xml","Web.config");

        }

        public ContentResult getMyContent(int? id)
        {
            if (id == 1)
            {
                return Content("hello world");
            }
            else if (id==2)
            {
                return Content("<p style='color:red'>hello world</p>");
            }
            else
            {
                return Content("<script>alert('hello world');</script>");

            }
        }
    }
}