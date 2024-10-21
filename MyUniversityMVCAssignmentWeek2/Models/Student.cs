using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
     * According to Australian standard
     * A tertiary (i.e., beyond year 12) Student can enrol into into one or more course(s)
     * and studying different units belong to those course(s)
     */

namespace MyUniversityMVCAssignmentWeek2.Models
{
    public class Student
    {
        public virtual string Id { get; set; }

        public virtual string StudentName { get; set; }

        public virtual DateTime StudentDateOfBirth { get; set; }

        public virtual string StudentEmail { get; set; }

        public virtual string StudentAdress { get; set; }

        /* EnrolmentStatus: Enrolled or Not Enrolled */
        public virtual string EnrolmentStatus { get; set; }

        /* ModeOfStudy: Remote or OnCampus */
        public virtual string ModeOfStudy { get; set; }

        /* StudentType: FullTime or PartTime  */
        public virtual string StudentType { get; set; }

        /* Courses: refers to the Courses the student is currently enrolled into */
        public virtual List<Course> Courses { get; set; }

        //public virtual List<CourseStudent> CourseStudents { get; set; }

        /* Units: refers to the List of Units the student is currently enrolled into */
        public virtual List<Unit> Units { get; set; }

        //public virtual List<UnitStudent> UnitStudents { get; set; }

        //public virtual Image StudentImage { get; set; }

        /* StudentDocuments refers to various documents of the student, e.g., photo, resume, certificate */
        //public virtual List<DocumentOfStudent> StudentDocuments { get; set; }
        public Student() { }
    }
}