using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Data
{
    public class HotelManagementContext : DbContext
    {
        public HotelManagementContext (DbContextOptions<HotelManagementContext> options)
            : base(options)
        {
        }

        public DbSet<HotelManagement.Models.Room> Room { get; set; }

        public DbSet<HotelManagement.Models.BookRoom> BookRoom { get; set; }

        public DbSet<HotelManagement.Models.Query> Query { get; set; }
    }
}
