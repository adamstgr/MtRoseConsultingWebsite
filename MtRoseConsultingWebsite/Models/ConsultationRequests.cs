using System;
namespace MtRoseConsultingWebsite.Models
{
	public class ConsultationRequests
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string Email { get; set; }

		public string PhoneNumber { get; set; }

		public string About { get; set; }



		public ConsultationRequests()
		{
		}
	}
}

