using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FebSec10Prj.Models;

namespace FebSec10Prj.Data
{
    public class StudentsContext : DbContext
    {
        public StudentsContext (DbContextOptions<StudentsContext> options)
            : base(options)
        {
        }

        public DbSet<FebSec10Prj.Models.Student> Student { get; set; } = default!;
    }
}
