﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace corkboard.Models
{
	public class CourseProp
	{
		[Key]
		public int PostId { get; set; }

		[Required]
		public string Creator { get; set; }

		[Required]
		public string Title { get; set; }

		[Required]
		public string Body { get; set; }

		[Required]
		public DateTime Dt { get; set; }
	}
}
