using System;
namespace Assign3
{
	public abstract class Person : IPersonService
    {

		private DateOnly biryhDay;
		private decimal salary;
		private List<string> address;
		public Person(DateOnly date,decimal money,List<string> address)
		{
			biryhDay = date;
			if (money >= 0)
			{
				salary = money;
			}
			else
				salary = 0;

			this.address = address;
			
		}

        public string getAddress()
        {
            throw new NotImplementedException();
        }

  //      public int getAge()
		//{
		//	return DateTime.Now.Year - biryhDay.Year;
		//}

        public int getAge()
        {
            throw new NotImplementedException();
        }



		public abstract decimal getSalary();
        
    }
}

