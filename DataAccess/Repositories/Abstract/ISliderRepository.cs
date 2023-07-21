﻿using Common.Entities;
using DataAccess.Repositories.Base;
using DataAccess.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstract
{
	public interface ISliderRepository: IRepository<Slider> 
	{
		 void SofDeleteAsync(Slider slider);
	}
}
