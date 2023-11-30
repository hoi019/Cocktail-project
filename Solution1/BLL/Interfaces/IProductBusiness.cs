﻿using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
	public interface IProductBusiness
	{
		List<ProductModel> GetAllProduct();
		ProductModel GetByIdProduct(string id);
		List<ProductModel> FilterProduct(int index);
	}
}
