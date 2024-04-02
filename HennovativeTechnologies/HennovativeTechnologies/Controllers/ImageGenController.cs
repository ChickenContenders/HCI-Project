using Microsoft.AspNetCore.Mvc;
using HennovativeTechnologies.Models;
using System.Diagnostics;

namespace HennovativeTechnologies.Controllers
{
    public class ImageGenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
