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
    public class IndexModel : PageModel
    {
        private readonly HotelManagement.Data.HotelManagementContext _context;

        public IndexModel(HotelManagement.Data.HotelManagementContext context)
        {
            _context = context;
        }

        public IList<Query> Query { get;set; }

        public async Task OnGetAsync()
        {
            Query = await _context.Query.ToListAsync();
        }
    }
}
