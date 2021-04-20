using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace GUI_Restaurant.Models
{
    public class RestaurantDbContext : DbContext
    {
        public virtual DbSet<Guest> Guests { get; set; }

        public RestaurantDbContext() : base()
        {

        }
    }
}
