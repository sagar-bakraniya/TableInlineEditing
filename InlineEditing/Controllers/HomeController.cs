using InlineEditing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace InlineEditing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index () {
            List<Employee> employees = new List<Employee>() 
            {
                new Employee() { ID = 1 , EmpName = "emp 1" , Designation = "designation" , Salary = 59990m } ,
                new Employee() { ID = 2 , EmpName = "emp 2" , Designation = "designation" , Salary = 30000m } ,
                new Employee() { ID = 3 , EmpName = "emp 3" , Designation = "designation" , Salary = 59990m } ,
                new Employee() { ID = 4 , EmpName = "emp 4" , Designation = "designation" , Salary = 6690m } ,
                new Employee() { ID = 5 , EmpName = "emp 5" , Designation = "designation" , Salary = 79990m } ,

            };
            GridView grid = new GridView();
            return View( employees );
        }

        public ActionResult About () {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact () {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Update (Employee employee) {
            List<Employee> employees = new List<Employee>()
           {
                new Employee() { ID = 1 , EmpName = "emp 1" , Designation = "designation" , Salary = 59990m } ,
                new Employee() { ID = 2 , EmpName = "emp 2" , Designation = "designation" , Salary = 30000m } ,
                new Employee() { ID = 3 , EmpName = "emp 3" , Designation = "designation" , Salary = 59990m } ,
                new Employee() { ID = 4 , EmpName = "emp 4" , Designation = "designation" , Salary = 6690m } ,
                new Employee() { ID = 5 , EmpName = "emp 5" , Designation = "designation" , Salary = 79990m } ,

            };

            // update login

            return View( employees );
        }


        [HttpPost]
        public ActionResult Delete ( Employee employee ) {
            List<Employee> employees = new List<Employee>()
           {
                new Employee() { ID = 1 , EmpName = "emp 1" , Designation = "designation" , Salary = 59990m } ,
                new Employee() { ID = 2 , EmpName = "emp 2" , Designation = "designation" , Salary = 30000m } ,
                new Employee() { ID = 3 , EmpName = "emp 3" , Designation = "designation" , Salary = 59990m } ,
                new Employee() { ID = 4 , EmpName = "emp 4" , Designation = "designation" , Salary = 6690m } ,
                new Employee() { ID = 5 , EmpName = "emp 5" , Designation = "designation" , Salary = 79990m } ,

            };

            // update login

            return View( employees );
        }
    }
}