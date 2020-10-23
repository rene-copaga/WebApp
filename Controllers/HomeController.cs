using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext context;
        public HomeController(DataContext ctx)
        {
            context = ctx;
        }

        public async Task<IActionResult> Index(long id = 1)
        {
            ViewBag.AveragePrice = await context.Products.AverageAsync(p => p.Price);
            return View(await context.Products.FindAsync(id));
        }

        public IActionResult List()
        {
            return View(context.Products);
        }
    }
}
