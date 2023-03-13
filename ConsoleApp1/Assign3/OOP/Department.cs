using System;
namespace Assign3
{
	public class Department : IDepartmentService
	{
		List<Course> providedCourse;
		int budget;
		Instructor head;
		public Department(int budget, Instructor head, List<Course> providedCourse)
		{
			this.budget = budget;
			this.head = head;
			this.providedCourse = providedCourse;
		}

        public void addCourse(Course course)
        {
			providedCourse.Add(course);
        }
    }
}

