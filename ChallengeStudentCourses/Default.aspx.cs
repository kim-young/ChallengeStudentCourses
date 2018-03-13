using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */

            List<Course> course = new List<Course>()
            {
                new Course() { CourseId=001, Name="HTML & CSS", Students= new List<Student>() {
                    new Student() { StudentId=101, Name="Young Kim"},
                    new Student() { StudentId=102, Name="Kris Lee"}
                } },
                new Course() { CourseId=002, Name="Javascript", Students=new List<Student>(){
                    new Student() { StudentId=102, Name="Kris Lee"},
                    new Student() { StudentId=103, Name="Colin Mackay"}
                } },
                    
                new Course() { CourseId=003, Name="C# (C Sharp)", Students = new List<Student>() {
                    new Student() { StudentId=101, Name="Young Kim"},
                    new Student() { StudentId=103, Name="Colin Mackay"}
                } }
            };

            foreach (var courses in course)
            {
                resultLabel.Text += String.Format("{0} - {1}<br>", courses.CourseId, courses.Name);
                foreach (var student in courses.Students)
                {
                    resultLabel.Text += String.Format("&nbsp;&nbsp;{0} - {1}<br>", student.StudentId, student.Name);
                }
            }
            
        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */
            Course course1 = new Course() { CourseId = 101, Name = "HTML&CSS" };
            Course course2 = new Course() { CourseId = 102, Name = "Javascript" };
            Course course3 = new Course() { CourseId = 103, Name = "C# (C Sharp)" };

            Dictionary<int, Student> students = new Dictionary<int, Student>() {
                { 1, new Student() { StudentId=1, Name="Young Kim", Courses = new List<Course> { course1, course2} } },
                { 2, new Student() { StudentId=2, Name="Kris Lee", Courses = new List<Course> { course2, course3} } },
                { 3, new Student() { StudentId=3, Name="Kyle Binger", Courses = new List<Course> { course1, course3}} },
            };

            foreach (var student in students)
            {
                resultLabel.Text += String.Format("{0} - {1}<br>", student.Value.StudentId, student.Value.Name);
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += String.Format("&nbsp;&nbsp;{0} - {1}<br>", course.CourseId, course.Name);
                }
            }
        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */

            Student student = new Student();
            student.StudentId = 4547004;
            student.Name = "Young Kim";
            student.Enrollments = new List<Enrollment>()
            {
                new Enrollment { Grade = 97, Course = new Course(){CourseId = 101, Name = "HTML&CSS"}},
                new Enrollment { Grade = 85, Course = new Course(){CourseId = 401, Name = "C# (C Sharp)"}}
            };

            resultLabel.Text += String.Format("Student: {0} - {1}<br>", student.StudentId, student.Name);
            foreach (var enrollments in student.Enrollments)
            {
                resultLabel.Text += String.Format("&nbsp;&nbsp;Enrolled in: {0} - {1} : {2}<br>", enrollments.Course.CourseId, enrollments.Course.Name, enrollments.Grade);
            }

        }
    }
}