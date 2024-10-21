using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyUniversityMVCAssignmentWeek2.Models
{

    public class StudentCourseUnitTeacherViewModels
    {
        public virtual string UnitName { get; set; }

        public virtual string UnitDescription { get; set; }

        public virtual string TeacherName { get; set; }

        public virtual string StudentName { get; set; }

        public virtual string CourseName { get; set; }

        public virtual string CourseDescription { get; set; }
    }
}