using System.Web;
using System.Web.Mvc;

namespace _2015_07_16_MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        //when we append "HelloWorld" to the browser name, we get "This is my <b>default</b> action..."


        //public string Index()
        //{
        //    return "This is my <b>default</b> action...";
        //}

        //REPLACING THAT WITH THIS, THEN GOING TO MAKE CHANGE TO INDEX:

        public ActionResult Index()
        {
            return View();
        }
           

        //
        // GET: /HelloWorld/Welcome/

        //change variable from "numTimes" to "ID", which matches the URL specification in the RegisterRoutes method.


        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        //}

        //public string Welcome(string name, int ID = 1)
        //{
        //    return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        //}
        //CHANGING CODE AGAIN, TO PUT DYNAMIC DATA (PARAMETERS) THAT THE VIEW TEMPLATE NEEDS IN A VIEWBAG OBJECT THAT THE VIEW TEMPLATE CAN THEN ACCESS.

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }

    }
}

