using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorProductivityProject.Data;
using BlazorProductivityProject.Models;
using BlazorProductivityProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BlazorProductivityProject.Pages.Demos.Pdf
{
    public class PdfDemoModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public PdfDemoModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<Product> Items { get; set; }

        public async Task<IActionResult> OnGet()
        {
            Items = await _db.Products.Include(x=>x.Category).ToListAsync();
            //return Page();

            return new RazorPageAsPdf(this)
            {
                FileName = "xxx.pdf",
                PageMargins = new Rotativa.AspNetCore.Options.Margins(10, 10, 10, 10),
                PageSize = Rotativa.AspNetCore.Options.Size.A4,
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,
                CustomSwitches = "--page-offset 0 --footer-center [page] --footer-font-size 8",
            };
        }
    }
}
