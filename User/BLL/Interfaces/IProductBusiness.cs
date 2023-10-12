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
		bool CreateProduct(ProductModel model);
		bool UpdateProduct(ProductModel model);
		bool DeleteProduct(string id);
	}
}
