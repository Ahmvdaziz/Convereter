using Microsoft.AspNetCore.Mvc;
using Convereter.Models;

namespace Convereter.Controllers
{
    public class LanguageController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Convert(string text, string targetLanguage)
        {
            string result = string.Empty;
            if (targetLanguage == "Franco")
            {
                result = LanguageConverter.ConvertToFranco(text);
            }
            else if (targetLanguage == "Arabic")
            {
                result = LanguageConverter.ConvertToArabic(text);
            }

            // إعادة النتيجة كـ JSON
            return Json(new { result = result });
        }
    }
}
