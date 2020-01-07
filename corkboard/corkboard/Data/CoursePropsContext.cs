using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace corkboard.Models
{
    public class CoursePropsContext : DbContext
    {
        public CoursePropsContext (DbContextOptions<CoursePropsContext> options)
            : base(options)
        {
        }

        public DbSet<corkboard.Models.CourseProp> CourseProp { get; set; }
    }
}
