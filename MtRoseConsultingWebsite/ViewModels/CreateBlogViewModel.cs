using System;
using System.ComponentModel.DataAnnotations;

namespace MtRoseConsultingWebsite.ViewModels
{
	public class CreateBlogViewModel
	{
		[Required]
		[Display(Name = "Blog Title:")]
		public string Title { get; set; }

		[Required]
		[Display(Name = "Content:")]
		public string Content { get; set; }


		public CreateBlogViewModel()
		{
		}
	}
}

