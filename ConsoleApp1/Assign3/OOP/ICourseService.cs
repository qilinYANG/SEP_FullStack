using System;
namespace Assign3
{
	public interface ICourseService
	{

		Grade getGrade(Student student);
		void addStudent(Student student);
	}
}

