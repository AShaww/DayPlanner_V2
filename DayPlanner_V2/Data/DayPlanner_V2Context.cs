using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DayPlanner_V2.Models;

namespace DayPlanner_V2.Data
{
    public class DayPlanner_V2Context : DbContext
    {
        public DayPlanner_V2Context (DbContextOptions<DayPlanner_V2Context> options)
            : base(options)
        {
        }

        public DbSet<DayPlanner_V2.Models.TableSchema>? TableSchema { get; set; }
    }
}
