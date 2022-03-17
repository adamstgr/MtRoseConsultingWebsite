using System;
using System.ComponentModel.DataAnnotations;

namespace MtRoseConsultingWebsite.Models
{
	public class BlogPost
	{
		
		public Guid Id { get; set; }

		public DateTime Created { get; set; }

		public string Title { get; set; }

		public string Content { get; set; }


		public BlogPost()
		{
		}

        public BlogPost(string title, string content)
        {
			Created = DateTime.Now;
            Title = title;
            Content = content;
        }
    }
}

