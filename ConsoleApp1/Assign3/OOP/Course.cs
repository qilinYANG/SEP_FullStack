using System;
namespace Assign3
{
	public class Course : ICourseService
	{
		private string courseName { get; set; }
		private int courseID { get; set; }
		List<Student> enrollment;
		public Course(string courseName, int courseID, List<Student> enrollment)
		{
            this.courseName = courseName;
            this.courseID = courseID;
            this.enrollment = enrollment;
		}

        Grade ICourseService.getGrade(Student stu)
        {
            throw new NotImplementedException();
        }

        public void addStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
	
}

