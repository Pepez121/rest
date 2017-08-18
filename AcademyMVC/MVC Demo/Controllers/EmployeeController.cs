using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Demo.Models;
using System.Data;

namespace MVC_Demo.Controllers
{
    public class EmployeeController : Controller
    {
        private EmpDbContext db = new EmpDbContext();
        // GET: Employee
        public ActionResult Index()
        {
            var Employees = from e in db.Employees
                            orderby e.ID
                            select e;
            return View(Employees);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                
                //// TODO: Add insert logic here
                //Employee emp = new Employee();
                //emp.Name = collection["Name"];
                //DateTime jDate;
                //DateTime.TryParse(collection["JoiningDate"], out jDate);
                //emp.JoiningDate = jDate;
                //string age = collection["Age"];
                //emp.Age = Int32.Parse(age);
                //empList.Add(emp);
                

                db.Employees.Add(emp);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            //List<Employee> empList = GetEmployeeList();
            //var employee = empList.Single(x => x.ID == id);

            var employee = db.Employees.Single(x => x.ID == id);
            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                //var employee = empList.Single(x => x.ID == id);
                var employee = db.Employees.Single(x => x.ID == id);
                if (TryUpdateModel(employee))
                {
                    //To Do Database Code
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(employee);
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public static List<Employee> empList = new List<Employee>
        {
                new Employee
                {
                    ID = 0,
                    Name = "Luis",
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 24
                },

                new Employee
                {
                    ID = 1,
                    Name = "Pepe",
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 18
                },

                new Employee
                {
                    ID = 2,
                    Name = "Gaby",
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 27
                }
            };

        public List<Employee> GetEmployeeList()
        {
            return empList;
        }
    }
}
