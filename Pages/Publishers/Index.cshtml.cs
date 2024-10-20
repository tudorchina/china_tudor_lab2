using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using china_tudor_lab2.Data;
using china_tudor_lab2.Models;

namespace china_tudor_lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly china_tudor_lab2.Data.china_tudor_lab2Context _context;

        public IndexModel(china_tudor_lab2.Data.china_tudor_lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
