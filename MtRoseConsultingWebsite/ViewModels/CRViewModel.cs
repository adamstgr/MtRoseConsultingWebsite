using System;
using System.ComponentModel.DataAnnotations;

namespace MtRoseConsultingWebsite.ViewModels
{
	public class CRViewModel
	{
		[Required(ErrorMessage = "A Name is required.")]
		[StringLength(50, MinimumLength = 2, ErrorMessage = "A Name must be between 2 and 50 characters.")]
		[Display(Name = "Your Name:")]
		public string Name { get; set; }

		[Required(ErrorMessage = "An email is required.")]
		[EmailAddress]
		[Display(Name = "Email Address:")]
		public string Email { get; set; }

		[Phone]
		[Display(Name="Phone Number:")]
		public string PhoneNumber { get; set; }

		[Display(Name = "About Your Business:")]
		public string About { get; set; }


		public CRViewModel()
		{
		}
	}
}

