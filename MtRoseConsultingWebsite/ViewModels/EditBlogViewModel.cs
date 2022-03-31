using System;
namespace MtRoseConsultingWebsite.ViewModels
{
	public class EditBlogViewModel
	{

		public Guid Id { get; set; }

		[Required]
		[Display(Name = "Blog Title:")]
		public string Title { get; set; }

		[Required]
		[Display(Name = "Content:")]
		public string Content { get; set; }


		public EditBlogViewModel()
		{
		}
	}
}

