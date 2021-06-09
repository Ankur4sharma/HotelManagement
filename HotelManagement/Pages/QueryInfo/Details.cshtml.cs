using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HotelManagement.Data;
using HotelManagement.Models;

namespace HotelManagement.Pages.QueryInfo
{
    public class DetailsModel : PageModel
    {
        private readonly HotelManagement.Data.HotelManagementContext _context;

        public DetailsModel(HotelManagement.Data.HotelManagementContext context)
        {
            _context = context;
        }

        public Query Query { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Query = await _context.Query.FirstOrDefaultAsync(m => m.id == id);

            if (Query == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
