using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
	public interface IProductRespository
	{
		List<AccountModel> GetAllProduct();
		ProductModel GetByIdProduct(int id);
		bool CreateProduct(ProductModel model);
		bool UpdateProduct(ProductModel model);
		bool DeleteProduct(ProductModel model);
	}
}
