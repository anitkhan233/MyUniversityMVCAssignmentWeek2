using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyUniversityMVCAssignmentWeek2.Models
{
    public class Teacher
    {
        public virtual string Id { get; set; }

        public virtual string TeacherName { get; set; }

        public virtual DateTime TeacherDateOfBirth { get; set; }

        public virtual string TeacherEmail { get; set; }

        public virtual string TeacherAdress { get; set; }

        /* Position: Lecturer, Assistant Professor, Associate Professor, Professor, Vice Chancellor, etc  */
        public virtual string Position { get; set; }

        /* Department: Information Technology, Business Information Systems, etc   */
        public virtual string Department { get; set; }

        /* EmploymentType: Full Time, Part Time, Contract */
        public virtual string EmploymentType { get; set; }

        public virtual DateTime JoiningDate { get; set; }

        public virtual DateTime EndDate { get; set; }

        public virtual double BaseSalary { get; set; }

        public virtual List<Unit> Units { get; set; }

        //public virtual List<UnitTeacher> UnitTeachers { get; set; }

        //public virtual Image TeacherImage { get; set; }

        /* TeacherDocuments refers to various documents of the teacher, e.g., photo, resume, certificate */
        //public virtual List<DocumentOfTeacher> TeacherDocuments { get; set; }
        public Teacher() { }
    }
}