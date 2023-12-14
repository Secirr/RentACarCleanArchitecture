using System;
using Core.Persistence.Repositories;

namespace Domain.Entities
{
	public class UserType : Entity<Guid>
	{
		public string Name { get; set; }


		//Customer
		//Seller
		//Other
	}
}

