using System;
namespace Assign3
{
	public interface IInstructorService 
	{
        abstract Department DepartmentBelongsTo();

        abstract Boolean IsDepartmentHead();

        abstract int YearOfExperience();
    }
}

