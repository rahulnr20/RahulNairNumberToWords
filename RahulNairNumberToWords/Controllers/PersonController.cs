using RahulNairNumberToWords.Models;
using System.Web.Mvc;
using RahulNairNumberToWords.Utilities;

namespace RahulNairNumberToWords.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult DetailsSummary(Person person)
        {
            person.numberInWords = Helper.NumberToWords(person.number);
            return View(person);
        }
    }
}