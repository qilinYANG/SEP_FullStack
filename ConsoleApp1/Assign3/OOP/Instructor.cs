using System;
namespace Assign3
{
	public class Instructor : Person, IInstructorService,IPersonService
	{
		private DateOnly joinDate;

        

        public Department DepartmentBelongsTo()
        {
            throw new NotImplementedException();
        }

        public bool IsDepartmentHead()
        {
            throw new NotImplementedException();
        }

        public int YearOfExperience()
        {
            throw new NotImplementedException();
        }

        public override decimal getSalary()
        {
            throw new NotImplementedException();
        }

        public Instructor(DateOnly joinDate,DateOnly birthday, decimal salary, List<string> address) : base(birthday, salary, address)
        {
            this.joinDate = joinDate;
        }
        
    }
}

