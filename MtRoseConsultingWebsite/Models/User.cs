using System;
using Microsoft.AspNetCore.Identity;

namespace MtRoseConsultingWebsite.Models
{
	public class User : IdentityUser
	{

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string CompanyName { get; set; }
		public DateTime Created { get; set; }

		public User()
		{
		}
	}
}

