using System;
namespace Assign3
{
	public class Student : Person, IStudentService 
	{

        private List<Course> classlist { get; set; }
		public Student(DateOnly date, decimal money, List<string> address,List<Course> classlist) :base(date,money,address)
		{
            this.classlist = classlist;
		}

       

        decimal IStudentService.getGPA()
        {
            throw new NotImplementedException();
        }

        public void addClass(Course course)
        {
            classlist.Add(course);
        }

        public override decimal getSalary()
        {
            throw new NotImplementedException();
        }
    }
}

