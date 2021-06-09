﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HotelManagement.Data;
using HotelManagement.Models;

namespace HotelManagement.Pages.RoomBooking
{
    public class CreateModel : PageModel
    {
        private readonly HotelManagement.Data.HotelManagementContext _context;

        public CreateModel(HotelManagement.Data.HotelManagementContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BookRoom BookRoom { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BookRoom.Add(BookRoom);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
