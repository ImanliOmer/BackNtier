using Business.ViewModels.Admin.OurVisionGoal;
using Business.ViewModels.Admin.Slider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Abstract.Admin
{
	public interface IOurVisionGoalService
	{
		Task<bool> CreateAsync(OurVisionGoalCreateVM model);
		Task<bool> UpdateAsync(OurVisionGoalUpdatedVM model, int id);
		Task<bool> DeleteAsync(OurVisionGoalUpdatedVM model, int id);
	}
}
