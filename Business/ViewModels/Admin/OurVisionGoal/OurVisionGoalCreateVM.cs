﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ViewModels.Admin.OurVisionGoal
{
	public class OurVisionGoalCreateVM
	{
		[Required]
		public string Title { get; set; }

		[Required]
		public string Desc { get; set; }

		[Required]
		public IFormFile PhotoFile { get; set; }
	}
}
