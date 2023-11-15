﻿using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
	public interface IManafactureBusiness
	{
		List<ManafactureModel> GetAllManafacture();
		ManafactureModel GetDataByIdManafacture(string id);
		bool CreateManafacture(ManafactureModel md);
		bool UpdateManafacture(ManafactureModel md);
		bool DeleteManafacture(string id);
		List<ManafactureModel> SearchManafacture(int pageIndex, int pageSize, string ten_khach, out long total);
	}
}
