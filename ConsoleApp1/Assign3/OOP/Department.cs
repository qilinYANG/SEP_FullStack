using System;
namespace Assign3
{
	public class Department
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
	}
}

