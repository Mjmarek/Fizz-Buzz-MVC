using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FizzBuzzMvc.Controllers
{

    public class FizzBuzzController : Controller
    {
        private string ToFizzBuzz(int value)
        {
            var isDivisiblebyFive = value % 5 == 0;
            var isDivisiblebyThree = value % 3 == 0;

            if (isDivisiblebyFive && isDivisiblebyThree) return "FizzBuzz";
            if (isDivisiblebyFive) return "Buzz";
            if (isDivisiblebyThree) return "Fizz";

            //return value.ToString();
            //return String.Format("{0}", value);
            return $"{value}"; //syntactically equivalent to previous 2 lines
        }

        // GET: FizzBuzz
        public ActionResult Index()
        {
            var model = Enumerable.Range(1, 100).Select(ToFizzBuzz);
            return View(model);
        }
    }
}