using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyUniversityMVCAssignmentWeek2.Data
{
    public class MyUniversityMVCAssignmentWeek2Database : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MyUniversityMVCAssignmentWeek2Database() : base("name=MyUniversityMVCAssignmentWeek2Database")
        {
        }

        public System.Data.Entity.DbSet<MyUniversityMVCAssignmentWeek2.Models.Teacher> Teachers { get; set; }

        public System.Data.Entity.DbSet<MyUniversityMVCAssignmentWeek2.Models.Unit> Units { get; set; }

        public System.Data.Entity.DbSet<MyUniversityMVCAssignmentWeek2.Models.Course> Courses { get; set; }

        public System.Data.Entity.DbSet<MyUniversityMVCAssignmentWeek2.Models.Student> Students { get; set; }
    }
}
