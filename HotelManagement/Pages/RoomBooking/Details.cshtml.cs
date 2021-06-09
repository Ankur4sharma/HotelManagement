using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HotelManagement.Data;
using HotelManagement.Models;

namespace HotelManagement.Pages.RoomBooking
{
    public class DetailsModel : PageModel
    {
        private readonly HotelManagement.Data.HotelManagementContext _context;

        public DetailsModel(HotelManagement.Data.HotelManagementContext context)
        {
            _context = context;
        }

        public BookRoom BookRoom { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BookRoom = await _context.BookRoom.FirstOrDefaultAsync(m => m.id == id);

            if (BookRoom == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
