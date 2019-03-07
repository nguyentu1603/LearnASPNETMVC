using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class CalculatorController : Controller
    {
        //
        // GET: /Calculator/
        public ActionResult Index()
        {
            return View();
        }
        public string ShowAuthor()
        {
            return "Nguyen Anh Tu";
        }
        public double Factorial(int id)
        {
            int n = id;
            double fac = 1;
            for (int i = 1; i <= n; i++)
            {
                fac = fac * i;
            }
            return fac;
        }
        public int Sum(int a, int b)
        {
            int s = a + b;
            return s;
        }
	}
}