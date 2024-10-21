using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/* According to Australian standard 
     * Course refers to the program into which a student enrols.
     * Different Units are taught in a course.
     * Below are examples of different Courses:
     * Certificate I in Information Technology, 
     * Certificate II in Information Technology, 
     * Certificate III in Information Technology, 
     * Diploma in Information Technology,
     * Bachelor in Information Technology,
     * Postgraduate Certificate in Information Technology,
     * Postgraduate Diploma in Information Technology,
     * Master in Information Technology,
     * Doctor of Philosophy in Information Technology,
     * Certificate I in Business Information Systems, 
     * Certificate II in Business Information Systems, 
     * Certificate III in Business Information Systems, 
     * Diploma in Business Information Systems,
     * Bachelor in Business Information Systems,
     * Postgraduate Certificate in Business Information Systems,
     * Postgraduate Diploma in Business Information Systems,
     * Master in Business Information Systems,
     * Doctor of Philosophy in Business Information Systems,
     */

namespace MyUniversityMVCAssignmentWeek2.Models
{
    public class Course
    {
        public virtual string Id { get; set; }

        public virtual string CourseName { get; set; }

        /* Description: some description about the Course */
        public virtual string CourseDescription { get; set; }

        /* According to Australian Government rule not all courses are offered to international students.
         * Only some courses are offered to international students, as these courses have CRICOS code.
         * International students can enrol into this course if it has CRICOS code
         */
        public virtual string CricosCode { get; set; }

        /*
         * According to Australian standard,
         * Unit refers to subject,
         * e.g., Data Structure,
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
         */

        /* Units: List of Units belong to the Course */
        public virtual List<Unit> Units { get; set; }

        //public virtual List<UnitCourse> UnitCourses { get; set; }

        public virtual List<Student> Students { get; set; }

        //public virtual List<CourseStudent> CourseStudents { get; set; }
    }
}