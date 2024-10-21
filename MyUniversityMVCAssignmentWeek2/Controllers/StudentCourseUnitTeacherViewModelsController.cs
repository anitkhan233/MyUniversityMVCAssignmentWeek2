using MyUniversityMVCAssignmentWeek2.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyUniversityMVCAssignmentWeek2.Models;
using System.Data.SqlClient;
using Microsoft.Owin;
using Microsoft.Owin.Security.Provider;

namespace MyUniversityMVCAssignmentWeek2.Controllers
{
    public class StudentCourseUnitTeacherViewModelsController : Controller
    {
        private MyUniversityMVCAssignmentWeek2Database db = new MyUniversityMVCAssignmentWeek2Database();

        // GET: StudentCourseUnitTeacherViewModels
        public ActionResult Index()
        {
            List<StudentCourseUnitTeacherViewModels> StudentCourseUnitTeachers = new List<StudentCourseUnitTeacherViewModels>();
            
            string queryString = "SELECT utsstu.UnitName, utsstu.UnitDescription, utsstu.TeacherName, utsstu.StudentName, \r\ncsc.CourseName, csc.CourseDescription \r\nFROM \r\n(SELECT u.UnitName, u.UnitDescription, tsstu.TeacherName, tsstu.StudentName, tsstu.Id \r\nFROM dbo.Units AS u\r\nINNER JOIN \r\n(SELECT t.TeacherName, sstu.StudentName, sstu.Unit_Id, sstu.Id FROM dbo.Teachers AS t \r\nINNER JOIN \r\n(SELECT s.Id, s.StudentName, stu.Teacher_Id, stu.Unit_Id FROM dbo.Students AS s \r\nINNER JOIN \r\n(SELECT us.Student_Id, tu.Teacher_Id, tu.Unit_Id\r\nFROM dbo.UnitStudents AS us INNER JOIN dbo.TeacherUnits AS tu \r\nON (us.Unit_Id = tu.Unit_Id)) AS stu \r\nON (s.Id = stu.Student_Id)) AS sstu \r\nON (t.Id = sstu.Teacher_Id)) AS tsstu \r\nON (u.Id = tsstu.Unit_Id)) AS utsstu\r\nINNER JOIN\r\n(SELECT c.Id, c.CourseName, c.CourseDescription, sc.Student_Id from dbo.Courses as c \r\nINNER JOIN \r\nStudentCourses as sc \r\nON (c.Id = sc.Course_Id)) AS csc\r\nON (utsstu.Id = csc.Student_Id)";
            
            string connectionString = "Data Source=LAPTOP-BGCGVA3O;Initial Catalog=MyUniversityMVCAssignmentWeek2Database;Integrated Security=True";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                
                connection.Open();
                
                SqlDataReader reader = command.ExecuteReader();
                
                try
                {
                    while (reader.Read())
                    {
                        StudentCourseUnitTeachers.Add(new StudentCourseUnitTeacherViewModels
                        {
                            UnitName = reader["UnitName"].ToString(),
                            UnitDescription = reader["UnitDescription"].ToString(),
                            TeacherName = reader["TeacherName"].ToString(),
                            StudentName = reader["StudentName"].ToString(),
                            CourseName = reader["CourseName"].ToString(),
                            CourseDescription = reader["CourseDescription"].ToString()
                        });
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }

            return View(StudentCourseUnitTeachers);
        }

    }
}
