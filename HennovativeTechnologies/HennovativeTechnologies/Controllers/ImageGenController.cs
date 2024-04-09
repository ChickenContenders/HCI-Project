using Microsoft.AspNetCore.Mvc;
using HennovativeTechnologies.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace HennovativeTechnologies.Controllers
{
    public class ImageGenController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
