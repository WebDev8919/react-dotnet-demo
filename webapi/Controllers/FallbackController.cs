using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    public class FallbackController : Controller
    {
        public IActionResult Index()
        {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "404.html"), MediaTypeNames.Text.Html);
        }
    }
}
