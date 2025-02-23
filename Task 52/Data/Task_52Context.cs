using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task_52.Models;

namespace Task_52.Data
{
    public class Task_52Context : DbContext
    {
        public Task_52Context (DbContextOptions<Task_52Context> options)
            : base(options)
        {
        }

        public DbSet<Task_52.Models.User> User { get; set; } = default!;
    }
}
