using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
    * According to Australian standard,
    * Unit refers to one subject,
    * A Unit is taught as part of a Course.
    * A Course of consists of different Unit(s)
    * Below are some examples of different Units:
    * Data Structure,
    * Algorithms,
    * Structured Programming Language (i.e., C)
    * Object Oriented Programming Languages (i.e., C++, JAVA, C#)
    * Discrete Math,
    * Data Communication,
    * Computer Networks,
    * System Analysis and Design,
    * Mathematics for Computer Science,
    * Multimedia
    * and so forth
    * 
    * The Lecturer of a Unit who is a Teacher delivers the lectures.
    * Also, there can be one or more Tutors to assist students
    * 
    */
namespace MyUniversityMVCAssignmentWeek2.Models
{
    public class Unit
    {

        public virtual string Id { get; set; }
        public virtual string UnitName { get; set; }
        public virtual string UnitDescription { get; set; }

        /*
         * The Lecturer refers to the Teacher 
         * who delivers the lectures of that unit.
         */
        public virtual List<Teacher> Teachers { get; set; }

        //public virtual List<UnitTeacher> UnitTeachers { get; set; }

        public virtual List<Course> Courses { get; set; }

        //public virtual List<UnitCourse> UnitCourses { get; set; }

        public virtual List<Student> Students { get; set; }

        //public  virtual List<UnitStudent> UnitStudents { get; set; }


    }
}