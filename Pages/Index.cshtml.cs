﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private DataContext context;
        public Product Product { get; set; }
        public IndexModel(DataContext ctx)
        {
            context = ctx;
        }
        public async Task<IActionResult> OnGetAsync(long id = 1)
        {
            Product = await context.Products.FindAsync(id);
            return Page();
        }
    }
}
